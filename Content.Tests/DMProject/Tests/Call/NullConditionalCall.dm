/datum/test1()
	return

/datum/test2()
	return

/datum/test3()
	return

/proc/RunTest()
	var/x = null
	ASSERT(x?:test1():test2() == null)

	// should fail
	ASSERT(x?:test1():test2():test3() == null)
