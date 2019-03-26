using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ContactSaver
{
    // Implemented April 18, 2018
    //reworked April 20,2018...new method add
    //reworked April 21,2018 ...The Extra method remove using compact constuct
    //TODO: Add new Constuct to a from using multipel component
    public class MoveClass
    {
       private Form ParentFrom;
        private Form Child;
        private bool isDraged;
        private Point Offset;
        private Control ControlToDragedd;
        private Point currentLocation;



        public MoveClass(Form formName)
        {
            this.ParentFrom = formName;
            ControlToDragedd = formName;
            
        }

        public MoveClass(Form form,Control ControlToDragedd)
        {
            this.ParentFrom = form;
            this.ControlToDragedd = ControlToDragedd;
        }
        public MoveClass(Form Parent, Form Child,Control ControlToDragedd)
        {
            this.ControlToDragedd = ControlToDragedd;
            this.ParentFrom = Parent;
            this.Child = Child;
        }




        public void MakeFromDraggableViaControl()
        {
            ControlToDragedd.MouseDown += MouseDownEvent;
            ControlToDragedd.MouseMove += MouseMoveEventForOtherControl;
  
           ControlToDragedd.MouseUp += MouseUpEvent;
        }
        public void MakeFromDraggableViaControlOr()
        {
            ControlToDragedd.MouseDown += MouseDownEvent;
            ControlToDragedd.MouseMove += MouseMoveEventForOtherControlOr;

            ControlToDragedd.MouseUp += MouseUpEvent;
        }

        
        private  void MouseDownEvent(Object sender,MouseEventArgs e)
        {
            Offset = new Point(e.X,e.Y); //recode the mouse position
            isDraged = true;
          

        }

        private void MouseMoveEventForOtherControlOr(Object sender, MouseEventArgs e)
        {
            if (isDraged)
            {
                currentLocation = ControlToDragedd.PointToScreen(e.Location);
                ParentFrom.Location = new Point(currentLocation.X - Offset.X, currentLocation.Y - Offset.Y);
             


            }
        }
        public void MouseUpEvent(Object Sender,MouseEventArgs e)
        {
            isDraged = false;
        }
        private void MouseMoveEventForOtherControl(Object sender,MouseEventArgs e)
        {
            if (isDraged)
            {
                currentLocation = ControlToDragedd.PointToScreen(e.Location);
                ParentFrom.Location = new Point(currentLocation.X - Offset.X, currentLocation.Y - Offset.Y);
                Child.Location = new Point(ParentFrom.Location.X,ParentFrom.Location.Y+ParentFrom.Height);
             

            }
        }
       
        public void FroLocation()
        {

        }
        
    }
}
