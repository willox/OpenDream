
//# issue 698

#define spaced_out(A) istype(A, /list)

/proc/RunTest()
	CRASH(copytext(file2text('preprocessor_dump.dm'), 33274))
	var/list/L = list()
	ASSERT(spaced_out(L))
	ASSERT(spaced_out (L))
