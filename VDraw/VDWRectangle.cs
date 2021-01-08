using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VDraw
{
    public class VDWRectangle : VDWFigure
    {
        private float width;
        private float height;
        public VDWRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height, GraphicsPath gp)
            : base(lineColor, fillColor, lineSize, center, gp)
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


        public override bool dentro(Point p)
        {
            
            if (this.gp.IsOutlineVisible(p, new Pen(Color.DarkViolet)))
            {
                Console.WriteLine("Dentro de la figura");
                return true;
            }
            else
            {
                Console.WriteLine("Fuera de la figura");
                return gp.IsVisible(p);
            }
        }
    }
}
