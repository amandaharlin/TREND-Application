namespace TrendWinForm
{
    partial class Create_DestinationMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_DestinationMedia));
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonAddBrandType = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDestinationMedia = new System.Windows.Forms.ComboBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.labelDestinationMediaSeroalNum = new System.Windows.Forms.Label();
            this.textBoxSizeOutput = new System.Windows.Forms.TextBox();
            this.labelDestinationMediaSize = new System.Windows.Forms.Label();
            this.labelDestinationMediaBrand = new System.Windows.Forms.Label();
            this.labelDestinationMedia = new System.Windows.Forms.Label();
            this.labelDestinationMediaInfo = new System.Windows.Forms.Label();
            this.comboBoxBrandOutput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.comboBoxBrandOutput);
            this.panel11.Controls.Add(this.buttonAddBrandType);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Controls.Add(this.comboBoxDestinationMedia);
            this.panel11.Controls.Add(this.textBoxSerialNumber);
            this.panel11.Controls.Add(this.labelDestinationMediaSeroalNum);
            this.panel11.Controls.Add(this.textBoxSizeOutput);
            this.panel11.Controls.Add(this.labelDestinationMediaSize);
            this.panel11.Controls.Add(this.labelDestinationMediaBrand);
            this.panel11.Controls.Add(this.labelDestinationMedia);
            this.panel11.Controls.Add(this.labelDestinationMediaInfo);
            this.panel11.Location = new System.Drawing.Point(0, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(566, 141);
            this.panel11.TabIndex = 208;
            // 
            // buttonAddBrandType
            // 
            this.buttonAddBrandType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddBrandType.BackgroundImage")));
            this.buttonAddBrandType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddBrandType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddBrandType.Location = new System.Drawing.Point(414, 59);
            this.buttonAddBrandType.Name = "buttonAddBrandType";
            this.buttonAddBrandType.Size = new System.Drawing.Size(24, 24);
            this.buttonAddBrandType.TabIndex = 213;
            this.buttonAddBrandType.UseVisualStyleBackColor = true;
            this.buttonAddBrandType.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(444, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 92);
            this.pictureBox1.TabIndex = 212;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDestinationMedia
            // 
            this.comboBoxDestinationMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestinationMedia.FormattingEnabled = true;
            this.comboBoxDestinationMedia.Location = new System.Drawing.Point(107, 37);
            this.comboBoxDestinationMedia.Name = "comboBoxDestinationMedia";
            this.comboBoxDestinationMedia.Size = new System.Drawing.Size(331, 21);
            this.comboBoxDestinationMedia.TabIndex = 201;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(107, 109);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(331, 20);
            this.textBoxSerialNumber.TabIndex = 204;
            // 
            // labelDestinationMediaSeroalNum
            // 
            this.labelDestinationMediaSeroalNum.AutoSize = true;
            this.labelDestinationMediaSeroalNum.Location = new System.Drawing.Point(6, 113);
            this.labelDestinationMediaSeroalNum.Name = "labelDestinationMediaSeroalNum";
            this.labelDestinationMediaSeroalNum.Size = new System.Drawing.Size(73, 13);
            this.labelDestinationMediaSeroalNum.TabIndex = 205;
            this.labelDestinationMediaSeroalNum.Text = "Serial Number";
            // 
            // textBoxSizeOutput
            // 
            this.textBoxSizeOutput.Location = new System.Drawing.Point(107, 84);
            this.textBoxSizeOutput.Name = "textBoxSizeOutput";
            this.textBoxSizeOutput.Size = new System.Drawing.Size(331, 20);
            this.textBoxSizeOutput.TabIndex = 203;
            this.textBoxSizeOutput.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSizeOutput_Validating);
            // 
            // labelDestinationMediaSize
            // 
            this.labelDestinationMediaSize.AutoSize = true;
            this.labelDestinationMediaSize.Location = new System.Drawing.Point(6, 90);
            this.labelDestinationMediaSize.Name = "labelDestinationMediaSize";
            this.labelDestinationMediaSize.Size = new System.Drawing.Size(27, 13);
            this.labelDestinationMediaSize.TabIndex = 203;
            this.labelDestinationMediaSize.Text = "Size";
            // 
            // labelDestinationMediaBrand
            // 
            this.labelDestinationMediaBrand.AutoSize = true;
            this.labelDestinationMediaBrand.Location = new System.Drawing.Point(6, 64);
            this.labelDestinationMediaBrand.Name = "labelDestinationMediaBrand";
            this.labelDestinationMediaBrand.Size = new System.Drawing.Size(35, 13);
            this.labelDestinationMediaBrand.TabIndex = 201;
            this.labelDestinationMediaBrand.Text = "Brand";
            // 
            // labelDestinationMedia
            // 
            this.labelDestinationMedia.AutoSize = true;
            this.labelDestinationMedia.Location = new System.Drawing.Point(6, 41);
            this.labelDestinationMedia.Name = "labelDestinationMedia";
            this.labelDestinationMedia.Size = new System.Drawing.Size(92, 13);
            this.labelDestinationMedia.TabIndex = 199;
            this.labelDestinationMedia.Text = "Destination Media";
            // 
            // labelDestinationMediaInfo
            // 
            this.labelDestinationMediaInfo.AutoSize = true;
            this.labelDestinationMediaInfo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestinationMediaInfo.Location = new System.Drawing.Point(3, 4);
            this.labelDestinationMediaInfo.Name = "labelDestinationMediaInfo";
            this.labelDestinationMediaInfo.Size = new System.Drawing.Size(201, 24);
            this.labelDestinationMediaInfo.TabIndex = 198;
            this.labelDestinationMediaInfo.Text = "Destination Media Info";
            // 
            // comboBoxBrandOutput
            // 
            this.comboBoxBrandOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrandOutput.FormattingEnabled = true;
            this.comboBoxBrandOutput.Location = new System.Drawing.Point(108, 60);
            this.comboBoxBrandOutput.Name = "comboBoxBrandOutput";
            this.comboBoxBrandOutput.Size = new System.Drawing.Size(300, 21);
            this.comboBoxBrandOutput.TabIndex = 214;
            // 
            // Create_DestinationMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 191);
            this.Controls.Add(this.panel11);
            this.Name = "Create_DestinationMedia";
            this.Text = "Create_DestinationMedia";
            this.Controls.SetChildIndex(this.panel11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBoxDestinationMedia;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label labelDestinationMediaSeroalNum;
        private System.Windows.Forms.Label labelDestinationMediaSize;
        private System.Windows.Forms.Label labelDestinationMediaBrand;
        private System.Windows.Forms.Label labelDestinationMedia;
        private System.Windows.Forms.Label labelDestinationMediaInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSizeOutput;
        private System.Windows.Forms.Button buttonAddBrandType;
        private System.Windows.Forms.ComboBox comboBoxBrandOutput;
    }
}