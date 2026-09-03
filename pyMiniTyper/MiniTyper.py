import tkinter as tk
import pyautogui
import time

def submit():
    inputOne = firstTextBox.get()
    inputTwo = secondTextBox.get()

    if not inputOne and not inputTwo:
        print("Please enter text.")
        return

    time.sleep(3)

    if inputOne and not inputTwo:
        pyautogui.write(inputOne)
    elif inputOne and inputTwo:
        pyautogui.write(inputOne)
        pyautogui.press('tab')
        pyautogui.write(inputTwo)

def toggleShowPass():
    if showPass.get():
        secondTextBox.config(show="")
    else:
        secondTextBox.config(show="*")


root = tk.Tk()
root.title("Mini Typer")
root.geometry("400x100")
root.eval('tk::PlaceWindow . center')

firstTextBox = tk.Entry(root, width=60)
firstTextBox.pack(pady=(10, 5))

secondTextBox = tk.Entry(root, width=60, show="*")
secondTextBox.pack(pady=(5, 5))

bottomRow = tk.Frame(root)
bottomRow.pack(pady=(5, 5))

submitBtn = tk.Button(bottomRow, text="Submit", command=submit)
submitBtn.pack(side="left", padx=(0,135))

showPass = tk.BooleanVar
showPassBox = tk.Checkbutton(bottomRow, text="Show Password", variable=showPass, command=toggleShowPass)
showPassBox.pack(side="left")

root.mainloop()