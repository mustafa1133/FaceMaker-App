using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public class DrawableEllipse : Primitive, IDrawable
    {
        public DrawableEllipse(Color aColor, bool aFilled, Rectangle aRectangle) : base(aColor, aFilled, aRectangle)
        {

        }





        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, boundingRectangle);
            }

            else
            {
                Pen pen = new Pen(color);
                g.DrawEllipse(pen, boundingRectangle);
            }
        }
    }
}

