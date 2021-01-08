using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VDraw
{
    public class VDWEllipse : VDWFigure
    {
        private float a;
        private float b;
        public VDWEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b, GraphicsPath gp)
            : base(lineColor, fillColor, lineSize, center, gp)
        {
            this.a = a;
            this.b = b;
        }
        public float GetA()
        {
            return a;
        }
        public float GetB()
        {
            return b;
        }
        public void ChangeA(float a)
        {
            this.a = a;
        }
        public void ChangeHeight(float b)
        {
            this.b = b;
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
