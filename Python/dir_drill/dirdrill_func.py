



from tkinter import *
from tkinter import filedialog
import tkinter as tk
import sqlite3
import shutil
import os

#importing other modules from this project
import dirdrill_main
import dirdrill_gui


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


#move .txt files to destination folder
def process (self):
    input_folder = self.txt_source.get()
    input_files = os.listdir(input_folder)    
    output_folder = self.txt_dest.get()
    for file in input_files:
        if file.endswith('.txt'):
            shutil.move(os.path.join(input_folder,file), os.path.join(output_folder,file))
    create_db(self)

#Create db
def create_db(self):
    conn = sqlite3.connect('dirdrill.db')
    with conn:
        cur = conn.cursor()
        cur.execute("create table if not exists tbl_files(id integer primary key autoincrement, col_filename text, col_modinfo int);")
        # you must commit() to save changes & clos ethe database connection
        conn.commit()
    conn.close
    getlist(self)


def getlist (self):
    dbinput = self.txt_dest.get()
    conn = sqlite3.connect ('dirdrill.db')   
    for files in os.listdir(dbinput):
        modtime = os.path.getmtime(dbinput)
        with conn:
            cur = conn.cursor()
            cur.execute("INSERT INTO tbl_files(col_filename, col_modinfo) values (?,?)", (files, modtime))
            conn.commit()
    conn.close()
    getinfo(self)

    
def getinfo(self):
    conn = sqlite3.connect ('dirdrill.db')
    with conn:
        cur = conn.cursor()
        cur.execute("SELECT * FROM tbl_files")
        conn.commit()
    print(cur.fetchall())


def source(self):
    sourcename = filedialog.askdirectory()
    if sourcename:
        self.txt_source.insert(0, '{}'.format(sourcename))

def dest(self):
    destname = filedialog.askdirectory()
    if destname:
        self.txt_dest.insert(0, '{}'.format(destname))
            


if __name__ == "__main__":
    pass
