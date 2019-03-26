using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* implemented 24.2.2019 */
namespace ContactSaver
{
    public partial class CustomeDialogBox : Form
    {   /*-------------------Declaration---------------------*/
        private bool ClickClose;
        
        /*-----------------End Declaration-----------------------*/

            /*--------------Cons-------------*/
        public CustomeDialogBox()
        {
            InitializeComponent();
           
        }
        public CustomeDialogBox(String Message,bool MakeDragable, bool oncloseClick)  //added 26.2.2019 for more flex
        {
            InitializeComponent();
            if (MakeDragable)
            {
                new MoveClass(this).MakeFromDraggableViaControl();
            }
            if (oncloseClick)
            {
                ClickClose = true;
            }
            NotificationText.Text = Message;
        }
        public CustomeDialogBox(string message,bool ClickClose)     // added 25.2.2019 for custome message purepose
        {
            InitializeComponent();
            NotificationText.Text = message;
            this.ClickClose = ClickClose;
        }
        

        /*-------------------------End Cons--------------------*/


        /*------------------------------Method Group-------------------------------*/
        public void showMessage(string Message)
        {
            NotificationText.Text = Message;
            
        }
        private void DismisB_Click(object sender, EventArgs e)
        {
            if (ClickClose)
            {
                this.Close();
               
            }
            else
            {
                
                this.Hide();
            }
        }
        


        /*-----------------------------------End Method-------------------------*/
    }
}
