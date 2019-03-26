using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

//TODO : implement the datagrid box to show the number and username in coloumn. 
//Implemented April 18,2018
// TODO : Custome AutoUpdate ON\off.
//Implement Themes Using enum or array(something like).
//TODO : show last save contact time in status bar.
//TODO : Add a contact load method using exception.
//TODO : Make conatact data base dynamic, prompt a option on lauch menu to choose the save file, can be set as default
//TODO : Show Number on Notification Bar.
//TODO : Addational option to or not to show Numbers on Notification bar
//TODO : Save all Application related Data on different or Same .xml file/ .txt file.
//TODO : Show Data In Entry Box when selected from list box (optional box)
//TODO : When file not found create a new one by The use or Chnage file.
//TODO : Same as above check when active whatsapp field will deactive and the phone number will get copied to that field.(implemented)




namespace ContactSaver
{
    public partial class MainForm : Form
    {

        public static string FileNameOnBar = String.Empty;

        public static string filename = String.Empty;
        public bool isContactTableShow = true;


        // bool isDataGridHidden = true;


        public MainForm()
        {





            InitializeComponent();

            //make from dragabble by its tittleBar and fileNameBar
            MoveClass MoveUsingForm = new MoveClass(this);
            MoveClass MoveUsingTitleBar = new MoveClass(this, NamePanel);



            MoveUsingTitleBar.MakeFromDraggableViaControlOr();
            MoveUsingForm.MakeFromDraggableViaControlOr();









        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // textBox1.Text = XmlMethods.GetXDocument().ToString();
            XmlMethods.LoadXDocumnet(filename);



            /* code for listbox */
            List<String> names = XmlMethods.getTheNames(filename);
            listBox1.DataSource = names;

            // showDatainDataGrid("contact.xml");





            //start the auto update every 10000 mil
            // timerAutoSave.Start();


            //get the  number of contact.
            txtNumberOfContact.Text = ShowHowmanyNumbersAreTheir();
            //Console.WriteLine(res);


            txtContactSearch.AutoCompleteCustomSource.AddRange(names.ToArray<string>());



        }

        /* implemented 22.2.2019*/
        private string ShowHowmanyNumbersAreTheir()
        {
            string ans = XmlMethods.getNumberOfElement(filename).ToString() + " contacts";
            Console.WriteLine(ans);
            return ans;
        }

        private void Save(object Sender, EventArgs e)

        {
            if (txtName.Text == "" | txtNumber.Text == "")
            {
                CustomeDialogBox Caution = new CustomeDialogBox("Please Enter A Number", true);
                Caution.Location = new Point(this.Location.X + (this.Width - Caution.Width) / 2, 12
                    + this.Location.Y + (this.Height - Caution.Height) / 2);
                Caution.ShowDialog();

            }
            else
            {
                XmlMethods.InsertNewField(filename, txtName.Text, txtNumber.Text, txtWhatsAppNumber.Text);
                //textBox1.Text = XmlMethods.GetXDocument().ToString();
                MessageBox.Show("Saved");
            }
            List<String> names = XmlMethods.getTheNames(filename);
            listBox1.DataSource = names;
            //showDatainDataGrid("contact.xml");


            //number of contact.
            txtNumberOfContact.Text = ShowHowmanyNumbersAreTheir();
            txtContactSearch.AutoCompleteCustomSource.AddRange(names.ToArray<string>());


        }

        private void findNumbers_Click(object sender, EventArgs e)
        {
            XmlMethods.GetTheNumber(filename, txtName);
        }

        private void Button_Del(object sender, EventArgs e)
        {
            Object names = listBox1.SelectedItem; //return the selected items


            String Name = names.ToString();
            DialogResult deleteDialong = MessageBox.Show("Do You Want To Delelet The Contact " + Name, "delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // int index = listBox1.SelectedIndex;
            //   Console.WriteLine(index);
            if (deleteDialong == DialogResult.Yes)
            {
                XmlMethods.DeleteField(filename, Name);
                List<String> NewName = XmlMethods.getTheNames(filename);
                listBox1.DataSource = NewName;
                //  showDatainDataGrid("contact.xml");
            }


            /*
             XmlMethods.DeleteField("contact.xml", Name);
             List<String> NewName = XmlMethods.getTheNames("contact.xml");
             listBox1.DataSource = NewName;*/



            txtNumberOfContact.Text = ShowHowmanyNumbersAreTheir();
            List<String> name = XmlMethods.getTheNames(filename);
            listBox1.DataSource = name;



        }


        /* Show Numbers and Names in a tool tip for 800 mil sec*/
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int index = listBox1.SelectedIndex;
            String Name = (string)listBox1.SelectedItem;


            // Console.WriteLine("you choose "+listBox1.SelectedItem);

            toolTip1.Show(Name + "\n" + XmlMethods.GetTheNumber(filename, listBox1) + "Whatsapp\n" + XmlMethods.GetTheWhatsappNumber(filename, listBox1), listBox1, 800);
        }




        /* private void showDatainDataGrid(string fileName)
         {
           //  Implemented April 18,2018

                String path = fileName;
                 DataSet ds = new DataSet();
                ds.ReadXml(fileName);

                 dataGridView1.DataSource = ds;

                 dataGridView1.DataMember = "Contact";






         }*/



        /* All menu item event */
        /* private void ShowDataTableInTheFormControl(Object sender,EventArgs e)
         { //Implemented 18 April,2018
             if (isDataGridHidden)
             {
                 dataGridView1.Show();
                 showDataTableToolStripMenuItem.Checked = true;
                 isDataGridHidden = false;
             }
             else
             {
                 dataGridView1.Hide();
                 showDataTableToolStripMenuItem.Checked = false;
                 isDataGridHidden = true;

             }



         }*/


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<String> names = XmlMethods.getTheNames(filename);


            listBox1.DataSource = names;
        }

        private void backUpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {



            FileModificatioclasses.BackUpFileToAnotherLoaction();




        }

        private void infoPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreenForm aboutScreen = new AboutScreenForm();
            aboutScreen.ShowDialog();



        }

        /* close app*/
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult closeDialog = MessageBox.Show("Do you Want to Close ?", "Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (closeDialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /* unused*/
        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            List<String> name = XmlMethods.getTheNames(filename);
            listBox1.DataSource = name;

            txtContactSearch.AutoCompleteCustomSource.AddRange(name.ToArray<string>());
            txtContactSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        /* implemented 23.2.2019*/
        private void sameNumberIndication_CheckedChanged(object sender, EventArgs e)
        {
            if (txtWhatsAppNumber.Enabled)
            {
                txtWhatsAppNumber.Text = txtNumber.Text;
                txtWhatsAppNumber.Enabled = false;
            }
            else
            {
                txtWhatsAppNumber.Enabled = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /* implemented 24.2.2019*/
        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isContactTableShow)
            {
                ContactPanel.Show();

                isContactTableShow = true;
                showListToolStripMenuItem.Checked = true;
                //FileNameBar.Show();
            }
            else
            {
                ContactPanel.Hide();
                isContactTableShow = false;
                showListToolStripMenuItem.Checked = false;
                //FileNameBar.Hide();
            }
        }
        /* implemented 24.2.2019*/
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileModificatioclasses.LoadNewFileFromEx();
        }

        private void loadOtherListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            filename = FileModificatioclasses.LoadXMLFile_Click();

            if (filename == string.Empty) { }
            else
            {
                List<String> names = XmlMethods.getTheNames(filename);
                listBox1.DataSource = names;
                txtNumberOfContact.Text = ShowHowmanyNumbersAreTheir();
                // FileNameBar.Text = "file: "+filename;
            }


        }
        /* implemented 24.2.2019 */
        private void txtContactSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                XmlMethods.GetTheNumber(filename, txtContactSearch);
            }
        }

        /*implemented 24.2.2019*/
        private void btnBackToWelcome_Click(object sender, EventArgs e)
        {

            this.Close();
            welcome.r.Show();

        }

        public static string retunFileName(string strg)
        {

            return strg;
        }
        public static string retn()
        {
            return "Ok Hello from MainFrom";
        }





        /* Some Method */
        public static string ShowHowmanyNumbers(string filename)
        {
            string ans = XmlMethods.getNumberOfElement(filename).ToString() + " contacts stored";
            return ans;
        }
    }
}
