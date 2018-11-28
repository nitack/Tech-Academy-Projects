
import tkinter
from tkinter import *


class ParentWindow (Frame):
    def __init__ (self, master):
        Frame.__init__ (self)

        self.master = master
        self.master.resizable(width=False, height=False)
        self.master.geometry('{}x{}'.format(525,210))
        self.master.title('Check files')


#text boxes
        self.txt_browse1 = Entry(self.master,width=60, text='')
        self.txt_browse1.grid(row=1,column=2,rowspan=1, padx=(20,0),pady=(50,0))
        self.txt_browse2 = Entry(self.master,width=60, text='')
        self.txt_browse2.grid(row=2,column=2,rowspan=1, padx=(20,0),pady=(20,0))
        


#browse button1
        self.btn_browse1 = Button(self.master, width=12, height=1, text="Browse...")
        self.btn_browse1.grid(row=1, column=0, padx=(20,0), pady=(50,0))
#browse button2
        self.btn_update = Button(self.master, width=12, height=1, text="Browse...")
        self.btn_update.grid(row=2, column=0, padx=(20,0), pady=(20,0))
#Check for files button
        self.btn_delete = Button(self.master, width=12, height=2, text="Check for files...")
        self.btn_delete.grid(row=3, column=0, padx=(20,0), pady=(20,0))
#close button
        self.btn_close = Button(self.master, width=12, height=2, text="Close Program")
        self.btn_close.grid(row=3, column=2, padx=(0,0), pady=(20,0), sticky=E)

        
    
if __name__ == "__main__":
    root = Tk()
    App = ParentWindow(root)
    root.mainloop
