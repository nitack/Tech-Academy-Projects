# Python Ver:   3.7.1
#
# Author:       Ryan DAy
#
# Purpose:      Phonebook demo.  Demonstration app for Tkinter gui module,
#               using Tkinter Parent and Child Relationships.
#
# Tested OS:    This code was written and tested to work with Windows 10



import os
from tkinter import *
import tkinter as tk

#importing other modules from this project
import dirdrill_gui
import dirdrill_func


class ParentWindow (Frame):
    def __init__ (self, master, *args, **kwargs):
        Frame.__init__ (self, master, *args, **kwargs)

        #define master frame configutation
        self.master = master
        self.master.minsize(500,300) #(height, width)
        self.master.maxsize(500,300)
        # this center window method will cener the app on the user's screen
        dirdrill_func.center_window(self,500,300)
        self.master.title("Processing files")
        arg = self.master

        # load in the GUI widgets from a seperate module,
        # keeping your code compartmentalized and clutter free
        dirdrill_gui.load_gui(self)



        
        





if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop
