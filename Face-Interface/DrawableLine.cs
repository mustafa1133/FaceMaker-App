using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face_Interface
{
    public class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color aColor, Point aLineStart, Point aLineEnd)
        {
            color = aColor;
            lineStart = aLineStart;
            lineEnd = aLineEnd;
        }



        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, lineStart, lineEnd);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"color={color}   Start Point={lineStart}    End Point={lineEnd}");
        }
    }
}
