using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WordsSearch
{
    public partial class frm_EditTheme : Form
    {
        public frm_EditTheme(bool usertheme, string curpath)
        {
            InitializeComponent();
            rb_UserTheme.Checked = usertheme;
            rb_WindowTheme.Checked = !usertheme;
            txt_ThemePath.Text = curpath;
            OK = false;
        }
        public bool OK;
        public string ThemePath { get { return txt_ThemePath.Text; } }
        public bool UserTheme { get { return rb_UserTheme.Checked; } }
        private void rb_WindowTheme_CheckedChanged(object sender, EventArgs e)
        {
            gb_UserBox.Enabled = rb_UserTheme.Checked;
        }

        private void cmd_Browse_Click(object sender, EventArgs e)
        {
            sdl_Open.ShowDialog();
        }

        private void sdl_Save_FileOk(object sender, CancelEventArgs e)
        {
            txt_ThemePath.Text = sdl_Open.FileName;
        }

        private void cmd_OK_Click(object sender, EventArgs e)
        {
            OK = true;
            this.Close();
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}