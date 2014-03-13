using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WordsSearch
{
    public partial class frm_Option : Form
    {
        public frm_Option(Option option)
        {
            InitializeComponent();
            this.option = option;
            txt_NO_Occupy.digit = 2;
            txt_NO_Occupy.PressEnter += new NumberBox.EnterHandel(txt_NO_Occupy_PressEnter);
        }

        void txt_NO_Occupy_PressEnter(int value)
        {
            if (value > 0 && value <= 70)
            {
                this.option.Percent = value;
                lb_Percent.Text = value.ToString();
                return;
            }
            MessageBox.Show("Only from 1 to 70 %", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public Option option;
        private void cb_All_CheckedChanged(object sender, EventArgs e)
        {
            option.All = cb_All.Checked;
        }
        private void cb_SmallLatin_CheckedChanged(object sender, EventArgs e)
        {
            option.LatinS = cb_SmallLatin.Checked;
        }
        private void cb_CapitalLatin_CheckedChanged(object sender, EventArgs e)
        {
            option.LatinC = cb_CapitalLatin.Checked;
        }
        private void cb_Digit_CheckedChanged(object sender, EventArgs e)
        {
            option.Digit = cb_Digit.Checked;
        }
        private void cb_Special_CheckedChanged(object sender, EventArgs e)
        {
            option.Special = cb_Special.Checked;
        }
        private void cb_Space_CheckedChanged(object sender, EventArgs e)
        {
            option.Space = cb_Space.Checked;
        }

        private void frm_Option_Load(object sender, EventArgs e)
        {
            cb_All.Checked = option.All;
            cb_SmallLatin.Checked = option.LatinS;
            cb_CapitalLatin.Checked = option.LatinC;
            cb_Digit.Checked = option.Digit;
            cb_Special.Checked = option.Special;
            cb_Space.Checked = option.Special;
            txt_NO_Occupy.Value = option.Percent;
            lb_Percent.Text = txt_NO_Occupy.Value.ToString();
        }
        bool change;
        public bool Change
        {
            get { return change; }
        }
        private void cmd_Ok_Click(object sender, EventArgs e)
        {
            change = true;
            this.Close();
        }
        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            change = false;
            this.Close();
        }


        private void cmd_OccupySet_Click(object sender, EventArgs e)
        {
            txt_NO_Occupy_PressEnter(txt_NO_Occupy.Value);
        }
    }
}