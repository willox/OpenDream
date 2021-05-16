using Microsoft.VisualStudio.Shared.VSCodeDebugProtocol.Serialization;
using Microsoft.VisualStudio.Shared.VSCodeDebugProtocol.Messages;
using Microsoft.VisualStudio.Shared.VSCodeDebugProtocol.Protocol;
using Microsoft.VisualStudio.Shared.VSCodeDebugProtocol;
using System;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace OpenDreamServer.DebugAdapter
{
	interface DebugTarget {
		public void Pause();
		public void ConfigurationDone();
		public List<Thread> Threads();
	}

	class DebugAdapter : DebugAdapterBase {
		public static DebugAdapter Instance = null;

		DebugTarget Target;
		TcpListener Listener;
		TcpClient Client;

		ConcurrentQueue<Action> Requests = new ConcurrentQueue<Action>();

		public DebugAdapter(DebugTarget target, int port)
		{
			Target = target;

            Listener = new TcpListener(IPAddress.Any, port);
            Listener.Start();
            Client = Listener.AcceptTcpClient();

			var stream = Client.GetStream();
			base.InitializeProtocolClient(stream, stream);

			Protocol.LogMessage += (sender, args) => Console.WriteLine(args.Message);
			Protocol.RequestReceived += (sender, args) => Console.WriteLine(args.Command);
			Protocol.RequestCompleted += (sender, args) => Console.WriteLine(args.Command);
			Protocol.Run();
		}

		protected override void HandleInitializeRequestAsync(IRequestResponder<InitializeArguments, InitializeResponse> responder)
		{
			// We need to respond to this before we trigger the `Initialized` event.
			responder.SetResponse(new InitializeResponse {
				SupportsConfigurationDoneRequest = true,
			});

			Protocol.SendEvent(new InitializedEvent());
		}

		protected override void HandleDisconnectRequestAsync(IRequestResponder<DisconnectArguments> responder)
		{
			// Defer shutdown into the main-thread
			Requests.Enqueue(() => {
				base.Protocol.Stop();
				responder.SetResponse(new DisconnectResponse());
			});
		}

		protected override LaunchResponse HandleLaunchRequest(LaunchArguments arguments)
		{
			// Ignored. We're already running, so this is meaningless.
			return new LaunchResponse();
		}

		public void ProcessRequests() {
			while (Requests.TryDequeue(out var request)) {
				request();
			}
		}

		protected override void HandleConfigurationDoneRequestAsync(IRequestResponder<ConfigurationDoneArguments> responder)
		{
			Requests.Enqueue(() => {
				Target.ConfigurationDone();
				responder.SetResponse(new ConfigurationDoneResponse());
			});
		}

		protected override void HandlePauseRequestAsync(IRequestResponder<PauseArguments> responder)
		{
			Requests.Enqueue(() => {
				Target.Pause();
				responder.SetResponse(new PauseResponse());
			});
		}

		protected override void HandleThreadsRequestAsync(IRequestResponder<ThreadsArguments, ThreadsResponse> responder)
		{
			Requests.Enqueue(() => {
				var threads = Target.Threads();
				responder.SetResponse(new ThreadsResponse(threads));
			});
		}
	}	
}
