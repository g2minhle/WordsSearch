using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace WordsSearch
{
    public class Project
    {
        #region Struct
        public struct Table
        {
            public char[][] table;
            public string All
            {
                get
                {
                    string s = "";
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                            s += table[i][j] + " ";
                        s += (char)10;
                    }
                    return s;
                }
            }
            public int height;
            public int width;
        };
        public string Export()
        {
            string s = table.All;
            s += (char)10;
            for (int i = 0; i < WordsList.Count; i++)
                s += WordsList[i].Word + " ";
            return s;
        }
        int[] loani ={ -1, -1, 0, 1, 1, 1, 0, -1 };
        int[] loanj ={ 0, 1, 1, 1, 0, -1, -1, -1 };
        #endregion

        #region Var
        public List<AWord> WordsList;
        Creating createdialog;
        Table table;
        public Option option;
        Thread Thr_creat;
        FileInfo path;
        bool changed;
        bool create;
        protected int totallength;
        protected byte height;
        public byte Height
        {
            get { return height; }
            set
            {
                byte tmp = height;
                height = value;
                for (int i = 0; i < WordsList.Count; i++)
                {
                    if (IsLegal(WordsList[i].Word) != 0)
                    {
                        MessageBox.Show("New Height can not fit with the current list of words", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        height = tmp;
                        return;
                    }
                }
            }
        }
        protected byte width;
        public byte Width
        {
            get { return width; }
            set
            {
                byte tmp = width;
                width = value;
                for (int i = 0; i < WordsList.Count; i++)
                {
                    if (IsLegal(WordsList[i].Word) != 0)
                    {
                        MessageBox.Show("New Width can not fit with the current list of words", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        width = tmp;
                        return;
                    }
                }
            }
        }
        public FileInfo Path
        {
            get { return path; }
        }
        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }
        public bool Created
        {
            get { return create; }
            set { create = value; }
        }
        #endregion

        #region Contructure
        public Project(string filename, ref ListBox lstbox)
        {
            try
            {
                Contructure();
                BinaryReader f = new BinaryReader(File.Open(filename, FileMode.Open));
                path = new FileInfo(filename);
                lstbox.Items.Clear();
                //read the amount of words
                int tmp = f.ReadInt32();
                #region read all the word from the file
                for (int i = 0; i < tmp; i++)
                {
                    AWord awordtmp = new AWord(f.ReadString(), f.ReadInt32(), f.ReadInt32(), f.ReadInt32());
                    awordtmp.allpoint = new AWord.Points[awordtmp.Word.Length];
                    for (int j = 0; j < awordtmp.Word.Length; j++)
                    {
                        awordtmp.allpoint[j].i = f.ReadInt32();
                        awordtmp.allpoint[j].j = f.ReadInt32();
                    }
                    WordsList.Add(awordtmp);
                    lstbox.Items.Add(awordtmp.Word);
                }
                #endregion
                #region Load temp part but can not be disposed
                totallength = f.ReadInt32();
                height = f.ReadByte();
                width = f.ReadByte();
                create = f.ReadBoolean();
                #endregion
                #region Load table
                //load table.height for the table
                table.height = f.ReadInt32();
                //load table.width for the table
                table.width = f.ReadInt32();
                #region read the table from file
                table.table = new char[table.height][];
                for (int i = 0; i < table.height; i++)
                {
                    table.table[i] = new char[table.width];
                    for (int j = 0; j < table.width; j++)
                    {
                        table.table[i][j] = f.ReadChar();
                    }
                }
                #endregion
                #endregion
                #region Load all the option
                option = new Option();
                option.Percent = f.ReadInt32();
                option.All = f.ReadBoolean();
                option.Digit = f.ReadBoolean();
                option.LatinC = f.ReadBoolean();
                option.LatinS = f.ReadBoolean();
                option.Space = f.ReadBoolean();
                option.Special = f.ReadBoolean();
                #endregion
                f.Close();
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        void Contructure()
        {
            WordsList = new List<AWord>();
            totallength = 0;
            height = 10;
            width = 10;
            option = new Option();
        }
        public Project()
        {
            Contructure();
        }
        #endregion

        #region Add words
        int IsLegal(string input)
        {
            if (input.Length == 0) return 8;
            float _tmp=(float )(totallength + input.Length) /(float ) (height * width);
            if (  _tmp * 100 > option.Percent) return 6;
            if (input.Length > height && input.Length > width) return 7;
            if (option.All == true) return 0;
            if (option.Digit == false)
                for (int i = 0; i < input.Length; i++)
                    if (input[i] >= '0' && input[i] < '9') return 1;
            if (option.LatinC == false)
                for (int i = 0; i < input.Length; i++)
                    if (input[i] >= 'A' && input[i] < 'Z') return 2;
            if (option.LatinS == false)
                for (int i = 0; i < input.Length; i++)
                    if (input[i] >= 'a' && input[i] < 'z') return 3;
            if (option.Space == false)
                for (int i = 0; i < input.Length; i++)
                    if (input[i] == ' ') return 4;
            if (option.Special == false)
            {
                string tmp = "\"`~!@#$%^&*()_+|{}:<>?-=\\[];',.//";
                for (int i = 0; i < input.Length; i++)
                    if (tmp.IndexOf(input[i]) != -1) return 5;
            }
            return 0;
        }
        public bool AddAword(string input)
        {
            int islegal = IsLegal(input);
            if (islegal == 0)
            {
                AWord tmp = new AWord(input);
                WordsList.Add(tmp);
                totallength += input.Length;
                create = false;
                changed = true;
                return true;
            }
            else
            {
                #region Show Error
                string stmp = "";
                switch (islegal)
                {
                    case 1: stmp = stmp + "Number";
                        break;
                    case 2: stmp = stmp + "Capital Latin symbols";
                        break;
                    case 3: stmp = stmp + "Small Latin symbols";
                        break;
                    case 4: stmp = stmp + "Space";
                        break;
                    case 5: stmp = stmp + "Special symbols";
                        break;
                    case 6: MessageBox.Show("There is no more space for this word !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    case 7: MessageBox.Show("The word is too long !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    case 8: MessageBox.Show("You must type in the word first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                };
                stmp = stmp + " is not allowed being in this word";
                MessageBox.Show(stmp, "Information for \""+input +"\"" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
                #endregion
            }
        }
        #endregion

        #region remove
        public bool Remove(int index)
        {
            if (index > -1 && index < WordsList.Count)
            {
                totallength -= WordsList[index].Word.Length;
                WordsList.RemoveAt(index);
                create = false;
                changed = true;
                return true;
            }
            return false;
        }
        #endregion
        
        #region Create the table
        public void CreateTable()
        {
            Thr_creat = new Thread(Create);
            createdialog = new Creating();
            Thr_creat.IsBackground = true;
            Thr_creat.Start();
            createdialog.ShowDialog();
            if (Thr_creat.IsAlive)
            {
                Thr_creat.Abort();
                return;
            }
            if (create) DoneCreate();
            else MessageBox.Show("Unable to create the table", "Cannot Create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public delegate void DoneCreateHandel();
        public event DoneCreateHandel DoneCreate;
        bool PutIn(int index)
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    for (int k = 0; k < 8; k++)
                        if (Check(index, k, i, j))
                        {
                            PutIn(index, k, i, j);
                            return true;
                        }
            return false;
        }
        void Create()
        {
            table.width = width;
            table.height = height;
            Random rnd = new Random();
            ///set the allowed char
            string allowedchar = option.SetAllowedString;
            #region Create New Table Array
            table.table = new char[table.height][];
            for (int i = 0; i < table.height; i++)
                table.table[i] = new char[table.width];
            #endregion
            #region Put all the words into the table
            for (int i = 0; i < WordsList.Count; i++)
            {
                int attemp = 0;
                int direction;
                int itmp;
                int jtmp;
                bool fit;
                do
                {
                    ///choose the direction randomly
                    direction = rnd.Next(0, 7); ;
                    ///then the possion on the table
                    itmp = rnd.Next(0, table.height - 1);
                    jtmp = rnd.Next(0, table.width - 1);
                    fit = Check(i, direction, itmp, jtmp);
                    attemp++;
                } while ((!fit) && (attemp < 1000));
                if (fit) PutIn(i, direction, itmp, jtmp);
                else fit = PutIn(i);
                if (!fit)
                {
                    while (!createdialog.CloseAble) ;
                    createdialog.Close();
                    return;
                }
            }
            #endregion
            #region Put random character radomly into the table
            for (int i = 0; i < table.height; i++)
                for (int j = 0; j < table.width; j++)
                    if (table.table[i][j] == 0)
                        table.table[i][j] = allowedchar[rnd.Next(0, allowedchar.Length - 1)];
            #endregion
            create = true;
            while (!createdialog.CloseAble) ;
            createdialog.Close();
        }
        bool Check(int index, int direction, int i, int j)
        {
            string chuoi = WordsList[index].Word;
            int tmpi = i + loani[direction] * chuoi.Length;
            int tmpj = j + loanj[direction] * chuoi.Length;

            if (tmpi < 0 || tmpi > table.height - 1) return false;
            if (tmpj < 0 || tmpj > table.width - 1) return false;

            for (int k = 0; k < index; k++)
                for (int k1 = 0; k1 < chuoi.Length; k1++)
                    for (int k2 = 0; k2 < WordsList[k].Word.Length; k2++)
                        if (i + loani[direction] * k1 == WordsList[k].I + loani[WordsList[k].Direction] * k2 && j + loanj[direction] * k1 == WordsList[k].J + loanj[WordsList[k].Direction] * k2)
                            if (chuoi[k1] != WordsList[k].Word[k2]) return false;
            return true;
        }
        void PutIn(int index, int direction, int i, int j)
        {
            WordsList[index].I = i;
            WordsList[index].J = j;
            WordsList[index].Direction = direction;
            string word = WordsList[index].Word;
            WordsList[index].allpoint = new AWord.Points[word.Length];
            for (int k = 0; k < word.Length; k++)
            {
                int tmpi = i + loani[direction] * k;
                int tmpj = j + loanj[direction] * k;
                table.table[tmpi][tmpj] = word[k];
                WordsList[index].allpoint[k].i = tmpi;
                WordsList[index].allpoint[k].j = tmpj;
            }
        }
        #endregion

        #region Save
        public void Save(string filename)
        {
            try
            {
                BinaryWriter f = new BinaryWriter(File.Open(filename, FileMode.Create));
                f.Write(WordsList.Count);
                #region Wirte all words into buffer
                for (int i = 0; i < WordsList.Count; i++)
                {
                    f.Write(WordsList[i].Word);
                    f.Write(WordsList[i].I);
                    f.Write(WordsList[i].J);
                    f.Write(WordsList[i].Direction);
                    for (int j = 0; j < WordsList[i].Word.Length; j++)
                    {
                        f.Write(WordsList[i].allpoint[j].i);
                        f.Write(WordsList[i].allpoint[j].j);
                    }
                }
                #endregion
                #region Write all temp part but can not be disposed
                f.Write(totallength);
                f.Write(height);
                f.Write(width);
                f.Write(create);
                #endregion
                #region Write the table into buffer
                f.Write(table.height);
                f.Write(table.width);
                for (int i = 0; i < table.height; i++)
                    for (int j = 0; j < table.width; j++)
                        f.Write(table.table[i][j]);
                #endregion
                #region Write all option into buffer
                f.Write(option.Percent);
                f.Write(option.All);
                f.Write(option.Digit);
                f.Write(option.LatinC);
                f.Write(option.LatinS);
                f.Write(option.Space);
                f.Write(option.Special);
                #endregion
                f.Flush();
                f.Close();
                path = new FileInfo(filename);
                changed = false;
            }
            catch (Exception e)
            { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Other function
        public Table TheTable { get { return table; } }
        #endregion
    }
}
