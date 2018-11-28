'''
Your script will need to use Python 3 and the sqlite3 module.

Your database will require 2 fields, an auto-increment primary
integer field and a field with the data type of string.

Your script will need to read from the supplied list of file
names at the bottom of this page and determine only the files
from the list which ends with a “.txt” file extension.

Next, your script should add those file names from the list
ending with “.txt” file extension within your database.

Finally, your script should legibly print the qualifying text files to the console.
'''


import sqlite3

## creates DB and tables if they do not already exist
conn = sqlite3.connect('test.db')

with conn:
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_files( \
        ID INTEGER PRIMARY KEY AUTOINCREMENT, \
        col_files TEXT \
        )")
    conn.commit()
conn.close


##populating db
conn = sqlite3.connect('test.db')

##fileList is the supplied variable and list that needs to be parsed for .txt files
fileList = ['information.docx','Hello.txt','myImage.png', \
            'myMovie.mpg','World.txt','data.pdf','myPhoto.jpg']

for tFiles in fileList.endswith(".txt"):
    with conn:
        cur = conn.cursor()
        cur.execute("INSERT INTO tbl_files(col_files) values (?)", tFiles)
        conn.commit()
    conn.close()


conn = sqlite3.connect('test.db')

with conn:
    cur = conn.cursor()
    cur.execute("SELECT col_files from tbl_files")
    varBob = cur.fetchall()
    print (varBob)
con.close()

