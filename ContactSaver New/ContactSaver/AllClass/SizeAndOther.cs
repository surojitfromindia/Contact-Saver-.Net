using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactSaver
{
    /* implemented 24.2.2019*/
    class SizeAndOther
    {
        public void FromAutoSizeChange(Form form)
        {
            int height = getHeight(form);
            int width = getWidth(form);


        }
        public int getHeight(Form from)
        {
            int Height = from.Height;

            return Height;

        }
        public int getWidth(Form from)
        {
            int Width = from.Width;

            return Width;

        }
    }
}
