using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactSaver.AllExtraForm
{
    public partial class ShowContactsInWelcomeMenu : Form
    {
        public ShowContactsInWelcomeMenu()
        {
            InitializeComponent();
            new MoveClass(this).MakeFromDraggableViaControl();
        }

        

        private void DismisB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
