﻿namespace FiltersUI
{
    partial class MainForm
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
            this.configTabControl = new System.Windows.Forms.TabControl();
            this.generalConfigPage = new System.Windows.Forms.TabPage();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.startFilteringButton = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.whiteListPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.addItemToWhiteListButton = new System.Windows.Forms.Button();
            this.newWhiteItemTextBox = new System.Windows.Forms.TextBox();
            this.whiteFilterListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whiteFilterFileButton = new System.Windows.Forms.Button();
            this.filterConfigLabel = new System.Windows.Forms.Label();
            this.whiteListConfigFileTextBox = new System.Windows.Forms.TextBox();
            this.blackListTabPage = new System.Windows.Forms.TabPage();
            this.blackListSaveButton = new System.Windows.Forms.Button();
            this.addBlackListItemButton = new System.Windows.Forms.Button();
            this.newBlackListItemTextBox = new System.Windows.Forms.TextBox();
            this.blackListItemsListBox = new System.Windows.Forms.ListBox();
            this.blackListGroupBox = new System.Windows.Forms.GroupBox();
            this.blackListBrowseButton = new System.Windows.Forms.Button();
            this.blackListConfigLabel = new System.Windows.Forms.Label();
            this.blackListConfigPathTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filterListControl1 = new FiltersUI.FilterListControl();
            this.configTabControl.SuspendLayout();
            this.generalConfigPage.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.whiteListPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.blackListTabPage.SuspendLayout();
            this.blackListGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // configTabControl
            // 
            this.configTabControl.Controls.Add(this.generalConfigPage);
            this.configTabControl.Controls.Add(this.whiteListPage);
            this.configTabControl.Controls.Add(this.blackListTabPage);
            this.configTabControl.Controls.Add(this.tabPage1);
            this.configTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedIndex = 0;
            this.configTabControl.Size = new System.Drawing.Size(724, 425);
            this.configTabControl.TabIndex = 0;
            // 
            // generalConfigPage
            // 
            this.generalConfigPage.Controls.Add(this.filesGroupBox);
            this.generalConfigPage.Location = new System.Drawing.Point(4, 22);
            this.generalConfigPage.Name = "generalConfigPage";
            this.generalConfigPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalConfigPage.Size = new System.Drawing.Size(716, 399);
            this.generalConfigPage.TabIndex = 0;
            this.generalConfigPage.Text = "Options";
            this.generalConfigPage.UseVisualStyleBackColor = true;
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.startFilteringButton);
            this.filesGroupBox.Controls.Add(this.browseOutputButton);
            this.filesGroupBox.Controls.Add(this.browseInputButton);
            this.filesGroupBox.Controls.Add(this.label2);
            this.filesGroupBox.Controls.Add(this.label1);
            this.filesGroupBox.Controls.Add(this.outputFileTextBox);
            this.filesGroupBox.Controls.Add(this.inputFileTextBox);
            this.filesGroupBox.Location = new System.Drawing.Point(3, 6);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(334, 180);
            this.filesGroupBox.TabIndex = 0;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "I/O Settings";
            // 
            // startFilteringButton
            // 
            this.startFilteringButton.Location = new System.Drawing.Point(91, 118);
            this.startFilteringButton.Name = "startFilteringButton";
            this.startFilteringButton.Size = new System.Drawing.Size(163, 23);
            this.startFilteringButton.TabIndex = 6;
            this.startFilteringButton.Text = "Just do it!";
            this.startFilteringButton.UseVisualStyleBackColor = true;
            this.startFilteringButton.Click += new System.EventHandler(this.startFilteringButton_Click);
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Location = new System.Drawing.Point(207, 44);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(75, 20);
            this.browseOutputButton.TabIndex = 5;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // browseInputButton
            // 
            this.browseInputButton.Location = new System.Drawing.Point(207, 18);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(75, 20);
            this.browseInputButton.TabIndex = 4;
            this.browseInputButton.Text = "Browse";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File:";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(80, 44);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.ReadOnly = true;
            this.outputFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputFileTextBox.TabIndex = 1;
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(80, 18);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.ReadOnly = true;
            this.inputFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputFileTextBox.TabIndex = 0;
            // 
            // whiteListPage
            // 
            this.whiteListPage.Controls.Add(this.button1);
            this.whiteListPage.Controls.Add(this.addItemToWhiteListButton);
            this.whiteListPage.Controls.Add(this.newWhiteItemTextBox);
            this.whiteListPage.Controls.Add(this.whiteFilterListBox);
            this.whiteListPage.Controls.Add(this.groupBox1);
            this.whiteListPage.Location = new System.Drawing.Point(4, 22);
            this.whiteListPage.Name = "whiteListPage";
            this.whiteListPage.Padding = new System.Windows.Forms.Padding(3);
            this.whiteListPage.Size = new System.Drawing.Size(716, 399);
            this.whiteListPage.TabIndex = 1;
            this.whiteListPage.Text = "White list";
            this.whiteListPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addItemToWhiteListButton
            // 
            this.addItemToWhiteListButton.Enabled = false;
            this.addItemToWhiteListButton.Location = new System.Drawing.Point(638, 20);
            this.addItemToWhiteListButton.Name = "addItemToWhiteListButton";
            this.addItemToWhiteListButton.Size = new System.Drawing.Size(20, 20);
            this.addItemToWhiteListButton.TabIndex = 4;
            this.addItemToWhiteListButton.Text = "+";
            this.addItemToWhiteListButton.UseVisualStyleBackColor = true;
            this.addItemToWhiteListButton.Click += new System.EventHandler(this.addItemToListButton_Click);
            // 
            // newWhiteItemTextBox
            // 
            this.newWhiteItemTextBox.Location = new System.Drawing.Point(447, 20);
            this.newWhiteItemTextBox.Name = "newWhiteItemTextBox";
            this.newWhiteItemTextBox.Size = new System.Drawing.Size(174, 20);
            this.newWhiteItemTextBox.TabIndex = 3;
            this.newWhiteItemTextBox.TextChanged += new System.EventHandler(this.newWhiteItemTextBox_TextChanged);
            // 
            // whiteFilterListBox
            // 
            this.whiteFilterListBox.FormattingEnabled = true;
            this.whiteFilterListBox.Location = new System.Drawing.Point(447, 58);
            this.whiteFilterListBox.Name = "whiteFilterListBox";
            this.whiteFilterListBox.Size = new System.Drawing.Size(174, 303);
            this.whiteFilterListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whiteFilterFileButton);
            this.groupBox1.Controls.Add(this.filterConfigLabel);
            this.groupBox1.Controls.Add(this.whiteListConfigFileTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "White List Settings";
            // 
            // whiteFilterFileButton
            // 
            this.whiteFilterFileButton.Location = new System.Drawing.Point(208, 19);
            this.whiteFilterFileButton.Name = "whiteFilterFileButton";
            this.whiteFilterFileButton.Size = new System.Drawing.Size(75, 20);
            this.whiteFilterFileButton.TabIndex = 7;
            this.whiteFilterFileButton.Text = "Browse";
            this.whiteFilterFileButton.UseVisualStyleBackColor = true;
            this.whiteFilterFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterConfigLabel
            // 
            this.filterConfigLabel.AutoSize = true;
            this.filterConfigLabel.Location = new System.Drawing.Point(6, 22);
            this.filterConfigLabel.Name = "filterConfigLabel";
            this.filterConfigLabel.Size = new System.Drawing.Size(59, 13);
            this.filterConfigLabel.TabIndex = 6;
            this.filterConfigLabel.Text = "Config File:";
            // 
            // whiteListConfigFileTextBox
            // 
            this.whiteListConfigFileTextBox.Location = new System.Drawing.Point(81, 19);
            this.whiteListConfigFileTextBox.Name = "whiteListConfigFileTextBox";
            this.whiteListConfigFileTextBox.ReadOnly = true;
            this.whiteListConfigFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.whiteListConfigFileTextBox.TabIndex = 5;
            // 
            // blackListTabPage
            // 
            this.blackListTabPage.Controls.Add(this.blackListSaveButton);
            this.blackListTabPage.Controls.Add(this.addBlackListItemButton);
            this.blackListTabPage.Controls.Add(this.newBlackListItemTextBox);
            this.blackListTabPage.Controls.Add(this.blackListItemsListBox);
            this.blackListTabPage.Controls.Add(this.blackListGroupBox);
            this.blackListTabPage.Location = new System.Drawing.Point(4, 22);
            this.blackListTabPage.Name = "blackListTabPage";
            this.blackListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.blackListTabPage.Size = new System.Drawing.Size(716, 399);
            this.blackListTabPage.TabIndex = 2;
            this.blackListTabPage.Text = "Black List";
            this.blackListTabPage.UseVisualStyleBackColor = true;
            // 
            // blackListSaveButton
            // 
            this.blackListSaveButton.Location = new System.Drawing.Point(643, 44);
            this.blackListSaveButton.Name = "blackListSaveButton";
            this.blackListSaveButton.Size = new System.Drawing.Size(70, 23);
            this.blackListSaveButton.TabIndex = 10;
            this.blackListSaveButton.Text = "Save";
            this.blackListSaveButton.UseVisualStyleBackColor = true;
            // 
            // addBlackListItemButton
            // 
            this.addBlackListItemButton.Enabled = false;
            this.addBlackListItemButton.Location = new System.Drawing.Point(643, 6);
            this.addBlackListItemButton.Name = "addBlackListItemButton";
            this.addBlackListItemButton.Size = new System.Drawing.Size(20, 20);
            this.addBlackListItemButton.TabIndex = 9;
            this.addBlackListItemButton.Text = "+";
            this.addBlackListItemButton.UseVisualStyleBackColor = true;
            // 
            // newBlackListItemTextBox
            // 
            this.newBlackListItemTextBox.Location = new System.Drawing.Point(452, 6);
            this.newBlackListItemTextBox.Name = "newBlackListItemTextBox";
            this.newBlackListItemTextBox.Size = new System.Drawing.Size(174, 20);
            this.newBlackListItemTextBox.TabIndex = 8;
            // 
            // blackListItemsListBox
            // 
            this.blackListItemsListBox.FormattingEnabled = true;
            this.blackListItemsListBox.Location = new System.Drawing.Point(452, 44);
            this.blackListItemsListBox.Name = "blackListItemsListBox";
            this.blackListItemsListBox.Size = new System.Drawing.Size(174, 303);
            this.blackListItemsListBox.TabIndex = 7;
            // 
            // blackListGroupBox
            // 
            this.blackListGroupBox.Controls.Add(this.blackListBrowseButton);
            this.blackListGroupBox.Controls.Add(this.blackListConfigLabel);
            this.blackListGroupBox.Controls.Add(this.blackListConfigPathTextBox);
            this.blackListGroupBox.Location = new System.Drawing.Point(6, 22);
            this.blackListGroupBox.Name = "blackListGroupBox";
            this.blackListGroupBox.Size = new System.Drawing.Size(353, 135);
            this.blackListGroupBox.TabIndex = 6;
            this.blackListGroupBox.TabStop = false;
            this.blackListGroupBox.Text = "Black List Settings";
            // 
            // blackListBrowseButton
            // 
            this.blackListBrowseButton.Location = new System.Drawing.Point(208, 19);
            this.blackListBrowseButton.Name = "blackListBrowseButton";
            this.blackListBrowseButton.Size = new System.Drawing.Size(75, 20);
            this.blackListBrowseButton.TabIndex = 7;
            this.blackListBrowseButton.Text = "Browse";
            this.blackListBrowseButton.UseVisualStyleBackColor = true;
            // 
            // blackListConfigLabel
            // 
            this.blackListConfigLabel.AutoSize = true;
            this.blackListConfigLabel.Location = new System.Drawing.Point(6, 22);
            this.blackListConfigLabel.Name = "blackListConfigLabel";
            this.blackListConfigLabel.Size = new System.Drawing.Size(59, 13);
            this.blackListConfigLabel.TabIndex = 6;
            this.blackListConfigLabel.Text = "Config File:";
            // 
            // blackListConfigPathTextBox
            // 
            this.blackListConfigPathTextBox.Location = new System.Drawing.Point(81, 19);
            this.blackListConfigPathTextBox.Name = "blackListConfigPathTextBox";
            this.blackListConfigPathTextBox.ReadOnly = true;
            this.blackListConfigPathTextBox.Size = new System.Drawing.Size(100, 20);
            this.blackListConfigPathTextBox.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterListControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 399);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filterListControl1
            // 
            this.filterListControl1.Location = new System.Drawing.Point(1, 7);
            this.filterListControl1.Name = "filterListControl1";
            this.filterListControl1.Size = new System.Drawing.Size(712, 384);
            this.filterListControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 425);
            this.Controls.Add(this.configTabControl);
            this.Name = "MainForm";
            this.Text = "Filters";
            this.configTabControl.ResumeLayout(false);
            this.generalConfigPage.ResumeLayout(false);
            this.filesGroupBox.ResumeLayout(false);
            this.filesGroupBox.PerformLayout();
            this.whiteListPage.ResumeLayout(false);
            this.whiteListPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.blackListTabPage.ResumeLayout(false);
            this.blackListTabPage.PerformLayout();
            this.blackListGroupBox.ResumeLayout(false);
            this.blackListGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage whiteListPage;
        private System.Windows.Forms.TabPage generalConfigPage;
        private System.Windows.Forms.TabControl configTabControl;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.Button startFilteringButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button whiteFilterFileButton;
        private System.Windows.Forms.Label filterConfigLabel;
        private System.Windows.Forms.TextBox whiteListConfigFileTextBox;
        private System.Windows.Forms.ListBox whiteFilterListBox;
        private System.Windows.Forms.Button addItemToWhiteListButton;
        private System.Windows.Forms.TextBox newWhiteItemTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage blackListTabPage;
        private System.Windows.Forms.Button blackListSaveButton;
        private System.Windows.Forms.Button addBlackListItemButton;
        private System.Windows.Forms.TextBox newBlackListItemTextBox;
        private System.Windows.Forms.ListBox blackListItemsListBox;
        private System.Windows.Forms.GroupBox blackListGroupBox;
        private System.Windows.Forms.Button blackListBrowseButton;
        private System.Windows.Forms.Label blackListConfigLabel;
        private System.Windows.Forms.TextBox blackListConfigPathTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private FilterListControl filterListControl1;
    }
}

