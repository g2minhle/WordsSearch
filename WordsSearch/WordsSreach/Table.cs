using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WordsSearch
{
    public partial class Table : UserControl
    {
        public Table()
        {
            InitializeComponent();
        }
        int lettersize;
        public int LetterSize
        {
            get { return lettersize; }
            set
            {
                tb_LableSize.Value = value;
                lettersize = value;
            }
        }
        public Panel Panel
        {
            get { return pn_TheTable; }
            set { pn_TheTable = value; }
        }
        private void sb_Vertical_Scroll(object sender, ScrollEventArgs e) { pn_TheTable.Top = -sb_Vertical.Value; }
        private void sb_Horizontal_Scroll(object sender, ScrollEventArgs e) { pn_TheTable.Left = -sb_Horizontal.Value; }

        WordsSearch.Project.Table table;
        List<AWord> wordlist;
        public void CreateTable(WordsSearch.Project.Table table, List<AWord> wordlist)
        {
            this.table = table;
            this.wordlist = wordlist;
            CreateTable();
            ShowAll();
        }
        List<int>[][] note;
        public void CreateTable()
        {
            SuspendLayout();
            pn_TheTable.Controls.Clear();
            note = new List<int>[table.height][];
            for (int i = 0; i < table.height; i++)
            {
                note[i] = new List<int>[table.width];
                for (int j = 0; j < table.width; j++)
                {
                    note[i][j] = new List<int>();
                    Label lb = new Label();
                    lb.Size = new System.Drawing.Size(lettersize, lettersize);
                    lb.Location = new Point(lettersize * j, lettersize * i);
                    lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lb.BorderStyle = BorderStyle.Fixed3D;
                    lb.Text = table.table[i][j].ToString();
                    lb.Click += new EventHandler(lb_Click);
                    lb.BackColor = Color.LightGray;
                    lb.Name = i.ToString() + ":" + j.ToString();
                    pn_TheTable.Controls.Add(lb);
                }
            }
            for (int i = 0; i < wordlist.Count; i++)
            {
                int length = wordlist[i].Word.Length;
                for (int j = 0; j < length; j++)
                {
                    int tmp = i;
                    note[wordlist[i].allpoint[j].i][wordlist[i].allpoint[j].j].Add(tmp);
                }
            }
            pn_TheTable.Width = table.width * (lettersize + 5);
            pn_TheTable.Height = table.height * (lettersize + 5);
            sb_Horizontal.Maximum = pn_TheTable.Height;
            sb_Vertical.Maximum = pn_TheTable.Width;
            ResumeLayout();
        }
        void Clear()
        {
            Label lb;
            for (int i = 0; i < pn_TheTable.Controls.Count; i++)
            {
                lb = (Label)pn_TheTable.Controls[i];
                lb.BackColor = Color.LightGray;
            }
        }
        void ChangeColor(int index)
        {
            Label lb;
            int length = wordlist[index].Word.Length;
            for (int k = 0; k < length; k++)
            {
                int i = wordlist[index].allpoint[k].i;
                int j = wordlist[index].allpoint[k].j;
                lb = (Label)pn_TheTable.Controls[i.ToString() + ":" + j.ToString()];
                if (note[i][j].Count == 1)
                    lb.BackColor = Color.LightGreen;
                else
                    lb.BackColor = Color.LightYellow;
            }
        }
        public void ShowAll()
        {
            Clear();
            for (int i = 0; i < wordlist.Count; i++) ChangeColor(i);
        }
        public void Appear(int index)
        {
            Clear();
            ChangeColor(index);
        }
        void lb_Click(object sender, EventArgs e)
        {
            SuspendLayout(); Clear();
            Label lb = (Label)sender;
            string[] s = lb.Name.Split(':');
            int i = int.Parse(s[0]);
            int j = int.Parse(s[1]);
            if (note[i][j].Count == 0)
                lb.BackColor = Color.LightBlue;
            else
            {
                for (int k = 0; k < note[i][j].Count; k++)
                    ChangeColor(note[i][j][k]);
                if (note[i][j].Count != 1) lb.BackColor = Color.LightYellow;
            }
            ResumeLayout();
        }
        private void Table_Resize(object sender, EventArgs e)
        {
            sb_Vertical.Minimum = 0;
            sb_Vertical.Maximum = pn_TheTable.Height;
            sb_Horizontal.Minimum = 0;
            sb_Horizontal.Maximum = pn_TheTable.Width;
        }

        private void tb_LableSize_Scroll(object sender, EventArgs e)
        {
            lettersize = tb_LableSize.Value;
            CreateTable();
        }

        private void tb_LableSize_ValueChanged(object sender, EventArgs e)
        {
            tb_LableSize_Scroll(null, null);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            this.tb_LableSize.ValueChanged += new System.EventHandler(this.tb_LableSize_ValueChanged);
            this.tb_LableSize.Scroll += new System.EventHandler(this.tb_LableSize_Scroll);
        }

    }
}
