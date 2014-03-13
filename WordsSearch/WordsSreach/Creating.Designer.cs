namespace WordsSearch
{
    partial class Creating
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
            this.components = new System.ComponentModel.Container();
            this.lb_Creating = new System.Windows.Forms.Label();
            this.tm_Changer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lb_Creating
            // 
            this.lb_Creating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Creating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Creating.Location = new System.Drawing.Point(0, 0);
            this.lb_Creating.Name = "lb_Creating";
            this.lb_Creating.Size = new System.Drawing.Size(210, 39);
            this.lb_Creating.TabIndex = 0;
            this.lb_Creating.Text = "label1";
            this.lb_Creating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tm_Changer
            // 
            this.tm_Changer.Interval = 1000;
            this.tm_Changer.Tick += new System.EventHandler(this.tm_Changer_Tick);
            // 
            // Creating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 39);
            this.Controls.Add(this.lb_Creating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Creating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating";
            this.Shown += new System.EventHandler(this.Creating_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Creating;
        private System.Windows.Forms.Timer tm_Changer;
    }
}