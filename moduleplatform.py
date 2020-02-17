import platform

'''
platform.architecture()
returns information about the bit architecture 

platform.machine()
returns the machine type, e.g. 'i386'.

platform.node()
returns the computer’s network name (may not be fully qualified!)

platform.platform()
returns a single string identifying the underlying platform with as much useful
information as possible.

platform.processor()
returns the (real) processor name, e.g. 'amdk6'.

platform.python_build()
returns a tuple (buildno, builddate) stating the Python build number and
date as strings.

platform.python_compiler()
returns a string identifying the compiler used for compiling Python.

platform.python_version()
returns the Python version as string 'major.minor.patchlevel'

platform.python_implementation()
returns a string identifying the Python implementation. 
Possible return values are: ‘CPython’, ‘IronPython’, ‘Jython’, ‘PyPy’.

platform.release()
returns the system’s release, e.g. '2.2.0' or 'NT'

platform.system() 
returns the system/OS name, e.g. 'Linux', 'Windows', or 'Java'.

platform.version()  
returns the system’s release version, e.g. '#3 on degas'

platform.uname() 
returns a tuple of strings (system, node, release, version, machine, processor)
identifying the underlying platform.
'''

print(platform.architecture())

print(platform.machine())

print(platform.node())

print(platform.platform())

print(platform.processor())

print(platform.python_build())

print(platform.python_compiler())

print(platform.python_version())

print(platform.python_implementation())

print(platform.release())

print(platform.system())

print(platform.version())

print(platform.uname())