/*
    Program Name:   formTextEditor.cs
    Author:         Irina Nazarova
    Date:           Mar 27, 2021


    Description: This application is a primitive text editor
 
 
 */



using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Text_Editor
{
    public partial class formTextEditor : Form
    {
        // Declarations

        // If the file has been changed isEdited = true
        bool isEdited;
        // If the file exists then hasBeenSaved = true
        bool hasBeenSaved;
        // filePath is a variable that stores a path to the file
        string filePath;
        // This variable indicated whether the star in the title was typed, or not
        bool starTyped;

        public formTextEditor()
        {
            InitializeComponent();
            // Set the form to the default state
            SetDefaults();
        }
       
      
        /// <summary>
        /// This event will copy the chosen text to the clipboard
        /// </summary>
        private void menuEditCopyClick(object sender, EventArgs e)
        {
            // If there is something highlighted in the textbox:
            if (richTextBoxInput.SelectedText != "")
            {
                // Send this text to the clipboard
                Clipboard.SetText(richTextBoxInput.SelectedText);
            }
        }
        

        /// <summary>
        /// This even will take the text from the clipboard and paste it where the cursor is located
        /// </summary>
        private void menuEditPasteClick(object sender, EventArgs e)
        {
            // If there is someting in the Clipboard: 
            if(Clipboard.ContainsText())
            {
                // position variable will hold the value of where the cursor is placed
                int position = richTextBoxInput.SelectionStart;
                // length variable will hold the length of the text in the clipboard 
                int length = Clipboard.GetText().Length;

  
                // Insert the text from the clipboard into the textBox starting from the position of the cursor
                richTextBoxInput.Text = richTextBoxInput.Text.Insert(position, Clipboard.GetText());

                // Place the cursor after the inserted text
                richTextBoxInput.Select(position + length, 0);
                // the text has been altered, therefore isEdited = true
                isEdited = true;
            }

        }


        /// <summary>
        /// If the user pressed Exit menu option, the form will close
        /// </summary>
        private void menuFileExitClick(object sender, EventArgs e)
        {
            // If ConfirmClose() is true: 
            if (ConfirmClose())
            {
                // Close the application
                this.Close();
            }
        }


        /// <summary>
        /// If the user presses New menu option, the text in the textBox will be deleted and all the defaults
        /// will be set
        /// </summary>
        private void menuFileNewClick(object sender, EventArgs e)
        {
            // If ConfirmClose() return a true 
            if (ConfirmClose())
            {
                // Clear the textBox
                richTextBoxInput.Clear();
                // Call a SetDefaults function
                SetDefaults();
            }
            
        }

        /// <summary>
        /// If the user chooses Help -> About ooption, the message box will display the info about the application
        /// </summary>
        private void menuHelpAboutClick(object sender, EventArgs e)
        { 
            // MessageBox displays the name of the Course, Lab number, and the author's name
            MessageBox.Show("\n   NETD-2202   \n" +
                            "   Lab 5   \n" +
                            "   Irina Nazarova   \n");

        }

        /// <summary>
        /// If user cuts the text, it will Copy the highlighted text, and delete it from the textBox
        /// </summary>
        private void menuEditCutClick(object sender, EventArgs e)
        {
            // Perform the same action as the menuEditCopyClick 
            menuEditCopyClick(richTextBoxInput, e);
            // Delete the Selected Text
            richTextBoxInput.SelectedText = "";
        }


        /// <summary>
        /// if the user presses Save, the save dialog window will open if teh file has not been saved before.
        /// If the file has been saved before, the text will be saved in the existing file
        /// </summary>
        private void menuFileSaveClick(object sender, EventArgs e)
        {
            // If the file is Edited and has not been previously Saved:
            if (isEdited && !hasBeenSaved)
            {
                // filePath variable will take the ruturn value of ShowSaveDialog function which saves the file
                filePath = ShowSaveDialog();

                // Set the variable hasBeenSaved to true
                hasBeenSaved = true;
            }
            // If the file has been previously saved and it is edited:
            else if (hasBeenSaved && isEdited)
            {
                // Save a file using SaveFile function
                SaveFile(filePath);
            }

        }


        /// <summary>
        /// ShowSaveDialog function will open the SaveDialog and save the file to the chosen destination
        /// </summary>
        private string ShowSaveDialog()
        {
            // create SaveFileDialog object
            SaveFileDialog windowSave = new SaveFileDialog();
            // Set possible extensions for the file (txt)
            windowSave.Filter = ("Text Files| *.txt");
            // Set the title for SaveFileDialog window
            windowSave.Title = "Save file";
            // Set default name for the text file
            windowSave.FileName = "Lab_5";

            // If the button Save is pressed in the Save window:
            if (windowSave.ShowDialog() == DialogResult.OK)
            {
                // Set filePath variable for the path of the file
                filePath = windowSave.FileName;
                // Call the function SaveFile
                SaveFile(filePath);
                // Return a value of filePath
                return filePath;
            }
            // If the files was not saved, return an empty string
            else
            {
                return "";
            }

        }

        /// <summary>
        /// Save file function will Save a file in the filePath location
        /// </summary>
        private void SaveFile(string filePath)
        {
            // Create FileStream object fileToAccess
            FileStream fileToAccess = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            // Create StreamWrite object writer
            StreamWriter writer = new StreamWriter(fileToAccess);

            // Write a text from a file to the file in the chosen location
             writer.Write(richTextBoxInput.Text);

                
            // Close the writer
             writer.Close();
            
            // Set the varibale hasBeenSaved to true
            hasBeenSaved = true;
            // set the variable starTyped to false
            starTyped = false;
            // Change the title of the text editor to "Text Editor " plus the path to the file
            this.Text = "Text Editor " + filePath;
            // Set isEdite varibale to false
            isEdited = false;
        }


        /// <summary>
        /// If the text in the textBox is altered, the asterisk will appear in the title
        /// </summary>
        private void textBoxEdited(object sender, EventArgs e)
        {
            // Set variable isEdited to true
            isEdited = true;
            // If the star is not yet typed:
            if (!starTyped)
            {
                // Put asterisk on the window title
                this.Text += "*";
            }
            // Set the variable startTyped to true
            starTyped = true;
        }

        /// <summary>
        /// If the Tab Key is pressed, the four spaces will be inserted
        /// (Sometimes it does not work for some reasons - it inserts only 1 or 2 spaces, but
        /// for most of the cases it works just fine)
        /// </summary>
        private void richTextBoxInputKeyPress(object sender, KeyPressEventArgs e)
        {
            // If the Tab key is Pressed:
            if (e.KeyChar == (char)Keys.Tab)
            {
                // Insert 4 spaces
                richTextBoxInput.Text.Insert(richTextBoxInput.SelectionStart, "\t");

            }
        }

        /// <summary>
        /// If the Open menu option is clicked, the openFileDialog is opened, and the user can choose th etxt file to open
        /// </summary>
        private void menuFileOpenClick(object sender, EventArgs e)
        {
            // create OpenFileDialog object
            OpenFileDialog windowOpen = new OpenFileDialog();
            // Set possible extensions for the file (txt)
            windowOpen.Filter = ("Text Files| *.txt");
            // Set the title for OpenFileDialog window
            windowOpen.Title = "Open file";


            // If the button Open is pressed, the file is opened
            if (windowOpen.ShowDialog() == DialogResult.OK)
            {
                // declare a variable for the text of the file
                string content;
                // Set filePath variable for the path of the file
                filePath = windowOpen.FileName;

                // Create FileStream object with Open Mode and Read Access
                FileStream fileToOpen = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // Create a StreamReader object
                StreamReader reader = new StreamReader(fileToOpen);

                // put the text of the file into the content variable
                content = reader.ReadToEnd();
                // display the content in the textbox
                richTextBoxInput.Text = content;

                // Change the title of the window
                this.Text = "Text Editor " + filePath;
                // Set hasBeenSaved variable to true
                hasBeenSaved = true;
                // Set starTyped variable to fasle
                starTyped = false;
                // close the reader
                reader.Close();
            }


        }



        /// <summary>
        /// If the user chooses Save As option, the Save dialog will open and 
        /// the file will be saved
        /// </summary>
        private void menuFileSaveAsClick(object sender, EventArgs e)
        {
            // Call ShowSaveDialog() to save a file in a chosen destination
            filePath = ShowSaveDialog();
            // Set hasBeenSaved to true
            hasBeenSaved = true;
            // Set starTyoed variable to false
            starTyped = false;
        }


        /// <summary>
        /// SetDefaults function will set the variables to the default values
        /// </summary>
        private void SetDefaults()
        {
            // isEdited is false
            isEdited = false;
            // hasBeenSaved is false
            hasBeenSaved = false;
            // filePath is empty
            filePath = "";
            // starTyped is false
            starTyped = false;
            // The title is: Text Editor Select File To Open
            this.Text = "Text Editor Select File To Open";

        }

        
        /// <summary>
        /// If the form closes by clicking on the cross in the title bar
        /// the application will ask if the user wants to discard changes
        /// if there were any
        /// </summary>
        private void formTextEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            // If ConfirmClose() function returns true:
            if (!ConfirmClose())
            {
                // Cancel the operation of closing
                e.Cancel = true;
            }
        }


        /// <summary>
        /// ConfirmClose function will check if there were any alterations in the text
        /// and return true or false
        /// </summary>
        private bool ConfirmClose()
        {
            // If the text was edited:
            if (isEdited)
            {
                // create an object of DialogResult class
                DialogResult answer;
                // answer will take the option which user chose (Yes/No)
                answer = MessageBox.Show("Do you wnat to discard changes?", "Are you Sure?", MessageBoxButtons.YesNo);
                // If the answer was Yes:
                if (answer == DialogResult.Yes)
                {
                    // The funtion will return true
                    return true;
                }
                // If the answer was No: 
                else if(answer == DialogResult.No)
                {
                    // The function will return false
                    return false;
                }
            }
            return true;
 
        }
    }
}
