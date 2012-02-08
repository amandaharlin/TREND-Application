namespace TrendCustromControls
{
    partial class NameUserControl
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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.middlenametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.orInitialTxt = new System.Windows.Forms.Label();
            this.groupBoxName.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.lastnametxt);
            this.groupBoxName.Controls.Add(this.lastnamelbl);
            this.groupBoxName.Controls.Add(this.middlenametxt);
            this.groupBoxName.Controls.Add(this.label2);
            this.groupBoxName.Controls.Add(this.firstnametxt);
            this.groupBoxName.Controls.Add(this.firstnamelbl);
            this.groupBoxName.Controls.Add(this.orInitialTxt);
            this.groupBoxName.Location = new System.Drawing.Point(0, 3);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(358, 108);
            this.groupBoxName.TabIndex = 1;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(91, 74);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(261, 20);
            this.lastnametxt.TabIndex = 3;
       
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Location = new System.Drawing.Point(9, 78);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(58, 13);
            this.lastnamelbl.TabIndex = 4;
            this.lastnamelbl.Text = "Last Name";
            // 
            // middlenametxt
            // 
            this.middlenametxt.Location = new System.Drawing.Point(91, 47);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(261, 20);
            this.middlenametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(91, 22);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(261, 20);
            this.firstnametxt.TabIndex = 1;
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Location = new System.Drawing.Point(9, 26);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(57, 13);
            this.firstnamelbl.TabIndex = 0;
            this.firstnamelbl.Text = "First Name";
            // 
            // orInitialTxt
            // 
            this.orInitialTxt.AutoSize = true;
            this.orInitialTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orInitialTxt.Location = new System.Drawing.Point(32, 61);
            this.orInitialTxt.Name = "orInitialTxt";
            this.orInitialTxt.Size = new System.Drawing.Size(48, 13);
            this.orInitialTxt.TabIndex = 6;
            this.orInitialTxt.Text = "(or initial)";
            // 
            // NameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxName);
            this.Name = "NameUserControl";
            this.Size = new System.Drawing.Size(361, 119);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.Label orInitialTxt;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.TextBox middlenametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label firstnamelbl;
    }
}
