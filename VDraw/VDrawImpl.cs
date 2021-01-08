﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VDraw
{
    class VDrawImpl : IVDraw
    {
        private List<VDWFigure> figures;
        private Graphics canvas;
        private GraphicsPath gp;

        public VDrawImpl(Panel p)
        {
            figures = new List<VDWFigure>();
            canvas = p.CreateGraphics();
            gp = new GraphicsPath();
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }
        public void DrawRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height)
        {
            Point PI = new Point((int)((int)center.X - width), (int)(center.Y - height));
            Point PF = new Point((int)((int)center.X + width), (int)(center.Y + height));
            Size s = new Size((int)width * 2, (int)height * 2);
            Rectangle re = new Rectangle(center, s);
            Point[] vertices = { PI, center, PF };
            gp.AddRectangle(re);
            gp.CloseFigure();
            

            VDWRectangle r = new VDWRectangle(lineColor, fillColor, lineSize, center, width, height, gp);
            figures.Add(r);
            Pen pen = new Pen(lineColor, lineSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            SolidBrush brush = new SolidBrush(fillColor);

            //canvas.FillRectangle(brush, center.X - width, center.Y - height, 2 * width, 2 * height);

            canvas.DrawPath(pen, gp);

        }
        public void DrawEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b)
        {
            /*VDWEllipse e = new VDWEllipse(lineColor, fillColor, lineSize, center, a, b);
            figures.Add(e);
            Pen pen = new Pen(lineColor, lineSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            SolidBrush brush = new SolidBrush(fillColor);
            canvas.DrawEllipse(pen, center.X - a, center.Y - b, 2 * a, 2 * b);
            canvas.FillEllipse(brush, center.X - a, center.Y - b, 2 * a, 2 * b);*/
        }
        public void DrawPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides)
        {
            /*VDWPolygon p = new VDWPolygon(lineColor, fillColor, lineSize, center, radius, startAngle, sides);
            figures.Add(p);
            Pen pen = new Pen(lineColor, lineSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            SolidBrush brush = new SolidBrush(fillColor);
            Point[] vertices = CalculateVertices(startAngle, radius, center, sides);
            canvas.DrawPolygon(pen, vertices);
            canvas.FillPolygon(brush, vertices);*/
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

        public void Movement(Point p, MouseEventArgs ae)
        {
            foreach(VDWFigure item in figures)
            {
                if (item.dentro(p))
                {
                    VDWFigure aux = item;
                    Console.WriteLine("True");
                    aux.Mover(ae.Location.X - p.X, ae.Location.Y - p.Y);
                    p = ae.Location;
                }
            }
        }

        public void rePaint()
        {
            Pen pen = new Pen(Color.DarkViolet, 5);
            foreach (VDWFigure item in figures)
            {
                
                canvas.DrawPath(pen, gp);
            }
        }
    }
}
