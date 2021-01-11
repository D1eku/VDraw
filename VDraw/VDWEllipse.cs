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

        public override void Move(Point center)
        {
            if (base.IsSelected())//Si eres una figura seleccionada
            {
                base.ChangeCenter(center);
                GraphicsPath gp = base.GetGraphicsPath();
                gp.Reset();
                gp.StartFigure();//Comienza a dibujar
                gp.AddEllipse(center.X - a, center.Y - b, 2 * a, 2 * b);//Dibuja
                gp.CloseFigure();//Termina la figura
            }
        }
        public string ToString()
        {
            return "E," + this.GetLineColor().ToArgb() + "," + this.GetFillColor().ToArgb() + "," + this.GetLineSize() + "," + this.GetCenter().X + "," + this.GetCenter().Y
                + "," + this.a + "," + this.b;
        }
    }
}
