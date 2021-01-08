using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VDraw
{
    public class VDWPolygon : VDWFigure
    {
        private float radius;
        private float startAngle;
        private int sides;
        public VDWPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides, GraphicsPath gp)
            : base(lineColor, fillColor, lineSize, center, gp)
        {
            this.radius = radius;
            this.startAngle = startAngle;
            this.sides = sides;
        }
        public float GetRadius()
        {
            return this.radius;
        }
        public float GetStartAngle()
        {
            return this.startAngle;
        }
        public int GetSides()
        {
            return this.sides;
        }
        public void ChangeRadius(float radius)
        {
            this.radius = radius;
        }
        public void ChangeStartAngle(float startAngle)
        {
            this.startAngle = startAngle;
        }
        public void ChangeSides(int sides)
        {
            this.sides = sides;
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
