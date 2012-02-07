namespace TrendWinForm
{
    partial class Othercheckbox_textbox
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
            this.Otherchckbox = new System.Windows.Forms.CheckBox();
            this.Othertxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Otherchckbox
            // 
            this.Otherchckbox.AutoSize = true;
            this.Otherchckbox.Location = new System.Drawing.Point(4, 3);
            this.Otherchckbox.Name = "Otherchckbox";
            this.Otherchckbox.Size = new System.Drawing.Size(52, 17);
            this.Otherchckbox.TabIndex = 0;
            this.Otherchckbox.Text = "Other";
            this.Otherchckbox.UseVisualStyleBackColor = true;
            this.Otherchckbox.CheckedChanged += new System.EventHandler(this.Otherchckbox_CheckedChanged);
            // 
            // Othertxt
            // 
            this.Othertxt.Location = new System.Drawing.Point(62, 0);
            this.Othertxt.Name = "Othertxt";
            this.Othertxt.Size = new System.Drawing.Size(100, 20);
            this.Othertxt.TabIndex = 1;
            // 
            // Othercheckbox_textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Othertxt);
            this.Controls.Add(this.Otherchckbox);
            this.Name = "Othercheckbox_textbox";
            this.Size = new System.Drawing.Size(165, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Otherchckbox;
        private System.Windows.Forms.TextBox Othertxt;
    }
}
