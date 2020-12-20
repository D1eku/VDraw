using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VDraw
{
    public class VDWRectangle : VDWFigure
    {
        private float width;
        private float height;
        public VDWRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height)
            : base(lineColor, fillColor, lineSize, center)
        {
            this.width = width;
            this.height = height;
        }
        public float GetWidth()
        {
            return width;
        }
        public float GetHeight()
        {
            return height;
        }
        public void ChangeWidth(float width)
        {
            this.width = width;
        }
        public void ChangeHeight(float height)
        {
            this.height = height;
        }
    }
}
