namespace TrendCustromControls
{
    partial class AddressUserControl
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
            this.stateCombo = new System.Windows.Forms.ComboBox();
            this.zipcodelbl = new System.Windows.Forms.Label();
            this.statelbl = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.zipcodetxt = new System.Windows.Forms.MaskedTextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.street2txt = new System.Windows.Forms.TextBox();
            this.street2lbl = new System.Windows.Forms.Label();
            this.street1txt = new System.Windows.Forms.TextBox();
            this.street1lbl = new System.Windows.Forms.Label();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.FormattingEnabled = true;
            this.stateCombo.Location = new System.Drawing.Point(60, 98);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(248, 21);
            this.stateCombo.TabIndex = 10;
            // 
            // zipcodelbl
            // 
            this.zipcodelbl.AutoSize = true;
            this.zipcodelbl.Location = new System.Drawing.Point(314, 102);
            this.zipcodelbl.Name = "zipcodelbl";
            this.zipcodelbl.Size = new System.Drawing.Size(50, 13);
            this.zipcodelbl.TabIndex = 8;
            this.zipcodelbl.Text = "Zip Code";
            // 
            // statelbl
            // 
            this.statelbl.AutoSize = true;
            this.statelbl.Location = new System.Drawing.Point(7, 102);
            this.statelbl.Name = "statelbl";
            this.statelbl.Size = new System.Drawing.Size(32, 13);
            this.statelbl.TabIndex = 6;
            this.statelbl.Text = "State";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.zipcodetxt);
            this.groupBoxAddress.Controls.Add(this.stateCombo);
            this.groupBoxAddress.Controls.Add(this.zipcodelbl);
            this.groupBoxAddress.Controls.Add(this.statelbl);
            this.groupBoxAddress.Controls.Add(this.citytxt);
            this.groupBoxAddress.Controls.Add(this.citylbl);
            this.groupBoxAddress.Controls.Add(this.street2txt);
            this.groupBoxAddress.Controls.Add(this.street2lbl);
            this.groupBoxAddress.Controls.Add(this.street1txt);
            this.groupBoxAddress.Controls.Add(this.street1lbl);
            this.groupBoxAddress.Location = new System.Drawing.Point(4, 2);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(523, 129);
            this.groupBoxAddress.TabIndex = 1;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // zipcodetxt
            // 
            this.zipcodetxt.Location = new System.Drawing.Point(371, 98);
            this.zipcodetxt.Mask = "00000";
            this.zipcodetxt.Name = "zipcodetxt";
            this.zipcodetxt.PromptChar = ' ';
            this.zipcodetxt.Size = new System.Drawing.Size(146, 20);
            this.zipcodetxt.TabIndex = 11;
            this.zipcodetxt.ValidatingType = typeof(int);
            this.zipcodetxt.Enter += new System.EventHandler(this.ueTxtAny_Enter);
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(60, 71);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(457, 20);
            this.citytxt.TabIndex = 5;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(7, 76);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(24, 13);
            this.citylbl.TabIndex = 4;
            this.citylbl.Text = "City";
            // 
            // street2txt
            // 
            this.street2txt.Location = new System.Drawing.Point(60, 43);
            this.street2txt.Name = "street2txt";
            this.street2txt.Size = new System.Drawing.Size(457, 20);
            this.street2txt.TabIndex = 3;
            // 
            // street2lbl
            // 
            this.street2lbl.AutoSize = true;
            this.street2lbl.Location = new System.Drawing.Point(7, 49);
            this.street2lbl.Name = "street2lbl";
            this.street2lbl.Size = new System.Drawing.Size(44, 13);
            this.street2lbl.TabIndex = 2;
            this.street2lbl.Text = "Street 2";
            // 
            // street1txt
            // 
            this.street1txt.Location = new System.Drawing.Point(60, 15);
            this.street1txt.Name = "street1txt";
            this.street1txt.Size = new System.Drawing.Size(457, 20);
            this.street1txt.TabIndex = 1;
            // 
            // street1lbl
            // 
            this.street1lbl.AutoSize = true;
            this.street1lbl.Location = new System.Drawing.Point(7, 22);
            this.street1lbl.Name = "street1lbl";
            this.street1lbl.Size = new System.Drawing.Size(44, 13);
            this.street1lbl.TabIndex = 0;
            this.street1lbl.Text = "Street 1";
            // 
            // AddressUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddress);
            this.Name = "AddressUserControl";
            this.Size = new System.Drawing.Size(536, 139);
            this.Load += new System.EventHandler(this.AddressUserControl_Load);
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox stateCombo;
        private System.Windows.Forms.Label zipcodelbl;
        private System.Windows.Forms.Label statelbl;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.TextBox street2txt;
        private System.Windows.Forms.Label street2lbl;
        private System.Windows.Forms.TextBox street1txt;
        private System.Windows.Forms.Label street1lbl;
        private System.Windows.Forms.MaskedTextBox zipcodetxt;
    }
}
