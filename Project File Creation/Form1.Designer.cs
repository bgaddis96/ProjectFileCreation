namespace Project_File_Creation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.executegroupBox = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.infogroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstTextbox = new System.Windows.Forms.TextBox();
            this.lastTextbox = new System.Windows.Forms.TextBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttongroupBox = new System.Windows.Forms.GroupBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.dockButton = new System.Windows.Forms.Button();
            this.wallButton = new System.Windows.Forms.Button();
            this.dockwallButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dredgeButton = new System.Windows.Forms.Button();
            this.quoteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lakeCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.executegroupBox.SuspendLayout();
            this.infogroupBox.SuspendLayout();
            this.buttongroupBox.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.executegroupBox);
            this.panel1.Controls.Add(this.infogroupBox);
            this.panel1.Controls.Add(this.buttongroupBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 462);
            this.panel1.TabIndex = 1;
            // 
            // executegroupBox
            // 
            this.executegroupBox.Controls.Add(this.createButton);
            this.executegroupBox.Controls.Add(this.clearButton);
            this.executegroupBox.Controls.Add(this.addButton);
            this.executegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executegroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.executegroupBox.Location = new System.Drawing.Point(12, 393);
            this.executegroupBox.Name = "executegroupBox";
            this.executegroupBox.Size = new System.Drawing.Size(497, 57);
            this.executegroupBox.TabIndex = 5;
            this.executegroupBox.TabStop = false;
            this.executegroupBox.Text = "Step 3";
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.Green;
            this.createButton.Location = new System.Drawing.Point(6, 16);
            this.createButton.Margin = new System.Windows.Forms.Padding(0);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(154, 32);
            this.createButton.TabIndex = 6;
            this.createButton.TabStop = false;
            this.createButton.Text = "Create File";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(334, 16);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 32);
            this.clearButton.TabIndex = 8;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Location = new System.Drawing.Point(170, 16);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(154, 32);
            this.addButton.TabIndex = 7;
            this.addButton.TabStop = false;
            this.addButton.Text = "Add Docs";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // infogroupBox
            // 
            this.infogroupBox.Controls.Add(this.label5);
            this.infogroupBox.Controls.Add(this.addressTextbox);
            this.infogroupBox.Controls.Add(this.label4);
            this.infogroupBox.Controls.Add(this.lakeCombobox);
            this.infogroupBox.Controls.Add(this.label2);
            this.infogroupBox.Controls.Add(this.firstTextbox);
            this.infogroupBox.Controls.Add(this.lastTextbox);
            this.infogroupBox.Controls.Add(this.comboBoxProject);
            this.infogroupBox.Controls.Add(this.label3);
            this.infogroupBox.Controls.Add(this.label1);
            this.infogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infogroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infogroupBox.Location = new System.Drawing.Point(12, 30);
            this.infogroupBox.Name = "infogroupBox";
            this.infogroupBox.Size = new System.Drawing.Size(497, 107);
            this.infogroupBox.TabIndex = 0;
            this.infogroupBox.TabStop = false;
            this.infogroupBox.Text = "Step 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstTextbox
            // 
            this.firstTextbox.Location = new System.Drawing.Point(18, 36);
            this.firstTextbox.Name = "firstTextbox";
            this.firstTextbox.Size = new System.Drawing.Size(153, 21);
            this.firstTextbox.TabIndex = 1;
            // 
            // lastTextbox
            // 
            this.lastTextbox.Location = new System.Drawing.Point(179, 36);
            this.lastTextbox.Name = "lastTextbox";
            this.lastTextbox.Size = new System.Drawing.Size(153, 21);
            this.lastTextbox.TabIndex = 2;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Items.AddRange(new object[] {
            "Boat House",
            "Boat House and Wall",
            "Dock Repair",
            "Dredge",
            "Pony Wall",
            "Wall",
            "Wall Repair"});
            this.comboBoxProject.Location = new System.Drawing.Point(338, 78);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(153, 23);
            this.comboBoxProject.Sorted = true;
            this.comboBoxProject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(215, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(363, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project Type";
            // 
            // buttongroupBox
            // 
            this.buttongroupBox.Controls.Add(this.changeButton);
            this.buttongroupBox.Controls.Add(this.dockButton);
            this.buttongroupBox.Controls.Add(this.wallButton);
            this.buttongroupBox.Controls.Add(this.dockwallButton);
            this.buttongroupBox.Controls.Add(this.tabs);
            this.buttongroupBox.Controls.Add(this.dredgeButton);
            this.buttongroupBox.Controls.Add(this.quoteButton);
            this.buttongroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttongroupBox.Location = new System.Drawing.Point(12, 143);
            this.buttongroupBox.Name = "buttongroupBox";
            this.buttongroupBox.Size = new System.Drawing.Size(497, 243);
            this.buttongroupBox.TabIndex = 4;
            this.buttongroupBox.TabStop = false;
            this.buttongroupBox.Text = "Step 2";
            // 
            // changeButton
            // 
            this.changeButton.AutoSize = true;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changeButton.Location = new System.Drawing.Point(6, 201);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(113, 36);
            this.changeButton.TabIndex = 16;
            this.changeButton.TabStop = false;
            this.changeButton.Text = "Change\r\nRequest\r\n";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // dockButton
            // 
            this.dockButton.AutoSize = true;
            this.dockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dockButton.Location = new System.Drawing.Point(6, 21);
            this.dockButton.Name = "dockButton";
            this.dockButton.Size = new System.Drawing.Size(113, 36);
            this.dockButton.TabIndex = 6;
            this.dockButton.TabStop = false;
            this.dockButton.Text = "Dock Package";
            this.dockButton.UseVisualStyleBackColor = true;
            this.dockButton.Click += new System.EventHandler(this.dockButton_Click);
            // 
            // wallButton
            // 
            this.wallButton.AutoSize = true;
            this.wallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wallButton.Location = new System.Drawing.Point(6, 57);
            this.wallButton.Name = "wallButton";
            this.wallButton.Size = new System.Drawing.Size(113, 36);
            this.wallButton.TabIndex = 7;
            this.wallButton.TabStop = false;
            this.wallButton.Text = "Wall Package";
            this.wallButton.UseVisualStyleBackColor = true;
            this.wallButton.Click += new System.EventHandler(this.wallButton_Click);
            // 
            // dockwallButton
            // 
            this.dockwallButton.AutoSize = true;
            this.dockwallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockwallButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dockwallButton.Location = new System.Drawing.Point(6, 93);
            this.dockwallButton.Name = "dockwallButton";
            this.dockwallButton.Size = new System.Drawing.Size(113, 36);
            this.dockwallButton.TabIndex = 8;
            this.dockwallButton.TabStop = false;
            this.dockwallButton.Text = "Dock and Wall \r\nPackage";
            this.dockwallButton.UseVisualStyleBackColor = true;
            this.dockwallButton.Click += new System.EventHandler(this.dockwallButton_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabs.Location = new System.Drawing.Point(125, 30);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(360, 196);
            this.tabs.TabIndex = 15;
            this.tabs.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Bidding Sheet",
            "Change Request",
            "Dock Application for Improvement Permit",
            "Dock Specifications",
            "Lander Marine Insurance",
            "Letter of Authorization",
            "Parks Construction Insurance",
            "Proposal",
            "Quote",
            "Wall Specifications",
            "Wall/Dredge Application for Improvement Permit"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(354, 165);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.TabStop = false;
            // 
            // dredgeButton
            // 
            this.dredgeButton.AutoSize = true;
            this.dredgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dredgeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dredgeButton.Location = new System.Drawing.Point(6, 129);
            this.dredgeButton.Name = "dredgeButton";
            this.dredgeButton.Size = new System.Drawing.Size(113, 36);
            this.dredgeButton.TabIndex = 10;
            this.dredgeButton.TabStop = false;
            this.dredgeButton.Text = "Dredge \r\nPackage";
            this.dredgeButton.UseVisualStyleBackColor = true;
            this.dredgeButton.Click += new System.EventHandler(this.dredgeButton_Click);
            // 
            // quoteButton
            // 
            this.quoteButton.AutoSize = true;
            this.quoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quoteButton.Location = new System.Drawing.Point(6, 165);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(113, 36);
            this.quoteButton.TabIndex = 9;
            this.quoteButton.TabStop = false;
            this.quoteButton.Text = "Quote";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDocumentsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editDocumentsToolStripMenuItem
            // 
            this.editDocumentsToolStripMenuItem.Name = "editDocumentsToolStripMenuItem";
            this.editDocumentsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editDocumentsToolStripMenuItem.Text = "Edit Documents";
            this.editDocumentsToolStripMenuItem.Click += new System.EventHandler(this.editDocumentsToolStripMenuItem_Click);
            // 
            // lakeCombobox
            // 
            this.lakeCombobox.FormattingEnabled = true;
            this.lakeCombobox.Items.AddRange(new object[] {
            "Cedar Creek Lake",
            "Richland Chambers",
            "Lake Palestine"});
            this.lakeCombobox.Location = new System.Drawing.Point(338, 34);
            this.lakeCombobox.Name = "lakeCombobox";
            this.lakeCombobox.Size = new System.Drawing.Size(153, 23);
            this.lakeCombobox.TabIndex = 12;
            this.lakeCombobox.SelectedIndexChanged += new System.EventHandler(this.lakeCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(400, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lake";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(18, 80);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(314, 21);
            this.addressTextbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(144, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(537, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(537, 460);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project File Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.executegroupBox.ResumeLayout(false);
            this.executegroupBox.PerformLayout();
            this.infogroupBox.ResumeLayout(false);
            this.infogroupBox.PerformLayout();
            this.buttongroupBox.ResumeLayout(false);
            this.buttongroupBox.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lastTextbox;
        private System.Windows.Forms.TextBox firstTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button wallButton;
        private System.Windows.Forms.Button dockButton;
        private System.Windows.Forms.Button dockwallButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Button dredgeButton;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDocumentsToolStripMenuItem;
        private System.Windows.Forms.GroupBox executegroupBox;
        private System.Windows.Forms.GroupBox infogroupBox;
        private System.Windows.Forms.GroupBox buttongroupBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lakeCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextbox;

    }
}

