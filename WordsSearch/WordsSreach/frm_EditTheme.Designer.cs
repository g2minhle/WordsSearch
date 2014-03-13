namespace WordsSearch
{
    partial class frm_EditTheme
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
            this.gb_UserBox = new System.Windows.Forms.GroupBox();
            this.cmd_Browse = new System.Windows.Forms.Button();
            this.txt_ThemePath = new System.Windows.Forms.TextBox();
            this.rb_UserTheme = new System.Windows.Forms.RadioButton();
            this.rb_WindowTheme = new System.Windows.Forms.RadioButton();
            this.cmd_Cancel = new System.Windows.Forms.Button();
            this.cmd_OK = new System.Windows.Forms.Button();
            this.sdl_Open = new System.Windows.Forms.OpenFileDialog();
            this.gb_UserBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_UserBox
            // 
            this.gb_UserBox.Controls.Add(this.cmd_Browse);
            this.gb_UserBox.Controls.Add(this.txt_ThemePath);
            this.gb_UserBox.Location = new System.Drawing.Point(12, 58);
            this.gb_UserBox.Name = "gb_UserBox";
            this.gb_UserBox.Size = new System.Drawing.Size(441, 51);
            this.gb_UserBox.TabIndex = 0;
            this.gb_UserBox.TabStop = false;
            this.gb_UserBox.Text = "Chosen theme";
            // 
            // cmd_Browse
            // 
            this.cmd_Browse.Location = new System.Drawing.Point(360, 16);
            this.cmd_Browse.Name = "cmd_Browse";
            this.cmd_Browse.Size = new System.Drawing.Size(75, 23);
            this.cmd_Browse.TabIndex = 4;
            this.cmd_Browse.Text = "Browse...";
            this.cmd_Browse.UseVisualStyleBackColor = true;
            this.cmd_Browse.Click += new System.EventHandler(this.cmd_Browse_Click);
            // 
            // txt_ThemePath
            // 
            this.txt_ThemePath.Location = new System.Drawing.Point(6, 19);
            this.txt_ThemePath.Name = "txt_ThemePath";
            this.txt_ThemePath.ReadOnly = true;
            this.txt_ThemePath.Size = new System.Drawing.Size(348, 20);
            this.txt_ThemePath.TabIndex = 3;
            // 
            // rb_UserTheme
            // 
            this.rb_UserTheme.AutoSize = true;
            this.rb_UserTheme.Location = new System.Drawing.Point(12, 35);
            this.rb_UserTheme.Name = "rb_UserTheme";
            this.rb_UserTheme.Size = new System.Drawing.Size(79, 17);
            this.rb_UserTheme.TabIndex = 2;
            this.rb_UserTheme.TabStop = true;
            this.rb_UserTheme.Text = "User theme";
            this.rb_UserTheme.UseVisualStyleBackColor = true;
            // 
            // rb_WindowTheme
            // 
            this.rb_WindowTheme.AutoSize = true;
            this.rb_WindowTheme.Location = new System.Drawing.Point(12, 12);
            this.rb_WindowTheme.Name = "rb_WindowTheme";
            this.rb_WindowTheme.Size = new System.Drawing.Size(96, 17);
            this.rb_WindowTheme.TabIndex = 1;
            this.rb_WindowTheme.TabStop = true;
            this.rb_WindowTheme.Text = "Window theme";
            this.rb_WindowTheme.UseVisualStyleBackColor = true;
            this.rb_WindowTheme.CheckedChanged += new System.EventHandler(this.rb_WindowTheme_CheckedChanged);
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Location = new System.Drawing.Point(378, 115);
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.cmd_Cancel.TabIndex = 6;
            this.cmd_Cancel.Text = "Cancel";
            this.cmd_Cancel.UseVisualStyleBackColor = true;
            this.cmd_Cancel.Click += new System.EventHandler(this.cmd_Cancel_Click);
            // 
            // cmd_OK
            // 
            this.cmd_OK.Location = new System.Drawing.Point(291, 115);
            this.cmd_OK.Name = "cmd_OK";
            this.cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.cmd_OK.TabIndex = 5;
            this.cmd_OK.Text = "OK";
            this.cmd_OK.UseVisualStyleBackColor = true;
            this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
            // 
            // sdl_Open
            // 
            this.sdl_Open.Filter = "Iris Skin (*.ssk) | *.ssk";
            this.sdl_Open.InitialDirectory = "Skin";
            this.sdl_Open.RestoreDirectory = true;
            this.sdl_Open.Title = "Browse skin";
            this.sdl_Open.FileOk += new System.ComponentModel.CancelEventHandler(this.sdl_Save_FileOk);
            // 
            // frm_EditTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 143);
            this.Controls.Add(this.cmd_OK);
            this.Controls.Add(this.cmd_Cancel);
            this.Controls.Add(this.rb_WindowTheme);
            this.Controls.Add(this.rb_UserTheme);
            this.Controls.Add(this.gb_UserBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditTheme";
            this.Text = "Edit Theme";
            this.gb_UserBox.ResumeLayout(false);
            this.gb_UserBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_UserBox;
        private System.Windows.Forms.Button cmd_Browse;
        private System.Windows.Forms.TextBox txt_ThemePath;
        private System.Windows.Forms.RadioButton rb_UserTheme;
        private System.Windows.Forms.RadioButton rb_WindowTheme;
        private System.Windows.Forms.Button cmd_Cancel;
        private System.Windows.Forms.Button cmd_OK;
        private System.Windows.Forms.OpenFileDialog sdl_Open;

    }
}