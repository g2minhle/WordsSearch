using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordsSearch
{
    public partial class Creating : Form
    {
        public Creating()
        {
            InitializeComponent();
            CloseAble = false;
        }
        public bool CloseAble;
        private void Creating_Shown(object sender, EventArgs e)
        {
            counter = 1;
            tm_Changer.Enabled = true;
            lb_Creating.Text = "Creating";
            CloseAble = true;
        }
        int counter;
        private void tm_Changer_Tick(object sender, EventArgs e)
        {
            counter++;
            lb_Creating.Text = "Creating";
            switch (counter)
            {
                case 1: lb_Creating.Text += ".";
                    break;
                case 2: lb_Creating.Text += "..";
                    break;
                case 3: lb_Creating.Text += "...";
                    break;
                default:
                    {
                        counter = 0;
                        lb_Creating.Text = "Creating";
                    }
                    break;
            }
        }

    }
}