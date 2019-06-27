using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public abstract class Primitive
    {
        protected Color color;
        protected bool filled;
        protected Rectangle boundingRectangle;

        public Primitive(Color aColor, bool aFilled, Rectangle aBoundingRectangle)
        {
            color = aColor;
            filled = aFilled;
            boundingRectangle = aBoundingRectangle;
        }
    }
}