# Python Ver:   3.7.1
#
# Author:       Ryan DAy
#
# Purpose:      Phonebook demo.  Demonstration app for Tkinter gui module,
#               using Tkinter Parent and Child Relationships.
#
# Tested OS:    This code was written and tested to work with Windows 10



import os
import sqlite3
from tkinter import *
import tkinter as tk
from tkinter import filedialog

#importing other modules from this project



class ParentWindow (Frame):
    def __init__ (self, master, *args, **kwargs):
        Frame.__init__ (self, master, *args, **kwargs)

    #define master frame configutation

    #text boxes
        txt_source = Entry(width=50, text='')
        txt_source.grid(row=1,column=2,rowspan=1, padx=(20,0),pady=(50,0))
        txt_dest = Entry(width=50, text='')
        txt_dest.grid(row=2,column=2,rowspan=1, padx=(20,0),pady=(20,0))
                    


    #Source directory button 
        btn_source = Button(width=12, height=1, text="Source", command=source)
        btn_source.grid(row=1, column=0, padx=(20,0), pady=(50,0))
    #Destination directory button
        btn_dest = Button(width=12, height=1, text="Destination", command=dest)
        btn_dest.grid(row=2, column=0, padx=(20,0), pady=(20,0))
    #Process .txt files button
        btn_process = Button(width=12, height=2, text="Check for files...")
        btn_process.grid(row=3, column=0, padx=(20,0), pady=(20,0))




'''
Functions
'''
def center_window(self, w, h): #pass in the tkinter frame (master) reference and the w and h
    #get user's screen width and height
    screen_width = self.master.winfo_screenwidth()
    screen_height = self.master.winfo_screenheight()
    #calculate x and y coordinates to print the app centered on the user's screen
    x = int((screen_width/2) - (w/2))
    y = int((screen_height/2) - (h/2))
    centerGeo = self.master.geometry('{}x{}+{}+{}'.format(w, h, x, y))
    return centerGeo




#======================================================

def create_db(self):
    conn = sqlite3.connect('dirdrill.db')
    with conn:
        cur = conn.cusor()
        cur.execute("create table if not exists tbl_files( \
            id integer primary key autoincrement, \
            col_filename text, \
            col_modinfo text, \
            );")
        # you must commit() to save changes & clos ethe database connection
        conn.commit()
    conn.close
    first_run(self)

def first_run(self):
    data = ('first', '')
    conn = sqlite3.connect ('dirdrill.db')
    with conn:
        cur = conn.cursor()
        cur.count = count_records(cur)
        if count < 1:
            cur.execute("""Insert into tbl_files (col_filename,col_modinfo) values (?,?)""", (data))
            conn.commit()
    conn.close

def count_records (cur):
    count = ""
    cur.execute("""Select count(*) from tbl_files""")
    count = cur.fetchone()[0]
    return cur,count

def source():
    sourcename = filedialog.askdirectory()
    if sourcename:
        self.txt_source.insert(0, '{}'.format(sourcename))

def dest():
    destname = filedialog.askdirectory()
    if destname:
        self.txt_dest.insert(0, '{}'.format(destname))




        
        





if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop
