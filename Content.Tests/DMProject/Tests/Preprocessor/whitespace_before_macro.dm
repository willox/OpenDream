
//# issue 698

#define spaced_out(A) istype(A, /list)

/proc/RunTest()
	set name = "DumpOpcodes"
	var/list/L = list()
	ASSERT(spaced_out(L))
	ASSERT(spaced_out (L))
