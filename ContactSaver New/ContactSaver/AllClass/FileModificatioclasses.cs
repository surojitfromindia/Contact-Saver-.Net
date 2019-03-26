using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactSaver
{
  public  class FileModificatioclasses
    {

        public static string fileAdrr = string.Empty;
        public static void BackUpFileToAnotherLoaction()
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                XDocument themainfile = XDocument.Load("contact.xml");
                string Path = "Default.xml";
                XDocument TheBackUpFile = new XDocument(themainfile);
                file.Title = "Save File";
                file.Filter = "Xml File (*.xml)|*.xml";
             //   file.InitialDirectory = "";
                file.RestoreDirectory = true;


                if (file.ShowDialog() == DialogResult.OK)
                {
                    Path = file.FileName; //the the file Path

                    TheBackUpFile.Save(Path);

                    MessageBox.Show("Back Up Successfull !", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }




            }
        }
        /* Implemented 23.2.2019 */
        public static string LoadNewFileFromEx()

        {
            
            using (OpenFileDialog FileDialog = new OpenFileDialog())
            {
                FileDialog.Title = "Open";
                FileDialog.Filter = "Xml File (*.xml)|*.xml";
                FileDialog.ShowDialog();
                string path = FileDialog.FileName;
                string fileNameOnly = FileDialog.SafeFileName;

                
                
               
               
               return path;
                
            }
        }
        


        public static string   LoadXMLFile_Click()
        {

            string p = FileModificatioclasses.LoadNewFileFromEx();
            MainForm.filename = p;
           
            return p;
            

        }
        
    }
}
