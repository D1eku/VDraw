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
        public override void Move(Point center)
        {
            if (base.IsSelected())//Si eres una figura seleccionada
            {
                base.ChangeCenter(center);
                GraphicsPath gp = base.GetGraphicsPath();
                gp.Reset();
                gp.StartFigure();//Comienza a dibujar
                gp.AddPolygon(CalculateVertices(startAngle, radius, center, sides));//Dibuja un polygono por cada vertice
                gp.CloseFigure();//Termina de dibujar
            }
        }

        private Point[] CalculateVertices(float startAngle, float radius, Point center, int sides)
        {
            float angle = startAngle;
            float step = 360.0f / sides;
            List<Point> vertices = new List<Point>();
            for (double i = startAngle; i < startAngle + 360.0f; i += step)
            {
                vertices.Add(CalculateXY(angle, radius, center));
                angle += step;
            }
            return vertices.ToArray();
        }
        private Point CalculateXY(float degrees, float radius, Point center)
        {
            Point p = new Point();
            double radians = degrees * Math.PI / 180.0;

            p.X = (int)(Math.Cos(radians) * radius + center.X);
            p.Y = (int)(Math.Sin(-radians) * radius + center.Y);

            return p;
        }
        public string ToString()
        {
            return "P," + this.GetLineColor().ToArgb() + "," + this.GetFillColor().ToArgb() + "," + this.GetLineSize() + "," + this.GetCenter().X + "," + this.GetCenter().Y
                + "," + this.radius + "," + this.startAngle + "," + this.sides;
        }
    }
}
