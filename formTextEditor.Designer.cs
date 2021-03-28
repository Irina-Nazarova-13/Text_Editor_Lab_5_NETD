
namespace Text_Editor
{
    partial class formTextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTextEditor));
            this.menuStripEditor = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.toolTipForTextEditor = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripEditor
            // 
            this.menuStripEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(249)))), ((int)(((byte)(155)))));
            this.menuStripEditor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menuStripEditor.Location = new System.Drawing.Point(0, 0);
            this.menuStripEditor.Name = "menuStripEditor";
            this.menuStripEditor.ShowItemToolTips = true;
            this.menuStripEditor.Size = new System.Drawing.Size(578, 31);
            this.menuStripEditor.TabIndex = 0;
            this.menuStripEditor.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(50, 27);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "File Manipulation";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(245, 28);
            this.menuFileNew.Text = "&New       ";
            this.menuFileNew.ToolTipText = "Create a new file";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNewClick);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(245, 28);
            this.menuFileOpen.Text = "&Open     ";
            this.menuFileOpen.ToolTipText = "Open an existing file";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpenClick);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(245, 28);
            this.menuFileSave.Text = "&Save      ";
            this.menuFileSave.ToolTipText = "Save this File";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(245, 28);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.ToolTipText = "Save this file wherever you want";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAsClick);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(245, 28);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Close the application";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExitClick);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopy,
            this.menuEditCut,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(53, 27);
            this.menuEdit.Text = "&Edit";
            this.menuEdit.ToolTipText = "Text Manipulation";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(205, 28);
            this.menuEditCopy.Text = "&Copy      ";
            this.menuEditCopy.ToolTipText = "Copy selected text";
            this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopyClick);
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(205, 28);
            this.menuEditCut.Text = "Cu&t        ";
            this.menuEditCut.ToolTipText = "Cut selected text";
            this.menuEditCut.Click += new System.EventHandler(this.menuEditCutClick);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(205, 28);
            this.menuEditPaste.Text = "&Paste     ";
            this.menuEditPaste.ToolTipText = "Paste text into the file";
            this.menuEditPaste.Click += new System.EventHandler(this.menuEditPasteClick);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(56, 27);
            this.menuHelp.Text = "&Help";
            this.menuHelp.ToolTipText = "HELP";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(125, 28);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.ToolTipText = "Ask for help?";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAboutClick);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(197)))));
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 31);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxInput.Size = new System.Drawing.Size(578, 499);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.TabStop = false;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.textBoxEdited);
            this.richTextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxInputKeyPress);
            // 
            // formTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(249)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(578, 530);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.menuStripEditor);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripEditor;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor Select A File To Open";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formTextEditorFormClosing);
            this.menuStripEditor.ResumeLayout(false);
            this.menuStripEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripEditor;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.ToolTip toolTipForTextEditor;
    }
}

