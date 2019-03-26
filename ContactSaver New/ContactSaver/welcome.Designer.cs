namespace ContactSaver
{
    partial class welcome
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
            this.Okbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoadXMLFile = new System.Windows.Forms.Button();
            this.FileAdress = new System.Windows.Forms.TextBox();
            this.NewDataBase = new System.Windows.Forms.Button();
            this.labHElp = new System.Windows.Forms.Label();
            this.btnShowMore = new System.Windows.Forms.Button();
            this.checkDefault = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Okbutton
            // 
            this.Okbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Okbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Okbutton.Location = new System.Drawing.Point(248, 169);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(77, 23);
            this.Okbutton.TabIndex = 0;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = false;
            this.Okbutton.Click += new System.EventHandler(this.OKButton_Click);
            this.Okbutton.MouseLeave += new System.EventHandler(this.Okbutton_MouseLeave);
            this.Okbutton.MouseHover += new System.EventHandler(this.Okbutton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("ABeeZee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Saver 2.0";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 25);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(315, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.exitbuttonclick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.infobuttonclick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 10);
            this.panel2.TabIndex = 3;
            // 
            // LoadXMLFile
            // 
            this.LoadXMLFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadXMLFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadXMLFile.Location = new System.Drawing.Point(249, 80);
            this.LoadXMLFile.Name = "LoadXMLFile";
            this.LoadXMLFile.Size = new System.Drawing.Size(75, 23);
            this.LoadXMLFile.TabIndex = 4;
            this.LoadXMLFile.TabStop = false;
            this.LoadXMLFile.Text = "L&oad";
            this.LoadXMLFile.UseVisualStyleBackColor = true;
            this.LoadXMLFile.Click += new System.EventHandler(this.LoadXMLFile_Click);
            this.LoadXMLFile.MouseLeave += new System.EventHandler(this.LoadXMLFile_MouseLeave);
            this.LoadXMLFile.MouseHover += new System.EventHandler(this.LoadXMLFile_MouseHover);
            // 
            // FileAdress
            // 
            this.FileAdress.AllowDrop = true;
            this.FileAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileAdress.Location = new System.Drawing.Point(13, 80);
            this.FileAdress.Multiline = true;
            this.FileAdress.Name = "FileAdress";
            this.FileAdress.Size = new System.Drawing.Size(229, 55);
            this.FileAdress.TabIndex = 5;
            // 
            // NewDataBase
            // 
            this.NewDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewDataBase.Location = new System.Drawing.Point(249, 112);
            this.NewDataBase.Name = "NewDataBase";
            this.NewDataBase.Size = new System.Drawing.Size(75, 23);
            this.NewDataBase.TabIndex = 6;
            this.NewDataBase.TabStop = false;
            this.NewDataBase.Text = "&New..";
            this.NewDataBase.UseVisualStyleBackColor = true;
            this.NewDataBase.Click += new System.EventHandler(this.NewDataBase_Click);
            this.NewDataBase.MouseLeave += new System.EventHandler(this.NewDataBase_MouseLeave);
            this.NewDataBase.MouseHover += new System.EventHandler(this.NewDataBase_MouseHover);
            // 
            // labHElp
            // 
            this.labHElp.AutoSize = true;
            this.labHElp.ForeColor = System.Drawing.Color.Black;
            this.labHElp.Location = new System.Drawing.Point(12, 174);
            this.labHElp.Name = "labHElp";
            this.labHElp.Size = new System.Drawing.Size(0, 13);
            this.labHElp.TabIndex = 7;
            // 
            // btnShowMore
            // 
            this.btnShowMore.AutoSize = true;
            this.btnShowMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMore.Location = new System.Drawing.Point(12, 200);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(55, 25);
            this.btnShowMore.TabIndex = 8;
            this.btnShowMore.Text = "&More>>";
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkDefault
            // 
            this.checkDefault.FlatAppearance.BorderSize = 0;
            this.checkDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkDefault.Location = new System.Drawing.Point(15, 144);
            this.checkDefault.Name = "checkDefault";
            this.checkDefault.Size = new System.Drawing.Size(99, 27);
            this.checkDefault.TabIndex = 9;
            this.checkDefault.Text = "&Set As Deafult";
            this.toolTip1.SetToolTip(this.checkDefault, "Check This To Set Current File As Default ");
            this.checkDefault.UseVisualStyleBackColor = true;
            this.checkDefault.CheckStateChanged += new System.EventHandler(this.checkDefault_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(94, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // welcome
            // 
            this.AcceptButton = this.Okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 241);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkDefault);
            this.Controls.Add(this.btnShowMore);
            this.Controls.Add(this.labHElp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewDataBase);
            this.Controls.Add(this.FileAdress);
            this.Controls.Add(this.LoadXMLFile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Okbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoadXMLFile;
        private System.Windows.Forms.TextBox FileAdress;
        private System.Windows.Forms.Button NewDataBase;
        private System.Windows.Forms.Label labHElp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowMore;
        private System.Windows.Forms.CheckBox checkDefault;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}