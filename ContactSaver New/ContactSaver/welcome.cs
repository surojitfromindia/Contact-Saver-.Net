using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  SaveIntoXmlLib;

namespace ContactSaver
{                   /*------------------------------Created 23.2.2019------------------------*/
    public partial class welcome : Form
    {
        /*---------------------------------- Declaration------------------------- */
        public static  Form r; //for MainForm Access this form.
        private CustomeDialogBox d2;
        private AllExtraForm.ShowContactsInWelcomeMenu d3;
        private  bool isFirstLaunch = true;
        
        public static string textOnExpand = String.Empty;
        private string SettingSaveFileName = "settings.xml"; //setting file
        private string parentName = "config"; //node of settings.xml
        private string defaultfile; //the default file name from xml
        private string p; // current file name in fileaddress text box

        public delegate string ShowText();
        /*----------------------------------End Declaratio--------------------------*/


        ShowText n = new ShowText(MainForm.retn);
        public welcome()
        {
            InitializeComponent();

            //d2 = new CustomeDialogBox("Choose Something",false);
            d3 = new AllExtraForm.ShowContactsInWelcomeMenu();
           
           


           // MoveClass DragByNamePanel = new MoveClass(this, d2,panel1); //Modified 26.2.2019
            MoveClass DragByNamePanel2 = new MoveClass(this, d3, panel1); 
            
           // DragByNamePanel.MakeFromDraggableViaControl();
            DragByNamePanel2.MakeFromDraggableViaControl();
            Console.WriteLine(n());
          
            
        }

        
        
        /**@author-Surojit Paul
         * Implemented 23.2.2019
         * This button Open the Loaded/selected/file from adrress
         * throws FileNotfound and ArgumentException already hadled by CreatFile Method in XMlContainers class
         * it first check whether the address bar is empty. if true- show a custome pop-up dialog box
         * false-the fileName(without extension) appended by ".xml" then open the file and hide the welcome screen
         * 
         * have problem with the ".xml" string.
         * */
        private void OKButton_Click(object sender, EventArgs e)
        {
           
            Form Mainform = new MainForm();
            MainForm.FileNameOnBar = FileAdress.Text;
           


            if (FileAdress.Text == String.Empty)
            {
                CustomeDialogBox d1 = new CustomeDialogBox("Load A File Or \nCreate a New...",false,true);
                d1.Location = new Point(this.Location.X+(this.Width-d1.Width)/2, 12+this.Location.Y+(this.Height-d1.Height)/2);
               
                
                d1.ShowDialog();
                
            }

            else if (!FileAdress.Text.Contains(".xml"))
            {
                MainForm.filename = FileAdress.Text + ".xml";
                this.Hide();
                Mainform.Show();
                MainForm.FileNameOnBar = FileAdress.Text;
            }
            else
            {
                MainForm.filename = FileAdress.Text;
                this.Hide();
                Mainform.Show();
                MainForm.FileNameOnBar = FileAdress.Text;
                Console.WriteLine("Surojit" + MainForm.FileNameOnBar);
            }
            //d2.Close();
            d3.Close();
        }


        /** Implemented 23.2.2019
         * This button load file by opening the Openfile Dialog box
         * 'LoadNewFileEx' open a new dialog box and copy the selected file path to a string
         * The string is a file path then send back to mainform
         * which load the content from the file and update the listbox
         * it also copy the path to address bar
         * */
        public void LoadXMLFile_Click(object sender, EventArgs e)
        {

            p = FileModificatioclasses.LoadNewFileFromEx(); //p in declaration
            
            Console.WriteLine(p);
            MainForm.filename = p;
            FileAdress.Text = p;
            /* -----------------modified 28.2.2019--------------------*/
            if (FileAdress.Text != String.Empty || FileAdress.Text != defaultfile) //added for default file Option 28.2.2019
            {
                checkDefault.Enabled = true;
                checkDefault.Checked = false;
                FileAdress.Text = p; //stop from emptying the fileadress textbox

                if (FileAdress.Text != string.Empty)
                { 
                label2.Text = MainForm.ShowHowmanyNumbers(p); //throw arg exception
                List<String> names = XmlMethods.getTheNames(FileAdress.Text);/* Should use update*/
                    d3.listContacts.DataSource = names;
                }

            }


            if (FileAdress.Text == string.Empty) //when file address in Empty
            { 
                FileAdress.Text = defaultfile;
                checkDefault.Checked = false;
                checkDefault.Enabled = false;
            }
            if(FileAdress.Text==defaultfile) //when nothing select from load dialong
            {
                FileAdress.Text = defaultfile;
                checkDefault.Checked = true;
                checkDefault.Enabled = true;
            }

           
            /* -----------------modified 28.2.2019--------------------*/

        }



        /* Implemented 23.2.2019 */
        private void NewDataBase_Click(object sender, EventArgs e)
        {
            String FileNametoBeCr = FileAdress.Text;
            DialogResult newFileCreate = MessageBox.Show("Do you want to create a new file?\n" + FileNametoBeCr, "Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (newFileCreate == DialogResult.Yes)
            {
                if (FileNametoBeCr != String.Empty)
                { XmlMethods.creatXmlDocument(FileNametoBeCr + ".xml");
                    MessageBox.Show("SuccesFull");
                }
                else
                {
                    MessageBox.Show("File Name Can't Be Empty");
                }

            }
        }

        /* Unused*/
        private static void ShowTheMainFormSub(Form fromtobelauch)
        {
            fromtobelauch.Show();

        }

        /* excess */
        private void LoadXMLFile_MouseHover(object sender, EventArgs e)
        {
            labHElp.Text = "=> Load New Contact File";
        }

        private void LoadXMLFile_MouseLeave(object sender, EventArgs e)
        {
            labHElp.Text = string.Empty;
        }

        private void NewDataBase_MouseHover(object sender, EventArgs e)
        {
            labHElp.Text = "=> Create A NEW Contact List";
        }

        private void NewDataBase_MouseLeave(object sender, EventArgs e)
        {
            labHElp.Text = string.Empty;
        }

        private void Okbutton_MouseHover(object sender, EventArgs e)
        {
            labHElp.Text = "=> Open The Selected File";
        }

        private void Okbutton_MouseLeave(object sender, EventArgs e)
        {
            labHElp.Text = string.Empty;
        }

        private void exitbuttonclick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infobuttonclick(object sender, EventArgs e)
        {
            new AboutScreenForm().ShowDialog();
        }


        /* 26.2.2019*/
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (isFirstLaunch)
                {
                    // d2.Location = new Point(this.Location.X, this.Location.Y + this.Height);
                    d3.Location = new Point(this.Location.X, this.Location.Y + this.Height);

                    isFirstLaunch = false;
                    //  d2.Show();
                    d3.Show();

                }
                else
                {


                    //d2.Show();
                    d3.Show();


                }

                List<String> names = XmlMethods.getTheNames(FileAdress.Text);
                d3.listContacts.DataSource = names;
            }
            catch (Exception) { }
            d3.filenameonfliy.Text = FileAdress.Text;


        }

        private void welcome_Load(object sender, EventArgs e)
        {/*28.2.2019*/
            r = new welcome(); //modified 28.2.2019 for MainForm
            
            try
            {
                FileAdress.Text = Settings.GetTheValueOFNode(SettingSaveFileName,parentName,"DefaultFile");

                defaultfile = FileAdress.Text;
                bool boolDefault = Convert.ToBoolean(Settings.GetTheValueOFNode(SettingSaveFileName, parentName, "isDefault"));
                if (FileAdress.Text == string.Empty) { checkDefault.Enabled = false; }
                checkDefault.Checked = boolDefault;
                label2.Text = MainForm.ShowHowmanyNumbers(defaultfile); //show number of contact on flie

                List<String> names = XmlMethods.getTheNames(FileAdress.Text);
                d3.listContacts.DataSource = names;
            }
            catch(Exception)
            {
                Console.WriteLine("Some thing is wrong!");
            }

            
        }

        /*28.2.2019*/
        private void checkDefault_CheckStateChanged(object sender, EventArgs e)
        {
            if (FileAdress.Text ==string.Empty) { checkDefault.Enabled = false; }

            
              else if (!checkDefault.Checked)
                {
                checkDefault.Enabled = true;
                Settings.SaveInSetting(SettingSaveFileName, parentName, "DefaultFile", "");
                    Settings.SaveInSetting(SettingSaveFileName, parentName, "isDefault", "false");
                }
            else  if (checkDefault.Checked)
                {

                checkDefault.Enabled = true;
                Settings.SaveInSetting(SettingSaveFileName, parentName, "DefaultFile", FileAdress.Text);
                    Settings.SaveInSetting(SettingSaveFileName, parentName, "isDefault", "true");
                }
            
        }
    }
}
