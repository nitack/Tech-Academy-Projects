'''
Drill Description:
For this drill, you will need to write a script that creates a GUI with
a button widget and a text widget. Your script will also include a function
that when it is called will invoke a dialog modal which will allow users
with the ability to select a folder directory from their system. Finally,
your script will show the user’s selected directory path into the text field.

Requirements:
Your script will need to use Python 3 and the Tkinter module.

Your script will need to use the askdirectory() method from the Tkinter module.

Your script will need have a function linked to the button widget so that
once the button has been clicked will take the user’s selected file path
retained by the askdirectory() method and print it within your GUI’s text widget.
'''


import tkinter
from tkinter import *
from tkinter import filedialog



class ParentWindow (Frame):
    def __init__ (self, master):
        Frame.__init__ (self)

        self.master = master
        self.master.resizable(width=False, height=False)
        self.master.geometry('{}x{}'.format(400,200))
        self.master.title('Browse Files')


        self.btnSubmit = Button(self.master, text="Browse", width=10, height=2, command=self.func_browse)
        self.btnSubmit.pack()

        self.path = Entry(self.master,text='')
        self.path.pack()
 
        
    def func_browse(self):
        dirname = filedialog.askdirectory()
        if dirname:
            self.path.insert(0, '{}'.format(dirname))
      




if __name__ == "__main__":
    root = Tk()
    App = ParentWindow(root)
    root.mainloop
