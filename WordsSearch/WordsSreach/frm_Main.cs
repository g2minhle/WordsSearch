using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace WordsSearch
{
    public partial class frm_Main : Form
    {
        Project project;
        string inits;
        bool usertheme;
        string themepath;
        public frm_Main(string path)
        {
            Init();
            inits = path;
        }
        void Init()
        {
            InitializeComponent();
            FileInfo ftmp=new FileInfo(Application.ExecutablePath ) ;
            StreamReader f = new StreamReader(ftmp.DirectoryName+ "//setting");
            usertheme = bool.Parse(f.ReadLine());
            if (usertheme) themepath = f.ReadLine();
            if (File.Exists(themepath) == false)
            {
                usertheme = false;
                se_Skin.Active = false;
            }
            else
            {
                se_Skin.Active = true;
                se_Skin.SkinFile = themepath;
            }
            f.Close();

            txt_NO_Width.PressEnter += new NumberBox.EnterHandel(txt_NO_Width_PressEnter);
            txt_NO_Height.PressEnter += new NumberBox.EnterHandel(txt_NO_Height_PressEnter);
            inits = "";
        }
        public frm_Main()
        {
            Init();
        }
        #region Change project save staus
        void ItChanged()
        {
            try
            {
                this.Text = project.Path.Name + " *";
            }
            catch { this.Text = "Unknow table *"; }
            project.Changed = true;
        }
        void DidnotChange()
        {
            this.Text = project.Path.Name;
            project.Changed = false;
        }
        void SetHeighWidth()
        {
            txt_NO_Height.Text = project.Height.ToString();
            txt_NO_Width.Text = project.Width.ToString();
            lb_Height.Text = "Height: " + project.Height.ToString();
            lb_Width.Text = "Width: " + project.Height.ToString();
        }
        #endregion

        #region Save
        private void Saveas_Click(object sender, EventArgs e)
        {
            Saveas();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        void Save(string filename)
        {
            project.Save(filename);
            DidnotChange();
        }
        void Save()
        {
            if (project.Path != null)
                if (project.Path.Exists == true)
                    Save(project.Path.FullName);
                else
                    Saveas();
            else
                Saveas();

        }

        void Saveas()
        {
            dl_Save.FileName = "";
            dl_Save.Filter = "TableFile|*.tbl";
            dl_Save.Title = "Open table";
            dl_Save.FilterIndex = 0;
            dl_Save.ShowDialog();
        }
        private void dl_Save_FileOk(object sender, CancelEventArgs e)
        {
            Save(dl_Save.FileName);
        }
        #endregion

        #region Open
        private void dl_Open_FileOk(object sender, CancelEventArgs e)
        {
            project = new Project(dl_Open.FileName, ref lst_ListOfWords);
            project.DoneCreate += new Project.DoneCreateHandel(mainproject_Done);
            SetHeighWidth();
            DidnotChange();
            if (project.Created) mainproject_Done();
        }
        private void mnu_Project_Open_Click(object sender, EventArgs e)
        {
            if (CloseProject() != 3)
            {
                #region Show Open dialog
                dl_Open.FileName = "";
                dl_Open.Filter = "TableFile|*.tbl";
                dl_Open.Title = "Open table";
                dl_Open.FilterIndex = 0;
                dl_Open.ShowDialog();
                #endregion
            }
        }
        #endregion

        #region Option
        private void Option_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Add
        private void AddWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) AddWork_Click(null, null);
        }
        void AddNewWord(string text)
        {
            if (project.AddAword(text) == true)
            {
                lst_ListOfWords.Items.Add(text);
                txt_AWord.Text = "";
                ItChanged();
                gb_Table.Controls.Clear();
            }
        }
        private void AddWork_Click(object sender, EventArgs e)
        {
            AddNewWord(txt_AWord.Text);
        }
        #endregion

        #region Remove
        private void Remove_Click(object sender, EventArgs e)
        {
            if (lst_ListOfWords.SelectedItem != null)
            {
                project.Remove(lst_ListOfWords.SelectedIndex);
                lst_ListOfWords.Items.RemoveAt(lst_ListOfWords.SelectedIndex);
                lst_ListOfWords.Focus();
                gb_Table.Controls.Clear();
                ItChanged();
            }
        }
        #endregion


        #region New
        /// <summary>
        /// Make new table
        /// </summary>  
        private void Load_New(object sender, EventArgs e)
        {
            EmptyAllTheBox();
            project = new Project();
            project.DoneCreate += new Project.DoneCreateHandel(mainproject_Done);
            this.Text = "Unknow table";
            this.Name = "Unknow table";
            this.txt_NO_Height.digit = 2;
            this.txt_NO_Width.digit = 2;
            SetHeighWidth();
            txt_AWord.Focus();
            if (inits != "")
            {
                project = new Project(inits, ref lst_ListOfWords);
                project.DoneCreate += new Project.DoneCreateHandel(mainproject_Done);
                SetHeighWidth();
                DidnotChange();
                if (project.Created) mainproject_Done();
            }
        }
        private void mnu_Project_New_Click(object sender, EventArgs e)
        {
            if (CloseProject() != 3) Load_New(null, null);
        }
        #endregion

        #region Exit
        int CloseProject()
        {
            if (project.Changed == true)
            {
                DialogResult dr = MessageBox.Show("Do you want to save the project ?", this.Name, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr.ToString() == "Cancel")
                    return 3;
                if (dr.ToString() == "Yes")
                {
                    Save();
                    return 1;
                }
                return 2;
            }
            return 0;
        }
        private void mnu_Project_Exit_Click(object sender, EventArgs e)
        {
            if (CloseProject() != 3)
            {
                exited = true;
                this.Close();
            }
        }
        bool exited;
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exited)
            {
                FileInfo ftmp = new FileInfo(Application.ExecutablePath);
                StreamWriter f = new StreamWriter(ftmp.DirectoryName + "//setting");
                f.WriteLine(usertheme.ToString());
                f.WriteLine(themepath);
                f.Close();
                return;
            }
            if (CloseProject() == 3) e.Cancel = true;
        }
        #endregion

        #region Create table
        void mainproject_Done()
        {
            SuspendLayout();
            WordsSearch.Table tb;
            int tmp = 0;
            if (gb_Table.Controls.Count != 0)
            {
                tb = (WordsSearch.Table)gb_Table.Controls[0];
                tmp = tb.LetterSize;
            }
            gb_Table.Controls.Clear();
            tb = new WordsSearch.Table();
            if (tmp != 0) tb.LetterSize = tmp;
            else tb.LetterSize = 50;
            tb.CreateTable(project.TheTable, project.WordsList);
            tb.Location = new Point(0, 0);
            tb.Size = new Size(gb_Table.Width, gb_Table.Height);
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            gb_Table.Controls.Add(tb);
            ResumeLayout();
        }
        private void Create_Click(object sender, EventArgs e)
        {
            project.CreateTable();
            ItChanged();
        }
        #endregion

        #region Other
        void EmptyAllTheBox()
        {
            txt_AWord.Text = "";
            gb_Table.Controls.Clear();
            lst_ListOfWords.Items.Clear();
        }
        private void lst_ListOfWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lst_ListOfWords.SelectedItem != null) && project.Created)
            {
                int index = lst_ListOfWords.SelectedIndex;
                WordsSearch.Table tb = (WordsSearch.Table)gb_Table.Controls[0];
                tb.Appear(index);
            }
        }
        #endregion

        #region Set height and width
        byte SetValue(int value)
        {
            if (value > 3)
            {
                ItChanged();
                return (byte)value;
            }
            MessageBox.Show("Only from 4 to 100 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 3;
        }
        private void cmd_SetHeight_Click(object sender, EventArgs e)
        {
            txt_NO_Height_PressEnter(txt_NO_Height.Value);
        }
        private void cmd_SetWidth_Click(object sender, EventArgs e)
        {
            txt_NO_Width_PressEnter(txt_NO_Width.Value);
        }
        void txt_NO_Height_PressEnter(int value)
        {
            byte result = SetValue(value);
            if (result != 3)
            {
                project.Height = result;
                lb_Height.Text = "Height: " + project.Height.ToString();
            }
        }

        void txt_NO_Width_PressEnter(int value)
        {
            byte result = SetValue(value);
            if (result != 3)
            {
                project.Width = result;
                lb_Width.Text = "Widht: " + project.Width.ToString();
            }
        }
        #endregion

        #region Export
        private void CopyToClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(project.Export());
        }

        private void ExportToTextFile_Click(object sender, EventArgs e)
        {
            dl_Export.Filter = "Text file|*.txt";
            dl_Export.ShowDialog();
        }
        private void dl_Export_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter f = new StreamWriter(dl_Export.FileName);
            f.Write(project.Export());
            f.Close();
        }
        #endregion
        private void mnu_Table_ShowAll_Click(object sender, EventArgs e)
        {
            WordsSearch.Table tb = (WordsSearch.Table)gb_Table.Controls[0];
            tb.ShowAll();
        }
        private void mnu_FT_Click(object sender, EventArgs e) { txt_AWord.Focus(); }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddWork_Click(null, null);
        }


        private void mnu_Table_DropDownOpening(object sender, EventArgs e)
        {
            if (gb_Table.Controls.Count == 0)
                for (int i = 1; i < 7; i++) mnu_Table.DropDownItems[i].Enabled = false;
            else
                for (int i = 1; i < 7; i++) mnu_Table.DropDownItems[i].Enabled = true;
            if (lst_ListOfWords.Items.Count == 0)
                mnu_Table.DropDownItems[0].Enabled = false;
            else
                mnu_Table.DropDownItems[0].Enabled = true;
        }

        private void mnu_Project_DropDownOpening(object sender, EventArgs e)
        {
            if (project.Changed)
            {
                mnu_Project.DropDownItems[3].Enabled = true;
                mnu_Project.DropDownItems[4].Enabled = true;
            }
            else
            {
                mnu_Project.DropDownItems[3].Enabled = false;
                mnu_Project.DropDownItems[4].Enabled = false;
            }
        }

        private void mnu_LOW_DropDownOpening(object sender, EventArgs e)
        {
            mnu_LOW.DropDownItems[0].Enabled = !(txt_AWord.Text.Length == 0);

            if (lst_ListOfWords.SelectedItem == null)
                mnu_LOW.DropDownItems[3].Enabled = false;
            else
                mnu_LOW.DropDownItems[3].Enabled = true;
        }

        private void mnu_WordsSearch_Theme_Click(object sender, EventArgs e)
        {
            frm_EditTheme frmTheme = new frm_EditTheme(usertheme, themepath);
            frmTheme.ShowDialog();
            if (frmTheme.OK)
            {
                usertheme = frmTheme.UserTheme;
                if (usertheme)
                {
                    themepath = frmTheme.ThemePath;
                    se_Skin.SkinFile = themepath;
                    se_Skin.Active = true;
                }
                else
                {
                    se_Skin.Active = false;
                }
            }
        }

        private void mnu_LOW_AddDict_Click(object sender, EventArgs e)
        {
            dl_Import.ShowDialog();
        }

        private void dl_Import_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader f = new StreamReader(dl_Import.FileName);
            while (!f.EndOfStream) AddNewWord(f.ReadLine().Trim());
            f.Close();

        }

        private void mnu_Table_Option_Click(object sender, EventArgs e)
        {
            frm_Option frmOption = new frm_Option(project.option);
            frmOption.ShowDialog();
            if (frmOption.Change == true)
            {
                project.option = frmOption.option;
                ItChanged();
            }
        }

        private void mnu_WordsSearch_Help_Click(object sender, EventArgs e)
        {
            if (File.Exists("WordsSearchHelp.pdf")) System.Diagnostics.Process.Start("WordsSearchHelp.pdf");
        }

    }

}