using WordsSearch;
namespace WordsSearch
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.lst_ListOfWords = new System.Windows.Forms.ListBox();
            this.txt_AWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Width = new System.Windows.Forms.Label();
            this.lb_Height = new System.Windows.Forms.Label();
            this.dl_Open = new System.Windows.Forms.OpenFileDialog();
            this.dl_Save = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Table = new System.Windows.Forms.GroupBox();
            this.dl_Export = new System.Windows.Forms.SaveFileDialog();
            this.mnu_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Project_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Project_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Project_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Project_Saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Project_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Table = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Table_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Table_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Table_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Table_ShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Table_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LOW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LOW_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LOW_AddDict = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_LOW_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wordsSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_WordsSearch_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_FT = new System.Windows.Forms.ToolStripMenuItem();
            this.se_Skin = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.dl_Import = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_WordsSearch_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_NO_Width = new WordsSearch.NumberBox();
            this.txt_NO_Height = new WordsSearch.NumberBox();
            this.groupBox2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_ListOfWords
            // 
            resources.ApplyResources(this.lst_ListOfWords, "lst_ListOfWords");
            this.lst_ListOfWords.FormattingEnabled = true;
            this.lst_ListOfWords.Name = "lst_ListOfWords";
            this.lst_ListOfWords.SelectedIndexChanged += new System.EventHandler(this.lst_ListOfWords_SelectedIndexChanged);
            // 
            // txt_AWord
            // 
            resources.ApplyResources(this.txt_AWord, "txt_AWord");
            this.txt_AWord.Name = "txt_AWord";
            this.txt_AWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddWord_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txt_NO_Width);
            this.groupBox2.Controls.Add(this.txt_NO_Height);
            this.groupBox2.Controls.Add(this.lb_Width);
            this.groupBox2.Controls.Add(this.lb_Height);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lb_Width
            // 
            resources.ApplyResources(this.lb_Width, "lb_Width");
            this.lb_Width.Name = "lb_Width";
            // 
            // lb_Height
            // 
            resources.ApplyResources(this.lb_Height, "lb_Height");
            this.lb_Height.Name = "lb_Height";
            // 
            // dl_Open
            // 
            this.dl_Open.FileName = "openFileDialog1";
            this.dl_Open.FileOk += new System.ComponentModel.CancelEventHandler(this.dl_Open_FileOk);
            // 
            // dl_Save
            // 
            this.dl_Save.FileOk += new System.ComponentModel.CancelEventHandler(this.dl_Save_FileOk);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lst_ListOfWords);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_AWord);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gb_Table);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gb_Table
            // 
            resources.ApplyResources(this.gb_Table, "gb_Table");
            this.gb_Table.Name = "gb_Table";
            this.gb_Table.TabStop = false;
            // 
            // dl_Export
            // 
            this.dl_Export.FileOk += new System.ComponentModel.CancelEventHandler(this.dl_Export_FileOk);
            // 
            // mnu_Project
            // 
            this.mnu_Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Project_New,
            this.toolStripSeparator2,
            this.mnu_Project_Open,
            this.mnu_Project_Save,
            this.mnu_Project_Saveas,
            this.toolStripSeparator1,
            this.mnu_Project_Exit});
            this.mnu_Project.Name = "mnu_Project";
            resources.ApplyResources(this.mnu_Project, "mnu_Project");
            this.mnu_Project.DropDownOpening += new System.EventHandler(this.mnu_Project_DropDownOpening);
            // 
            // mnu_Project_New
            // 
            this.mnu_Project_New.Name = "mnu_Project_New";
            resources.ApplyResources(this.mnu_Project_New, "mnu_Project_New");
            this.mnu_Project_New.Click += new System.EventHandler(this.mnu_Project_New_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // mnu_Project_Open
            // 
            this.mnu_Project_Open.Name = "mnu_Project_Open";
            resources.ApplyResources(this.mnu_Project_Open, "mnu_Project_Open");
            this.mnu_Project_Open.Click += new System.EventHandler(this.mnu_Project_Open_Click);
            // 
            // mnu_Project_Save
            // 
            this.mnu_Project_Save.Name = "mnu_Project_Save";
            resources.ApplyResources(this.mnu_Project_Save, "mnu_Project_Save");
            this.mnu_Project_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // mnu_Project_Saveas
            // 
            this.mnu_Project_Saveas.Name = "mnu_Project_Saveas";
            resources.ApplyResources(this.mnu_Project_Saveas, "mnu_Project_Saveas");
            this.mnu_Project_Saveas.Click += new System.EventHandler(this.Saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnu_Project_Exit
            // 
            this.mnu_Project_Exit.Name = "mnu_Project_Exit";
            resources.ApplyResources(this.mnu_Project_Exit, "mnu_Project_Exit");
            this.mnu_Project_Exit.Click += new System.EventHandler(this.mnu_Project_Exit_Click);
            // 
            // mnu_Table
            // 
            this.mnu_Table.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Table_Create,
            this.toolStripSeparator5,
            this.mnu_Table_Copy,
            this.mnu_Table_Export,
            this.toolStripSeparator4,
            this.mnu_Table_ShowAll,
            this.toolStripSeparator6,
            this.mnu_Table_Option});
            this.mnu_Table.Name = "mnu_Table";
            resources.ApplyResources(this.mnu_Table, "mnu_Table");
            this.mnu_Table.DropDownOpening += new System.EventHandler(this.mnu_Table_DropDownOpening);
            // 
            // mnu_Table_Create
            // 
            this.mnu_Table_Create.Name = "mnu_Table_Create";
            resources.ApplyResources(this.mnu_Table_Create, "mnu_Table_Create");
            this.mnu_Table_Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // mnu_Table_Copy
            // 
            this.mnu_Table_Copy.Name = "mnu_Table_Copy";
            resources.ApplyResources(this.mnu_Table_Copy, "mnu_Table_Copy");
            this.mnu_Table_Copy.Click += new System.EventHandler(this.CopyToClipBoard_Click);
            // 
            // mnu_Table_Export
            // 
            this.mnu_Table_Export.Name = "mnu_Table_Export";
            resources.ApplyResources(this.mnu_Table_Export, "mnu_Table_Export");
            this.mnu_Table_Export.Click += new System.EventHandler(this.ExportToTextFile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // mnu_Table_ShowAll
            // 
            this.mnu_Table_ShowAll.Name = "mnu_Table_ShowAll";
            resources.ApplyResources(this.mnu_Table_ShowAll, "mnu_Table_ShowAll");
            this.mnu_Table_ShowAll.Click += new System.EventHandler(this.mnu_Table_ShowAll_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // mnu_Table_Option
            // 
            this.mnu_Table_Option.Name = "mnu_Table_Option";
            resources.ApplyResources(this.mnu_Table_Option, "mnu_Table_Option");
            this.mnu_Table_Option.Click += new System.EventHandler(this.mnu_Table_Option_Click);
            // 
            // mnu_LOW
            // 
            this.mnu_LOW.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_LOW_Add,
            this.mnu_LOW_AddDict,
            this.toolStripSeparator3,
            this.mnu_LOW_Remove});
            this.mnu_LOW.Name = "mnu_LOW";
            resources.ApplyResources(this.mnu_LOW, "mnu_LOW");
            this.mnu_LOW.DropDownOpening += new System.EventHandler(this.mnu_LOW_DropDownOpening);
            // 
            // mnu_LOW_Add
            // 
            this.mnu_LOW_Add.Name = "mnu_LOW_Add";
            resources.ApplyResources(this.mnu_LOW_Add, "mnu_LOW_Add");
            this.mnu_LOW_Add.Click += new System.EventHandler(this.AddWork_Click);
            // 
            // mnu_LOW_AddDict
            // 
            this.mnu_LOW_AddDict.Name = "mnu_LOW_AddDict";
            resources.ApplyResources(this.mnu_LOW_AddDict, "mnu_LOW_AddDict");
            this.mnu_LOW_AddDict.Click += new System.EventHandler(this.mnu_LOW_AddDict_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // mnu_LOW_Remove
            // 
            this.mnu_LOW_Remove.Name = "mnu_LOW_Remove";
            resources.ApplyResources(this.mnu_LOW_Remove, "mnu_LOW_Remove");
            this.mnu_LOW_Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Project,
            this.mnu_Table,
            this.mnu_LOW,
            this.wordsSearchToolStripMenuItem,
            this.mnu_FT});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // wordsSearchToolStripMenuItem
            // 
            this.wordsSearchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_WordsSearch_Theme,
            this.toolStripSeparator7,
            this.mnu_WordsSearch_Help});
            this.wordsSearchToolStripMenuItem.Name = "wordsSearchToolStripMenuItem";
            resources.ApplyResources(this.wordsSearchToolStripMenuItem, "wordsSearchToolStripMenuItem");
            // 
            // mnu_WordsSearch_Theme
            // 
            this.mnu_WordsSearch_Theme.Name = "mnu_WordsSearch_Theme";
            resources.ApplyResources(this.mnu_WordsSearch_Theme, "mnu_WordsSearch_Theme");
            this.mnu_WordsSearch_Theme.Click += new System.EventHandler(this.mnu_WordsSearch_Theme_Click);
            // 
            // mnu_FT
            // 
            this.mnu_FT.Name = "mnu_FT";
            resources.ApplyResources(this.mnu_FT, "mnu_FT");
            this.mnu_FT.Click += new System.EventHandler(this.mnu_FT_Click);
            // 
            // se_Skin
            // 
            this.se_Skin.Active = false;
            this.se_Skin.SerialNumber = "";
            this.se_Skin.SkinFile = null;
            // 
            // dl_Import
            // 
            resources.ApplyResources(this.dl_Import, "dl_Import");
            this.dl_Import.FileOk += new System.ComponentModel.CancelEventHandler(this.dl_Import_FileOk);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // mnu_WordsSearch_Help
            // 
            this.mnu_WordsSearch_Help.Name = "mnu_WordsSearch_Help";
            resources.ApplyResources(this.mnu_WordsSearch_Help, "mnu_WordsSearch_Help");
            this.mnu_WordsSearch_Help.Click += new System.EventHandler(this.mnu_WordsSearch_Help_Click);
            // 
            // txt_NO_Width
            // 
            resources.ApplyResources(this.txt_NO_Width, "txt_NO_Width");
            this.txt_NO_Width.Name = "txt_NO_Width";
            // 
            // txt_NO_Height
            // 
            resources.ApplyResources(this.txt_NO_Height, "txt_NO_Height");
            this.txt_NO_Height.Name = "txt_NO_Height";
            // 
            // frm_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Load += new System.EventHandler(this.Load_New);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_ListOfWords;
        private System.Windows.Forms.TextBox txt_AWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Width;
        private System.Windows.Forms.Label lb_Height;
        private System.Windows.Forms.OpenFileDialog dl_Open;
        private System.Windows.Forms.SaveFileDialog dl_Save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gb_Table;
        private NumberBox txt_NO_Width;
        private NumberBox txt_NO_Height;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog dl_Export;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project_Open;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project_Saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table_Create;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table_Copy;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table_Export;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table_ShowAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_LOW;
        private System.Windows.Forms.ToolStripMenuItem mnu_LOW_Add;
        private System.Windows.Forms.ToolStripMenuItem mnu_LOW_Remove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_FT;
        private System.Windows.Forms.ToolStripMenuItem wordsSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_WordsSearch_Theme;
        private Sunisoft.IrisSkin.SkinEngine se_Skin;
        private System.Windows.Forms.ToolStripMenuItem mnu_LOW_AddDict;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog dl_Import;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnu_Table_Option;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnu_WordsSearch_Help;
    }
}

