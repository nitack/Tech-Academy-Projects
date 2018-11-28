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
    
from tkinter import *
import tkinter


class ParentWindow (Frame):
    def __init__ ():
        Frame.__init__ ()

 
        resizable(width=False, height=False)
        geometry('{}x{}'.format(525,210))
        title('Browse')

#browse button1
        btn_browse = Button(root, width=12, height=1, text="Browse...", command=func_browse)
        btn_browse.grid(row=1, column=0, padx=(20,0), pady=(50,0))
        

    def func_browse():
        filename = filedialog.askopenfilename()
        pathlabel.config(text=filename)




        
    
if __name__ == "__main__":
    root = Tk()
#    App = ParentWindow(root)
    root.mainloop
