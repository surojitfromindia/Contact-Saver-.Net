using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContactSaver
{
    class XmlMethods
    {
       
       
        [Obsolete]
        public static void LoadXDocumnet()
        {
            try {
                XDocument doc = XDocument.Load("contact.xml");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                creatXmlDocument("contact.xml");
            }
            
        }
        
        /** New */
        /* implemented 24.2.2019*/
        public static void LoadXDocumnet(string filename)
        {
            try
            {
                XDocument doc = XDocument.Load(filename);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("The file " + filename + " not found create a new One");
                
                creatXmlDocument(filename);
            }
            catch (XmlException ex)
            {
               
                MessageBox.Show("Error! \n File Corrupted \n Make New One as Same Name");

                creatXmlDocument(filename);
            }
        }

        public static void InsertNewField(string fileName,string Name,string Number,
            string WhatsAppNumber)
        {
            XDocument contact = XDocument.Load(fileName);

            XElement newElement = new XElement("Contact",
                new XAttribute("Name", MissL.CapitalWord(Name,0)), //MissL added 26.2.2019 Captial First Word Before Saving.
                new XElement("Number", Number),
                new XElement("WhatsAppNumber", WhatsAppNumber)
                );

            contact.Descendants("Contacts").First().Add(newElement);

            contact.Save(fileName);
        }
        //now search using query in xml
        public static void GetTheNumber(string fileName,TextBox textBox)
        {
            // Load current document.
            XDocument inventoryDoc = XDocument.Load(fileName);
            // Find the colors for a given make.
            var makeInfo = from contact in inventoryDoc.Descendants("Contact")
                           where (string)contact.FirstAttribute== textBox.Text

                           select contact.Element("Number").Value;
            // Build a string representing each color.
            string data = string.Empty;
            foreach (var item in makeInfo.Distinct())
            {
                data += string.Format("- {0}\n", item);
            }
            // Show colors.
            MessageBox.Show(data, string.Format("{0} Numbers:",textBox.Text ));
        }
        /* Implemented 23.2.2019 */
        public static string GetTheNumber(string fileName,ListBox li)
        {
            ;
            // Load current document.
            XDocument inventoryDoc = XDocument.Load(fileName);
            // Find the colors for a given make.
            var makeInfo = from contact in inventoryDoc.Descendants("Contact")
                           where (string)contact.FirstAttribute == li.SelectedItem.ToString() select contact.Element("Number").Value;
            // Build a string representing each color.
            string data = string.Empty;
            foreach (var item in makeInfo.Distinct())
            {
                data += string.Format("{0}\n", item);
            }
            return data;


        }
        public static string GetTheWhatsappNumber(string fileName, ListBox li)
        {
            ;
            // Load current document.
            XDocument inventoryDoc = XDocument.Load(fileName);
            // Find the colors for a given make.
            var makeInfo = from contact in inventoryDoc.Descendants("Contact")
                           where (string)contact.FirstAttribute == li.SelectedItem.ToString()
                           select contact.Element("WhatsAppNumber").Value;
            // Build a string representing each color.
            string data = string.Empty;
            foreach (var item in makeInfo.Distinct())
            {
                data += string.Format("{0}\n", item);
            }
            return data;


        }

        public static void DeleteField(String fileName,String Name)
        {

            //april 17, 2018 method implemrnted
            XDocument inventorydoc = XDocument.Load(fileName);
         var namestodelete = from contact in inventorydoc.Descendants("Contact")
                                where (string)contact.FirstAttribute == Name
                                select contact; //only use implict type
            namestodelete.Remove();
            inventorydoc.Save(fileName);

                               
        }

        public static List<string> getTheNames(string fileName)
        {

            //april 14,2018 method implemented
            //load the file
            XDocument inventoryDoc = XDocument.Load(fileName);


            //fetch the names from the xml file
          var  names = from contact in inventoryDoc.Descendants("Contact")
                       select contact.FirstAttribute.Value; //very importent

            //declare new List return this List
            List<string> Names = new List<string>(100);

            //add each names in Names List
            foreach(var item in names.Distinct()) //must use Distinct for un duplicated result
            {
                Names.Add(item.ToString());
            }
            //return the Names List.
            return Names;
            
        }

      
        /* create documnet if old one gets deletd */
        public static XDocument creatXmlDocument(string fileName)
        {
            //april 12,2018 method implemented
            XDocument xDocument = new XDocument(
                new XElement("Contacts",
                new XElement("Contact", new XAttribute("Name", "Person_Name"),
                new XElement("Number", "Person_Number"),
                new XElement("WhatsAppNumber", "Person_WhatsappNumber")
                )
                ));
            xDocument.Save(fileName);
            return xDocument;
        }

        public static int getNumberOfElement(string filename)
        {
            //implemented april 20, 2018


            if (filename == "")
            {
                return 0;
            }
            else
            {
                XDocument doc = XDocument.Load(filename);

                IEnumerable<string> names = from Contactlist in doc.Descendants("Contact").Distinct()
                                            select Contactlist.FirstAttribute.
                                            Value;

                List<String> DistinctNames = new List<string>();
                foreach (var n in names.Distinct())
                {
                    DistinctNames.Add(n);
                }
                int number = DistinctNames.Count;


                return number;
            }
        }
    }
}
