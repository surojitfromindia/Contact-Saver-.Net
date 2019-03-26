namespace ContactSaver
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtWhatsAppNumber = new System.Windows.Forms.TextBox();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.findNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtContactSearch = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.btnBackToWelcome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOtherListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.FileName = new System.Windows.Forms.Label();
            this.txtNumberOfContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sameNumberIndication = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ContactPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(111, 67);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(35, 13);
            this.l1.TabIndex = 1;
            this.l1.Text = "Name";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(102, 125);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(44, 13);
            this.l2.TabIndex = 2;
            this.l2.Text = "Number";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(52, 178);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(94, 13);
            this.l3.TabIndex = 3;
            this.l3.Text = "WhatsAppNumber";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtName.Location = new System.Drawing.Point(159, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNumber.Location = new System.Drawing.Point(159, 118);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(188, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // txtWhatsAppNumber
            // 
            this.txtWhatsAppNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWhatsAppNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtWhatsAppNumber.Location = new System.Drawing.Point(159, 171);
            this.txtWhatsAppNumber.Name = "txtWhatsAppNumber";
            this.txtWhatsAppNumber.Size = new System.Drawing.Size(188, 20);
            this.txtWhatsAppNumber.TabIndex = 3;
            // 
            // SaveToFile
            // 
            this.SaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToFile.Location = new System.Drawing.Point(164, 230);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(79, 23);
            this.SaveToFile.TabIndex = 4;
            this.SaveToFile.Text = "Save";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.Save);
            // 
            // findNumbers
            // 
            this.findNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findNumbers.Location = new System.Drawing.Point(55, 230);
            this.findNumbers.Name = "findNumbers";
            this.findNumbers.Size = new System.Drawing.Size(79, 23);
            this.findNumbers.TabIndex = 5;
            this.findNumbers.Text = "Search Number";
            this.findNumbers.UseVisualStyleBackColor = true;
            this.findNumbers.Click += new System.EventHandler(this.findNumbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 195);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DelButton
            // 
            this.DelButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Location = new System.Drawing.Point(273, 230);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(79, 23);
            this.DelButton.TabIndex = 0;
            this.DelButton.TabStop = false;
            this.DelButton.Text = "Delete";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.Button_Del);
            // 
            // txtContactSearch
            // 
            this.txtContactSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtContactSearch.Location = new System.Drawing.Point(159, 31);
            this.txtContactSearch.Name = "txtContactSearch";
            this.txtContactSearch.Size = new System.Drawing.Size(188, 20);
            this.txtContactSearch.TabIndex = 0;
            this.txtContactSearch.Text = "search ";
            this.toolTip1.SetToolTip(this.txtContactSearch, "search contacts here");
            this.txtContactSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactSearch_KeyDown);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Tomato;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(537, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 25);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "X";
            this.toolTip1.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // btnBackToWelcome
            // 
            this.btnBackToWelcome.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBackToWelcome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBackToWelcome.FlatAppearance.BorderSize = 0;
            this.btnBackToWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToWelcome.Location = new System.Drawing.Point(509, 0);
            this.btnBackToWelcome.Name = "btnBackToWelcome";
            this.btnBackToWelcome.Size = new System.Drawing.Size(28, 25);
            this.btnBackToWelcome.TabIndex = 19;
            this.btnBackToWelcome.Text = "B";
            this.toolTip1.SetToolTip(this.btnBackToWelcome, "Back To Welcome Screen");
            this.btnBackToWelcome.UseVisualStyleBackColor = false;
            this.btnBackToWelcome.Click += new System.EventHandler(this.btnBackToWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(52, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contacts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactPanel
            // 
            this.ContactPanel.AutoSize = true;
            this.ContactPanel.Controls.Add(this.listBox1);
            this.ContactPanel.Controls.Add(this.label1);
            this.ContactPanel.Location = new System.Drawing.Point(369, 33);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Size = new System.Drawing.Size(162, 239);
            this.ContactPanel.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 278);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 26);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadOtherListToolStripMenuItem,
            this.showListToolStripMenuItem,
            this.showDataTableToolStripMenuItem,
            this.backUpFileToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.infoPanelToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // loadOtherListToolStripMenuItem
            // 
            this.loadOtherListToolStripMenuItem.Name = "loadOtherListToolStripMenuItem";
            this.loadOtherListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.loadOtherListToolStripMenuItem.Text = "Load Other List";
            this.loadOtherListToolStripMenuItem.Click += new System.EventHandler(this.loadOtherListToolStripMenuItem_Click);
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.Checked = true;
            this.showListToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showListToolStripMenuItem.Text = "Show List";
            this.showListToolStripMenuItem.Click += new System.EventHandler(this.showListToolStripMenuItem_Click);
            // 
            // showDataTableToolStripMenuItem
            // 
            this.showDataTableToolStripMenuItem.Name = "showDataTableToolStripMenuItem";
            this.showDataTableToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showDataTableToolStripMenuItem.Text = "Show Data Table";
            // 
            // backUpFileToolStripMenuItem
            // 
            this.backUpFileToolStripMenuItem.Name = "backUpFileToolStripMenuItem";
            this.backUpFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.backUpFileToolStripMenuItem.Text = "Back Up File";
            this.backUpFileToolStripMenuItem.Click += new System.EventHandler(this.backUpFileToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.updateToolStripMenuItem.Text = "Update Data";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // infoPanelToolStripMenuItem
            // 
            this.infoPanelToolStripMenuItem.Name = "infoPanelToolStripMenuItem";
            this.infoPanelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.infoPanelToolStripMenuItem.Text = "Info Panel";
            this.infoPanelToolStripMenuItem.Click += new System.EventHandler(this.infoPanelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NamePanel
            // 
            this.NamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NamePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.NamePanel.Controls.Add(this.btnBackToWelcome);
            this.NamePanel.Controls.Add(this.CloseButton);
            this.NamePanel.Controls.Add(this.FileName);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.ForeColor = System.Drawing.Color.Transparent;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(565, 25);
            this.NamePanel.TabIndex = 15;
            // 
            // FileName
            // 
            this.FileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(-3, 3);
            this.FileName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(108, 19);
            this.FileName.TabIndex = 17;
            this.FileName.Text = "   Contact Saver";
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumberOfContact
            // 
            this.txtNumberOfContact.BackColor = System.Drawing.Color.Salmon;
            this.txtNumberOfContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtNumberOfContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfContact.ForeColor = System.Drawing.Color.White;
            this.txtNumberOfContact.Location = new System.Drawing.Point(291, 282);
            this.txtNumberOfContact.Name = "txtNumberOfContact";
            this.txtNumberOfContact.Size = new System.Drawing.Size(66, 18);
            this.txtNumberOfContact.TabIndex = 2;
            this.txtNumberOfContact.Text = "000";
            this.txtNumberOfContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "You Have  :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 0);
            this.panel3.TabIndex = 18;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Interval = 10000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(132, 173);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // sameNumberIndication
            // 
            this.sameNumberIndication.AutoSize = true;
            this.sameNumberIndication.Location = new System.Drawing.Point(159, 197);
            this.sameNumberIndication.Name = "sameNumberIndication";
            this.sameNumberIndication.Size = new System.Drawing.Size(98, 17);
            this.sameNumberIndication.TabIndex = 19;
            this.sameNumberIndication.Text = "same as above";
            this.sameNumberIndication.UseVisualStyleBackColor = true;
            this.sameNumberIndication.CheckedChanged += new System.EventHandler(this.sameNumberIndication_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 253);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(564, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 253);
            this.panel2.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 277);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 1);
            this.panel4.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(565, 304);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumberOfContact);
            this.Controls.Add(this.sameNumberIndication);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContactSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.findNumbers);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.txtWhatsAppNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ContactPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(384, 304);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Saver 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContactPanel.ResumeLayout(false);
            this.ContactPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtWhatsAppNumber;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.Button findNumbers;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox sameNumberIndication;
        private System.Windows.Forms.ToolStripMenuItem loadOtherListToolStripMenuItem;
        private System.Windows.Forms.Label txtNumberOfContact;
        private System.Windows.Forms.TextBox txtContactSearch;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button btnBackToWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

