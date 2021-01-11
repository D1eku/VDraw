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

        public override void Move(Point center)
        {
            if (base.IsSelected())//Si eres una figura seleccionada
            {
                base.ChangeCenter(center);
                GraphicsPath gp = base.GetGraphicsPath();
                gp.Reset();
                gp.StartFigure();//Comienza a dibujar
                RectangleF rect = new RectangleF(center.X - width, center.Y - height, 2 * width, 2 * height);
                gp.AddRectangle(rect);
                gp.CloseFigure();//Termina la figura
            }
        }
        public string ToString()
        {
            return "R," + this.GetLineColor().ToArgb() + "," + this.GetFillColor().ToArgb() + "," + this.GetLineSize() + "," + this.GetCenter().X + "," + this.GetCenter().Y
                + "," + this.width + "," + this.height;
        }
    }
}
