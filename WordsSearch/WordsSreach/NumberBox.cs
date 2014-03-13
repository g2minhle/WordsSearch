using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WordsSearch
{
    public partial class NumberBox : UserControl
    {
        public NumberBox()
        {
            InitializeComponent();
        }
        public int Value
        {
            get { return int.Parse(txt_Text.Text); }
            set { txt_Text.Text = value.ToString(); }
        }
        public delegate void EnterHandel(int value);
        public event EnterHandel PressEnter;
        private void txt_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == (char)8) e.Handled = false;
            else if (e.KeyChar == (char)13)
            {
                e.Handled = false;
                PressEnter(int.Parse(txt_Text.Text));
            }
            else if (txt.Text.Length == digit || e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
            else
            e.Handled = false;

        }
    }
}
