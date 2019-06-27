using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color aColor, Point start, Point first, Point second, Point end)
        {
            color = aColor;
            start = curveStart;
            first = controlFirst;
            second = controlSecond;
            end = curveEnd;

        }


        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawBezier(pen, curveStart, controlFirst, controlSecond, curveEnd);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"color={color}   Start Point={curveStart}    Control Point 1={controlFirst}    Control Point 2={controlSecond}    end={curveEnd}");
        }
    }
}
