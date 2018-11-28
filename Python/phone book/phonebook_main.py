# Python Ver:   3.7.1
#
# Author:       Ryan DAy
#
# Purpose:      Phonebook demo.  Demonstration app for Tkinter gui module,
#               using Tkinter Parent and Child Relationships.
#
# Tested OS:    This code was written and tested to work with Windows 10



from tkinter import *
import tkinter as tk

#importing other modules from this project
import phonebook_gui
import phonebook_func


class ParentWindow (Frame):
    def __init__ (self, master, *args, **kwargs):
        Frame.__init__ (self, master, *args, **kwargs)

        #define master frame configutation
        self.master = master
        self.master.minsize(500,300) #(height, width)
        self.master.maxsize(500,300)
        # this center window method will cener the app on the user's screen
        phonebook_func.center_window(self,500,300)
        self.master.title("The Tkinter Phonebook Demo")
        self.master.config(bg='#f0f0f0')
        # this protocol method is a tkinter built-in method to catch
        # if the user clicks the upper corner, "X" on Windows OS
        self.master.protocol("WM_DELETE_WINDOW", lambda: phonebook_func.ask_quit(self))
        arg = self.master

        # load in the GUI widgets from a seperate module,
        # keeping your code compartmentalized and clutter free
        phonebook_gui.load_gui(self)



        
        





if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop
