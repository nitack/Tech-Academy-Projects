'''
Your script will need to use Python 3 and the OS module.

Your script will need to use the listdir() method from
the OS module to iterate through all files within a specific directory.

Your script will need to use the path.join() method from
the OS module to concatenate the file name to its file path, forming an absolute path.

Your script will need to use the getmtime() method from
the OS module to find the latest date that each text file has been created or modified.

Your script will need to print each file ending with a
“.txt” file extension and its corresponding mtime to the console.
'''

import os


fName = '*.txt'
path = 'C:\\Users\\Ryan\\Documents\\GitHub\\Tech-Academy-Projects\\Python\\test_files'

for file in os.listdir(path):
    fbatch = os.path.join(path, file)
    if fbatch.endswith(".txt"):
      print(fbatch)
      print (os.path.getmtime(fbatch))




