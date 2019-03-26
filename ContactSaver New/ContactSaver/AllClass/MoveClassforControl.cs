using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactSaver
{
   public class MoveClassforControl
    {
      public  Control ControlName;
        private bool isDraged;
        private Point Offset;
        public MoveClassforControl(Control Control)
        {
            this.ControlName = Control;

        }
        public void MakeFromDraggable()
        {

            ControlName.MouseDown += MouseDownEvent;
            ControlName.MouseMove += MouseMoveEvent;
            ControlName.MouseUp += MouseUpEvent;



        }

        private void MouseDownEvent(Object sender, MouseEventArgs e)
        {
            Offset = new Point(e.X, e.Y);
            Console.WriteLine("offset: {0} ,{1}", Offset.X, Offset.Y);
            isDraged = true;

        }
        private void MouseMoveEvent(Object sender, MouseEventArgs e)
        {
            if (isDraged)
            {
                Point currentLocation = ControlName.PointToScreen(e.Location);
                Console.WriteLine("curretlocatio {0} ,{1}", currentLocation.X, currentLocation.Y);
                ControlName.Location = new Point(currentLocation.X - Offset.X, currentLocation.Y - Offset.Y);
                Console.WriteLine("final {0} ,{1}", ControlName.Location.X, ControlName.Location.Y);
            }
        }

        public void MouseUpEvent(Object Sender, MouseEventArgs e)
        {
            isDraged = false;
        }

    }
}
