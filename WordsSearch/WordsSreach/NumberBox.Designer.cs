namespace WordsSearch
{
    partial class NumberBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Text
            // 
            this.txt_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Text.Location = new System.Drawing.Point(0, 0);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(100, 20);
            this.txt_Text.TabIndex = 0;
            this.txt_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Text_KeyPress);
            // 
            // NumberBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Text);
            this.Name = "NumberBox";
            this.Size = new System.Drawing.Size(103, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Text;
        public int digit;
    }
}
