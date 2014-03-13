using System;
using System.Collections.Generic;
using System.Text;
namespace WordsSearch
{
    public class Option
    {
        #region Init
        public Option(bool All
            , bool LatinS
            , bool LatinC
            , bool Digit
            , bool Space
            , bool Special
            , int Percent)
        {
            this.All = All;
            this.LatinS = LatinS;
            this.LatinC = LatinC;
            this.Digit = Digit;
            this.Space = Space;
            this.Special = Special;
            this.Percent = Percent;
        }
        public Option()
        {
            All = false;
            LatinS = true;
            LatinC = false;
            Digit = false;
            Space = false;
            Special = false;
            Percent = 50;
        }
        #endregion
        
        #region Variable
        public bool All;
        public bool LatinS;
        public bool LatinC;
        public bool Digit;
        public bool Space;
        public bool Special;
        public int Percent;
        #endregion

        #region Function
        public string SetAllowedString
        {
            get
            {
                string allowedchar="";
                if (All == true)
                {
                    allowedchar = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz\"`~!@#$%^&*()_+|{}:<>?-=\\[];',.// ";
                    return allowedchar;
                }
                if (Digit == true)
                {
                    for (int i = '0'; i <= '9'; i++)
                    {
                        allowedchar = allowedchar + (char)i;
                    }
                }
                if (LatinC == true)
                {
                    for (int i = 'A'; i <= 'Z'; i++)
                    {
                        allowedchar = allowedchar + (char)i;
                    }
                }
                if (LatinS == true)
                {
                    for (int i = 'a'; i <= 'z'; i++)
                    {
                        allowedchar = allowedchar + (char)i;
                    }
                }
                if (Special == true)
                {
                    allowedchar = allowedchar + "\"`~!@#$%^&*()_+|{}:<>?-=\\[];',.//";
                }
                if (Space == true)
                {
                    allowedchar = allowedchar + " ";
                }
                return allowedchar;
            }
        }
        #endregion
    }
}
