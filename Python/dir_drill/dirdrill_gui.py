

import os 
import tkinter
from tkinter import *


#importing other modules from this project
import dirdrill_main
import dirdrill_func


def load_gui(self):
    #text boxes
    self.txt_source = Entry(self.master,width=50, text='')
    self.txt_source.grid(row=1,column=2,rowspan=1, padx=(20,0),pady=(50,0))
    self.txt_dest = Entry(self.master,width=50, text='')
    self.txt_dest.grid(row=2,column=2,rowspan=1, padx=(20,0),pady=(20,0))
            


    #Source directory button 
    self.btn_source = Button(self.master, width=12, height=1, text="Source", command=lambda: dirdrill_func.source(self))
    self.btn_source.grid(row=1, column=0, padx=(20,0), pady=(50,0))
    #Destination directory button
    self.btn_dest = Button(self.master, width=12, height=1, text="Destination", command=lambda: dirdrill_func.dest(self))
    self.btn_dest.grid(row=2, column=0, padx=(20,0), pady=(20,0))
    #Process .txt files button
    self.btn_process = Button(self.master, width=12, height=2, text="Check for files...", command=lambda: dirdrill_func.process(self))
    self.btn_process.grid(row=3, column=0, padx=(20,0), pady=(20,0))


        
    
if __name__ == "__main__":
    pass
