namespace YesCheckBoxOption
{
    partial class YesCheckBox_TextBox
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
            this.txtYes = new System.Windows.Forms.TextBox();
            this.chckYes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtYes
            // 
            this.txtYes.Location = new System.Drawing.Point(53, 0);
            this.txtYes.Name = "txtYes";
            this.txtYes.Size = new System.Drawing.Size(100, 20);
            this.txtYes.TabIndex = 2;
            // 
            // chckYes
            // 
            this.chckYes.AutoSize = true;
            this.chckYes.Location = new System.Drawing.Point(3, 3);
            this.chckYes.Name = "chckYes";
            this.chckYes.Size = new System.Drawing.Size(44, 17);
            this.chckYes.TabIndex = 1;
            this.chckYes.Text = "Yes";
            this.chckYes.UseVisualStyleBackColor = true;
            this.chckYes.CheckedChanged += new System.EventHandler(this.chckYes_CheckedChanged);
            // 
            // YesCheckBox_TextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYes);
            this.Controls.Add(this.chckYes);
            this.Name = "YesCheckBox_TextBox";
            this.Size = new System.Drawing.Size(164, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYes;
        private System.Windows.Forms.CheckBox chckYes;
    }
}
