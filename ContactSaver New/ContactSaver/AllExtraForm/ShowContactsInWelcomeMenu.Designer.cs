namespace ContactSaver.AllExtraForm
{
    partial class ShowContactsInWelcomeMenu
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
            this.DismisB = new System.Windows.Forms.Button();
            this.listContacts = new System.Windows.Forms.ListBox();
            this.filenameonfliy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DismisB
            // 
            this.DismisB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DismisB.Location = new System.Drawing.Point(209, 154);
            this.DismisB.Name = "DismisB";
            this.DismisB.Size = new System.Drawing.Size(102, 23);
            this.DismisB.TabIndex = 1;
            this.DismisB.TabStop = false;
            this.DismisB.Text = "Ok";
            this.DismisB.UseVisualStyleBackColor = true;
            this.DismisB.Click += new System.EventHandler(this.DismisB_Click);
            // 
            // listContacts
            // 
            this.listContacts.FormattingEnabled = true;
            this.listContacts.Location = new System.Drawing.Point(12, 40);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(299, 108);
            this.listContacts.TabIndex = 2;
            // 
            // filenameonfliy
            // 
            this.filenameonfliy.Location = new System.Drawing.Point(13, 5);
            this.filenameonfliy.Name = "filenameonfliy";
            this.filenameonfliy.Size = new System.Drawing.Size(298, 35);
            this.filenameonfliy.TabIndex = 3;
            this.filenameonfliy.Text = "label1";
            // 
            // ShowContactsInWelcomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 189);
            this.Controls.Add(this.filenameonfliy);
            this.Controls.Add(this.listContacts);
            this.Controls.Add(this.DismisB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowContactsInWelcomeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowContactsInWelcomeMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DismisB;
        public System.Windows.Forms.ListBox listContacts;
        public System.Windows.Forms.Label filenameonfliy;
    }
}