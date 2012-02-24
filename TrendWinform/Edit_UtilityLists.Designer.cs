namespace TrendWinForm
{
    partial class Edit_UtilityLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_UtilityLists));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.labelCurrentList = new System.Windows.Forms.Label();
            this.listBoxUtilityListItems = new System.Windows.Forms.ListBox();
            this.textBoxListItemToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddItemToList = new System.Windows.Forms.Button();
            this.buttonSubtractItemFromList = new System.Windows.Forms.Button();
            this.textBoxItemToDelete = new System.Windows.Forms.TextBox();
            this.labelLengthOfList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 682);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(464, 38);
            this.panel1.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CancelButton.Location = new System.Drawing.Point(5, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(2);
            this.CancelButton.Size = new System.Drawing.Size(221, 28);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Location = new System.Drawing.Point(232, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(2);
            this.SaveButton.Size = new System.Drawing.Size(227, 28);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // labelCurrentList
            // 
            this.labelCurrentList.AutoSize = true;
            this.labelCurrentList.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentList.Location = new System.Drawing.Point(9, 19);
            this.labelCurrentList.Name = "labelCurrentList";
            this.labelCurrentList.Size = new System.Drawing.Size(107, 24);
            this.labelCurrentList.TabIndex = 156;
            this.labelCurrentList.Text = "Current List";
            // 
            // listBoxUtilityListItems
            // 
            this.listBoxUtilityListItems.FormattingEnabled = true;
            this.listBoxUtilityListItems.Location = new System.Drawing.Point(12, 41);
            this.listBoxUtilityListItems.Name = "listBoxUtilityListItems";
            this.listBoxUtilityListItems.Size = new System.Drawing.Size(440, 576);
            this.listBoxUtilityListItems.TabIndex = 157;
            this.listBoxUtilityListItems.SelectedIndexChanged += new System.EventHandler(this.listBoxUtilityListItems_SelectedIndexChanged);
            // 
            // textBoxListItemToAdd
            // 
            this.textBoxListItemToAdd.Location = new System.Drawing.Point(42, 633);
            this.textBoxListItemToAdd.Name = "textBoxListItemToAdd";
            this.textBoxListItemToAdd.Size = new System.Drawing.Size(410, 20);
            this.textBoxListItemToAdd.TabIndex = 1;
            // 
            // buttonAddItemToList
            // 
            this.buttonAddItemToList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddItemToList.BackgroundImage")));
            this.buttonAddItemToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddItemToList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddItemToList.Location = new System.Drawing.Point(12, 633);
            this.buttonAddItemToList.Name = "buttonAddItemToList";
            this.buttonAddItemToList.Size = new System.Drawing.Size(24, 24);
            this.buttonAddItemToList.TabIndex = 159;
            this.buttonAddItemToList.UseVisualStyleBackColor = true;
            this.buttonAddItemToList.Click += new System.EventHandler(this.buttonAddItemToList_Click);
            // 
            // buttonSubtractItemFromList
            // 
            this.buttonSubtractItemFromList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSubtractItemFromList.BackgroundImage")));
            this.buttonSubtractItemFromList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSubtractItemFromList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSubtractItemFromList.Location = new System.Drawing.Point(12, 657);
            this.buttonSubtractItemFromList.Name = "buttonSubtractItemFromList";
            this.buttonSubtractItemFromList.Size = new System.Drawing.Size(24, 24);
            this.buttonSubtractItemFromList.TabIndex = 160;
            this.buttonSubtractItemFromList.UseVisualStyleBackColor = true;
            this.buttonSubtractItemFromList.Click += new System.EventHandler(this.buttonSubtractItemFromList_Click);
            // 
            // textBoxItemToDelete
            // 
            this.textBoxItemToDelete.Location = new System.Drawing.Point(42, 657);
            this.textBoxItemToDelete.Name = "textBoxItemToDelete";
            this.textBoxItemToDelete.ReadOnly = true;
            this.textBoxItemToDelete.Size = new System.Drawing.Size(410, 20);
            this.textBoxItemToDelete.TabIndex = 2;
            // 
            // labelLengthOfList
            // 
            this.labelLengthOfList.Location = new System.Drawing.Point(265, 27);
            this.labelLengthOfList.Name = "labelLengthOfList";
            this.labelLengthOfList.Size = new System.Drawing.Size(185, 13);
            this.labelLengthOfList.TabIndex = 162;
            this.labelLengthOfList.Text = "-";
            this.labelLengthOfList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Edit_UtilityLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 720);
            this.Controls.Add(this.labelLengthOfList);
            this.Controls.Add(this.textBoxItemToDelete);
            this.Controls.Add(this.buttonSubtractItemFromList);
            this.Controls.Add(this.buttonAddItemToList);
            this.Controls.Add(this.textBoxListItemToAdd);
            this.Controls.Add(this.listBoxUtilityListItems);
            this.Controls.Add(this.labelCurrentList);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_UtilityLists";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Edit List";
            this.Shown += new System.EventHandler(this.Edit_UtilityLists_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label labelCurrentList;
        private System.Windows.Forms.ListBox listBoxUtilityListItems;
        private System.Windows.Forms.TextBox textBoxListItemToAdd;
        private System.Windows.Forms.Button buttonAddItemToList;
        private System.Windows.Forms.Button buttonSubtractItemFromList;
        private System.Windows.Forms.TextBox textBoxItemToDelete;
        private System.Windows.Forms.Label labelLengthOfList;
    }
}