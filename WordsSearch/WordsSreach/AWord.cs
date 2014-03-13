using System;
using System.Collections.Generic;
using System.Text;

namespace WordsSearch
{
    public class AWord
    {
        protected string str;
        protected int i;
        protected int j;
        protected int direction;
        public struct Points
        { public int i, j;        }
        public Points[] allpoint;
        public string Word
        {
            get { return str; }
            set { str = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public int J
        {
            get { return j; }
            set { j = value; }
        }
        public int Direction
        {
            get { return direction; }
            set
            { direction = value; }
        }
        public AWord(string word)
        {
            str = word;
            i = -1;
            j = -1;
            direction = -1;
        }
        public AWord()
        {
            str = "";
            i = -1;
            j = -1;
            direction = -1;
        }
        public AWord(string word, int i, int j, int direction)
        {
            this.i = i;
            this.j = j;
            this.direction = direction;
            str = word;
        }
    }
}
