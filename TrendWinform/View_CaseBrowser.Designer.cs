namespace TrendWinForm
{
    partial class View_CaseBrowser
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
            System.Windows.Forms.Label examiner_idLabel;
            System.Windows.Forms.Label requester_idLabel;
            System.Windows.Forms.Label firm_idLabel;
            System.Windows.Forms.Label caseNumberLabel;
            System.Windows.Forms.Label labelItemNumber;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_CaseBrowser));
            this.listViewListOfCases = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPageBack = new System.Windows.Forms.Button();
            this.buttonPageForward = new System.Windows.Forms.Button();
            this.buttonDeleteCase = new System.Windows.Forms.Button();
            this.buttonEditCase = new System.Windows.Forms.Button();
            this.buttonViewCase = new System.Windows.Forms.Button();
            this.buttonAddNewCase = new System.Windows.Forms.Button();
            this.groupBoxFilterSection = new System.Windows.Forms.GroupBox();
            this.textBoxItemNumber = new System.Windows.Forms.TextBox();
            this.textBoxCaseNumber = new System.Windows.Forms.TextBox();
            this.examiner_idComboBox = new System.Windows.Forms.ComboBox();
            this.requester_idComboBox = new System.Windows.Forms.ComboBox();
            this.firm_idComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDateBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMatterFilter = new System.Windows.Forms.TextBox();
            this.labelMatterFilter = new System.Windows.Forms.Label();
            examiner_idLabel = new System.Windows.Forms.Label();
            requester_idLabel = new System.Windows.Forms.Label();
            firm_idLabel = new System.Windows.Forms.Label();
            caseNumberLabel = new System.Windows.Forms.Label();
            labelItemNumber = new System.Windows.Forms.Label();
            this.groupBoxFilterSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // examiner_idLabel
            // 
            examiner_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            examiner_idLabel.AutoSize = true;
            examiner_idLabel.Location = new System.Drawing.Point(422, 66);
            examiner_idLabel.Name = "examiner_idLabel";
            examiner_idLabel.Size = new System.Drawing.Size(60, 15);
            examiner_idLabel.TabIndex = 26;
            examiner_idLabel.Text = "Examiner";
            // 
            // requester_idLabel
            // 
            requester_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            requester_idLabel.AutoSize = true;
            requester_idLabel.Location = new System.Drawing.Point(422, 42);
            requester_idLabel.Name = "requester_idLabel";
            requester_idLabel.Size = new System.Drawing.Size(64, 15);
            requester_idLabel.TabIndex = 25;
            requester_idLabel.Text = "Requester";
            // 
            // firm_idLabel
            // 
            firm_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            firm_idLabel.AutoSize = true;
            firm_idLabel.Location = new System.Drawing.Point(422, 17);
            firm_idLabel.Name = "firm_idLabel";
            firm_idLabel.Size = new System.Drawing.Size(32, 15);
            firm_idLabel.TabIndex = 23;
            firm_idLabel.Text = "Firm";
            // 
            // caseNumberLabel
            // 
            caseNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            caseNumberLabel.AutoSize = true;
            caseNumberLabel.Location = new System.Drawing.Point(4, 66);
            caseNumberLabel.Name = "caseNumberLabel";
            caseNumberLabel.Size = new System.Drawing.Size(83, 15);
            caseNumberLabel.TabIndex = 29;
            caseNumberLabel.Text = "Case Number";
            // 
            // labelItemNumber
            // 
            labelItemNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            labelItemNumber.AutoSize = true;
            labelItemNumber.Location = new System.Drawing.Point(4, 93);
            labelItemNumber.Name = "labelItemNumber";
            labelItemNumber.Size = new System.Drawing.Size(79, 15);
            labelItemNumber.TabIndex = 31;
            labelItemNumber.Text = "Item Number";
            // 
            // listViewListOfCases
            // 
            this.listViewListOfCases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewListOfCases.FullRowSelect = true;
            this.listViewListOfCases.Location = new System.Drawing.Point(9, 164);
            this.listViewListOfCases.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.listViewListOfCases.MultiSelect = false;
            this.listViewListOfCases.Name = "listViewListOfCases";
            this.listViewListOfCases.ShowItemToolTips = true;
            this.listViewListOfCases.Size = new System.Drawing.Size(1068, 554);
            this.listViewListOfCases.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewListOfCases.TabIndex = 2;
            this.listViewListOfCases.UseCompatibleStateImageBehavior = false;
            this.listViewListOfCases.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewListOfCases_ColumnClick);
            this.listViewListOfCases.SelectedIndexChanged += new System.EventHandler(this.listViewListOfCases_SelectedIndexChanged);
            // 
            // buttonSearchButton
            // 
            this.buttonSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchButton.Image = global::TrendWinForm.Properties.Resources.search;
            this.buttonSearchButton.Location = new System.Drawing.Point(9, 26);
            this.buttonSearchButton.Name = "buttonSearchButton";
            this.buttonSearchButton.Size = new System.Drawing.Size(147, 107);
            this.buttonSearchButton.TabIndex = 167;
            this.toolTip1.SetToolTip(this.buttonSearchButton, "Search Cases By Filters Entered");
            this.buttonSearchButton.UseVisualStyleBackColor = true;
            this.buttonSearchButton.Click += new System.EventHandler(this.buttonSearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 157;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 165;
            this.label2.Text = "Case Browser";
            // 
            // buttonPageBack
            // 
            this.buttonPageBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageBack.Enabled = false;
            this.buttonPageBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPageBack.Image = global::TrendWinForm.Properties.Resources.icon_forward_16;
            this.buttonPageBack.Location = new System.Drawing.Point(81, 138);
            this.buttonPageBack.Name = "buttonPageBack";
            this.buttonPageBack.Size = new System.Drawing.Size(24, 24);
            this.buttonPageBack.TabIndex = 163;
            this.buttonPageBack.UseVisualStyleBackColor = true;
            // 
            // buttonPageForward
            // 
            this.buttonPageForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageForward.Enabled = false;
            this.buttonPageForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonPageForward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPageForward.Image = ((System.Drawing.Image)(resources.GetObject("buttonPageForward.Image")));
            this.buttonPageForward.Location = new System.Drawing.Point(107, 138);
            this.buttonPageForward.Name = "buttonPageForward";
            this.buttonPageForward.Size = new System.Drawing.Size(24, 24);
            this.buttonPageForward.TabIndex = 162;
            this.buttonPageForward.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCase
            // 
            this.buttonDeleteCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCase.BackgroundImage")));
            this.buttonDeleteCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeleteCase.Location = new System.Drawing.Point(962, 138);
            this.buttonDeleteCase.Name = "buttonDeleteCase";
            this.buttonDeleteCase.Size = new System.Drawing.Size(24, 24);
            this.buttonDeleteCase.TabIndex = 161;
            this.buttonDeleteCase.UseVisualStyleBackColor = true;
            this.buttonDeleteCase.Click += new System.EventHandler(this.buttonDeleteCase_Click);
            // 
            // buttonEditCase
            // 
            this.buttonEditCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditCase.BackgroundImage")));
            this.buttonEditCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditCase.Location = new System.Drawing.Point(992, 138);
            this.buttonEditCase.Name = "buttonEditCase";
            this.buttonEditCase.Size = new System.Drawing.Size(24, 24);
            this.buttonEditCase.TabIndex = 160;
            this.buttonEditCase.UseVisualStyleBackColor = true;
            this.buttonEditCase.Click += new System.EventHandler(this.buttonEditCase_Click);
            // 
            // buttonViewCase
            // 
            this.buttonViewCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonViewCase.BackgroundImage")));
            this.buttonViewCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonViewCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonViewCase.Location = new System.Drawing.Point(1022, 138);
            this.buttonViewCase.Name = "buttonViewCase";
            this.buttonViewCase.Size = new System.Drawing.Size(24, 24);
            this.buttonViewCase.TabIndex = 159;
            this.buttonViewCase.UseVisualStyleBackColor = true;
            this.buttonViewCase.Click += new System.EventHandler(this.buttonViewCase_Click);
            // 
            // buttonAddNewCase
            // 
            this.buttonAddNewCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewCase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddNewCase.BackgroundImage")));
            this.buttonAddNewCase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddNewCase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddNewCase.Location = new System.Drawing.Point(1052, 138);
            this.buttonAddNewCase.Name = "buttonAddNewCase";
            this.buttonAddNewCase.Size = new System.Drawing.Size(24, 24);
            this.buttonAddNewCase.TabIndex = 158;
            this.buttonAddNewCase.UseVisualStyleBackColor = true;
            this.buttonAddNewCase.Click += new System.EventHandler(this.buttonAddNewCase_Click);
            // 
            // groupBoxFilterSection
            // 
            this.groupBoxFilterSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilterSection.Controls.Add(labelItemNumber);
            this.groupBoxFilterSection.Controls.Add(this.textBoxItemNumber);
            this.groupBoxFilterSection.Controls.Add(caseNumberLabel);
            this.groupBoxFilterSection.Controls.Add(this.textBoxCaseNumber);
            this.groupBoxFilterSection.Controls.Add(examiner_idLabel);
            this.groupBoxFilterSection.Controls.Add(this.examiner_idComboBox);
            this.groupBoxFilterSection.Controls.Add(requester_idLabel);
            this.groupBoxFilterSection.Controls.Add(this.requester_idComboBox);
            this.groupBoxFilterSection.Controls.Add(firm_idLabel);
            this.groupBoxFilterSection.Controls.Add(this.firm_idComboBox);
            this.groupBoxFilterSection.Controls.Add(this.label4);
            this.groupBoxFilterSection.Controls.Add(this.dateTimePickerStartDateEnd);
            this.groupBoxFilterSection.Controls.Add(this.dateTimePickerStartDateBegin);
            this.groupBoxFilterSection.Controls.Add(this.label3);
            this.groupBoxFilterSection.Controls.Add(this.textBoxMatterFilter);
            this.groupBoxFilterSection.Controls.Add(this.labelMatterFilter);
            this.groupBoxFilterSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilterSection.Location = new System.Drawing.Point(163, 21);
            this.groupBoxFilterSection.Name = "groupBoxFilterSection";
            this.groupBoxFilterSection.Size = new System.Drawing.Size(914, 113);
            this.groupBoxFilterSection.TabIndex = 168;
            this.groupBoxFilterSection.TabStop = false;
            this.groupBoxFilterSection.Text = "Filter ";
            // 
            // textBoxItemNumber
            // 
            this.textBoxItemNumber.Location = new System.Drawing.Point(117, 88);
            this.textBoxItemNumber.Name = "textBoxItemNumber";
            this.textBoxItemNumber.Size = new System.Drawing.Size(301, 21);
            this.textBoxItemNumber.TabIndex = 32;
            // 
            // textBoxCaseNumber
            // 
            this.textBoxCaseNumber.Location = new System.Drawing.Point(117, 63);
            this.textBoxCaseNumber.Name = "textBoxCaseNumber";
            this.textBoxCaseNumber.Size = new System.Drawing.Size(301, 21);
            this.textBoxCaseNumber.TabIndex = 30;
            // 
            // examiner_idComboBox
            // 
            this.examiner_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examiner_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examiner_idComboBox.FormattingEnabled = true;
            this.examiner_idComboBox.Location = new System.Drawing.Point(489, 62);
            this.examiner_idComboBox.Name = "examiner_idComboBox";
            this.examiner_idComboBox.Size = new System.Drawing.Size(419, 23);
            this.examiner_idComboBox.TabIndex = 28;
            // 
            // requester_idComboBox
            // 
            this.requester_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requester_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requester_idComboBox.FormattingEnabled = true;
            this.requester_idComboBox.Location = new System.Drawing.Point(489, 38);
            this.requester_idComboBox.Name = "requester_idComboBox";
            this.requester_idComboBox.Size = new System.Drawing.Size(419, 23);
            this.requester_idComboBox.TabIndex = 27;
            // 
            // firm_idComboBox
            // 
            this.firm_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firm_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firm_idComboBox.FormattingEnabled = true;
            this.firm_idComboBox.Location = new System.Drawing.Point(489, 13);
            this.firm_idComboBox.Name = "firm_idComboBox";
            this.firm_idComboBox.Size = new System.Drawing.Size(419, 23);
            this.firm_idComboBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "and";
            // 
            // dateTimePickerStartDateEnd
            // 
            this.dateTimePickerStartDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDateEnd.Location = new System.Drawing.Point(293, 39);
            this.dateTimePickerStartDateEnd.Name = "dateTimePickerStartDateEnd";
            this.dateTimePickerStartDateEnd.Size = new System.Drawing.Size(125, 21);
            this.dateTimePickerStartDateEnd.TabIndex = 6;
            // 
            // dateTimePickerStartDateBegin
            // 
            this.dateTimePickerStartDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDateBegin.Location = new System.Drawing.Point(117, 39);
            this.dateTimePickerStartDateBegin.Name = "dateTimePickerStartDateBegin";
            this.dateTimePickerStartDateBegin.Size = new System.Drawing.Size(136, 21);
            this.dateTimePickerStartDateBegin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date Between";
            // 
            // textBoxMatterFilter
            // 
            this.textBoxMatterFilter.Location = new System.Drawing.Point(117, 14);
            this.textBoxMatterFilter.Name = "textBoxMatterFilter";
            this.textBoxMatterFilter.Size = new System.Drawing.Size(301, 21);
            this.textBoxMatterFilter.TabIndex = 3;
            // 
            // labelMatterFilter
            // 
            this.labelMatterFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMatterFilter.AutoSize = true;
            this.labelMatterFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatterFilter.Location = new System.Drawing.Point(4, 17);
            this.labelMatterFilter.Name = "labelMatterFilter";
            this.labelMatterFilter.Size = new System.Drawing.Size(42, 15);
            this.labelMatterFilter.TabIndex = 2;
            this.labelMatterFilter.Text = "Matter";
            // 
            // View_CaseBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 730);
            this.Controls.Add(this.groupBoxFilterSection);
            this.Controls.Add(this.buttonSearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPageBack);
            this.Controls.Add(this.buttonPageForward);
            this.Controls.Add(this.buttonDeleteCase);
            this.Controls.Add(this.buttonEditCase);
            this.Controls.Add(this.buttonViewCase);
            this.Controls.Add(this.buttonAddNewCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewListOfCases);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View_CaseBrowser";
            this.Opacity = 0.7D;
            this.Text = "CaseBrowser";
            this.Load += new System.EventHandler(this.View_CaseBrowser_Load);
            this.groupBoxFilterSection.ResumeLayout(false);
            this.groupBoxFilterSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewListOfCases;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteCase;
        private System.Windows.Forms.Button buttonEditCase;
        private System.Windows.Forms.Button buttonViewCase;
        private System.Windows.Forms.Button buttonAddNewCase;
        private System.Windows.Forms.Button buttonPageBack;
        private System.Windows.Forms.Button buttonPageForward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchButton;
        private System.Windows.Forms.GroupBox groupBoxFilterSection;
        private System.Windows.Forms.TextBox textBoxMatterFilter;
        private System.Windows.Forms.Label labelMatterFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDateBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox examiner_idComboBox;
        private System.Windows.Forms.ComboBox requester_idComboBox;
        private System.Windows.Forms.ComboBox firm_idComboBox;
        private System.Windows.Forms.TextBox textBoxCaseNumber;
        private System.Windows.Forms.TextBox textBoxItemNumber;


    }
}