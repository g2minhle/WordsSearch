namespace WordsSearch
{
    partial class Table
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
            this.pn_TheTable = new System.Windows.Forms.Panel();
            this.sb_Vertical = new System.Windows.Forms.VScrollBar();
            this.sb_Horizontal = new System.Windows.Forms.HScrollBar();
            this.tb_LableSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tb_LableSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_TheTable
            // 
            this.pn_TheTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_TheTable.Location = new System.Drawing.Point(3, 3);
            this.pn_TheTable.Name = "pn_TheTable";
            this.pn_TheTable.Size = new System.Drawing.Size(540, 338);
            this.pn_TheTable.TabIndex = 0;
            // 
            // sb_Vertical
            // 
            this.sb_Vertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sb_Vertical.Location = new System.Drawing.Point(542, 3);
            this.sb_Vertical.Name = "sb_Vertical";
            this.sb_Vertical.Size = new System.Drawing.Size(17, 338);
            this.sb_Vertical.TabIndex = 1;
            this.sb_Vertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sb_Vertical_Scroll);
            // 
            // sb_Horizontal
            // 
            this.sb_Horizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sb_Horizontal.Location = new System.Drawing.Point(0, 341);
            this.sb_Horizontal.Name = "sb_Horizontal";
            this.sb_Horizontal.Size = new System.Drawing.Size(432, 17);
            this.sb_Horizontal.TabIndex = 2;
            this.sb_Horizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sb_Horizontal_Scroll);
            // 
            // tb_LableSize
            // 
            this.tb_LableSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LableSize.AutoSize = false;
            this.tb_LableSize.LargeChange = 10;
            this.tb_LableSize.Location = new System.Drawing.Point(435, 341);
            this.tb_LableSize.Maximum = 100;
            this.tb_LableSize.Minimum = 20;
            this.tb_LableSize.Name = "tb_LableSize";
            this.tb_LableSize.Size = new System.Drawing.Size(124, 17);
            this.tb_LableSize.SmallChange = 5;
            this.tb_LableSize.TabIndex = 3;
            this.tb_LableSize.TickFrequency = 10;
            this.tb_LableSize.Value = 50;
        
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_LableSize);
            this.Controls.Add(this.sb_Horizontal);
            this.Controls.Add(this.sb_Vertical);
            this.Controls.Add(this.pn_TheTable);
            this.Name = "Table";
            this.Size = new System.Drawing.Size(559, 358);
            this.Load += new System.EventHandler(this.Table_Load);
            this.Resize += new System.EventHandler(this.Table_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tb_LableSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_TheTable;
        private System.Windows.Forms.VScrollBar sb_Vertical;
        private System.Windows.Forms.HScrollBar sb_Horizontal;
        private System.Windows.Forms.TrackBar tb_LableSize;
    }
}
