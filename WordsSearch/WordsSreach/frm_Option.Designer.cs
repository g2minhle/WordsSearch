namespace WordsSearch
{
    partial class frm_Option
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
            this.cb_SmallLatin = new System.Windows.Forms.CheckBox();
            this.cmd_Ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Special = new System.Windows.Forms.CheckBox();
            this.cb_Digit = new System.Windows.Forms.CheckBox();
            this.cb_All = new System.Windows.Forms.CheckBox();
            this.cb_CapitalLatin = new System.Windows.Forms.CheckBox();
            this.cb_Space = new System.Windows.Forms.CheckBox();
            this.cmd_Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NO_Occupy = new WordsSearch.NumberBox();
            this.cmd_OccupySet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Percent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_SmallLatin
            // 
            this.cb_SmallLatin.AutoSize = true;
            this.cb_SmallLatin.Location = new System.Drawing.Point(6, 42);
            this.cb_SmallLatin.Name = "cb_SmallLatin";
            this.cb_SmallLatin.Size = new System.Drawing.Size(143, 17);
            this.cb_SmallLatin.TabIndex = 0;
            this.cb_SmallLatin.Text = "Small Latin symbols [a..z]";
            this.cb_SmallLatin.UseVisualStyleBackColor = true;
            this.cb_SmallLatin.CheckedChanged += new System.EventHandler(this.cb_SmallLatin_CheckedChanged);
            // 
            // cmd_Ok
            // 
            this.cmd_Ok.Location = new System.Drawing.Point(9, 269);
            this.cmd_Ok.Name = "cmd_Ok";
            this.cmd_Ok.Size = new System.Drawing.Size(75, 23);
            this.cmd_Ok.TabIndex = 1;
            this.cmd_Ok.Text = "OK";
            this.cmd_Ok.UseVisualStyleBackColor = true;
            this.cmd_Ok.Click += new System.EventHandler(this.cmd_Ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Special);
            this.groupBox1.Controls.Add(this.cb_Digit);
            this.groupBox1.Controls.Add(this.cb_All);
            this.groupBox1.Controls.Add(this.cb_CapitalLatin);
            this.groupBox1.Controls.Add(this.cb_Space);
            this.groupBox1.Controls.Add(this.cb_SmallLatin);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character";
            // 
            // cb_Special
            // 
            this.cb_Special.AutoSize = true;
            this.cb_Special.Location = new System.Drawing.Point(6, 111);
            this.cb_Special.Name = "cb_Special";
            this.cb_Special.Size = new System.Drawing.Size(146, 17);
            this.cb_Special.TabIndex = 5;
            this.cb_Special.Text = "Special symbols [!@#$...]";
            this.cb_Special.UseVisualStyleBackColor = true;
            this.cb_Special.CheckedChanged += new System.EventHandler(this.cb_Special_CheckedChanged);
            // 
            // cb_Digit
            // 
            this.cb_Digit.AutoSize = true;
            this.cb_Digit.Location = new System.Drawing.Point(6, 88);
            this.cb_Digit.Name = "cb_Digit";
            this.cb_Digit.Size = new System.Drawing.Size(79, 17);
            this.cb_Digit.TabIndex = 4;
            this.cb_Digit.Text = "Digits [0..9]";
            this.cb_Digit.UseVisualStyleBackColor = true;
            this.cb_Digit.CheckedChanged += new System.EventHandler(this.cb_Digit_CheckedChanged);
            // 
            // cb_All
            // 
            this.cb_All.AutoSize = true;
            this.cb_All.Location = new System.Drawing.Point(6, 19);
            this.cb_All.Name = "cb_All";
            this.cb_All.Size = new System.Drawing.Size(80, 17);
            this.cb_All.TabIndex = 3;
            this.cb_All.Text = "All printable";
            this.cb_All.UseVisualStyleBackColor = true;
            this.cb_All.CheckedChanged += new System.EventHandler(this.cb_All_CheckedChanged);
            // 
            // cb_CapitalLatin
            // 
            this.cb_CapitalLatin.AutoSize = true;
            this.cb_CapitalLatin.Location = new System.Drawing.Point(6, 65);
            this.cb_CapitalLatin.Name = "cb_CapitalLatin";
            this.cb_CapitalLatin.Size = new System.Drawing.Size(153, 17);
            this.cb_CapitalLatin.TabIndex = 2;
            this.cb_CapitalLatin.Text = "Capital Latin symbols [A..Z]";
            this.cb_CapitalLatin.UseVisualStyleBackColor = true;
            this.cb_CapitalLatin.CheckedChanged += new System.EventHandler(this.cb_CapitalLatin_CheckedChanged);
            // 
            // cb_Space
            // 
            this.cb_Space.AutoSize = true;
            this.cb_Space.Location = new System.Drawing.Point(6, 134);
            this.cb_Space.Name = "cb_Space";
            this.cb_Space.Size = new System.Drawing.Size(69, 17);
            this.cb_Space.TabIndex = 1;
            this.cb_Space.Text = "Space [ ]";
            this.cb_Space.UseVisualStyleBackColor = true;
            this.cb_Space.CheckedChanged += new System.EventHandler(this.cb_Space_CheckedChanged);
            // 
            // cmd_Cancel
            // 
            this.cmd_Cancel.Location = new System.Drawing.Point(99, 269);
            this.cmd_Cancel.Name = "cmd_Cancel";
            this.cmd_Cancel.Size = new System.Drawing.Size(75, 23);
            this.cmd_Cancel.TabIndex = 5;
            this.cmd_Cancel.Text = "Cancel";
            this.cmd_Cancel.UseVisualStyleBackColor = true;
            this.cmd_Cancel.Click += new System.EventHandler(this.cmd_Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_NO_Occupy);
            this.groupBox2.Controls.Add(this.cmd_OccupySet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_Percent);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Words will be able to occupy about";
            // 
            // txt_NO_Occupy
            // 
            this.txt_NO_Occupy.Location = new System.Drawing.Point(6, 57);
            this.txt_NO_Occupy.Name = "txt_NO_Occupy";
            this.txt_NO_Occupy.Size = new System.Drawing.Size(48, 23);
            this.txt_NO_Occupy.TabIndex = 12;
            // 
            // cmd_OccupySet
            // 
            this.cmd_OccupySet.Location = new System.Drawing.Point(60, 57);
            this.cmd_OccupySet.Name = "cmd_OccupySet";
            this.cmd_OccupySet.Size = new System.Drawing.Size(75, 23);
            this.cmd_OccupySet.TabIndex = 10;
            this.cmd_OccupySet.Text = "Set";
            this.cmd_OccupySet.UseVisualStyleBackColor = true;
            this.cmd_OccupySet.Click += new System.EventHandler(this.cmd_OccupySet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "% of the table";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Percent
            // 
            this.lb_Percent.AutoSize = true;
            this.lb_Percent.Location = new System.Drawing.Point(30, 31);
            this.lb_Percent.Name = "lb_Percent";
            this.lb_Percent.Size = new System.Drawing.Size(15, 13);
            this.lb_Percent.TabIndex = 8;
            this.lb_Percent.Text = "%";
            this.lb_Percent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 304);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmd_Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmd_Ok);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option dialog";
            this.Load += new System.EventHandler(this.frm_Option_Load);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Option_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_SmallLatin;
        private System.Windows.Forms.Button cmd_Ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_CapitalLatin;
        private System.Windows.Forms.CheckBox cb_Space;
        private System.Windows.Forms.CheckBox cb_Special;
        private System.Windows.Forms.CheckBox cb_Digit;
        private System.Windows.Forms.CheckBox cb_All;
        private System.Windows.Forms.Button cmd_Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Percent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_OccupySet;
        private NumberBox txt_NO_Occupy;
    }
}