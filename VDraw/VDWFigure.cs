using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace VDraw
{
    public abstract class VDWFigure
    {
        private Color lineColor;
        private Color fillColor;
        private float lineSize;
        private bool isDrag;
        private Point center;
        protected GraphicsPath gp;

        protected VDWFigure(Color lineColor, Color fillColor, float lineSize, Point center, GraphicsPath gp)
        {
            this.gp = gp;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.lineSize = lineSize;
            this.isDrag = false;
            this.center = center;
        }
        public Color GetLineColor()
        {
            return this.lineColor;
        }
        public Color GetFillColor()
        {
            return this.fillColor;
        }
        public float GetLineSize()
        {
            return this.lineSize;
        }
        public bool IsDrag()
        {
            return isDrag;
        }
        public Point GetCenter()
        {
            return center;
        }
        public void ChangeLineColor(Color lineColor)
        {
            this.lineColor = lineColor;
        }
        public void ChangeFillColor(Color fillColor)
        {
            this.fillColor = fillColor;
        }
        public void ChangeLineSize(float lineSize)
        {
            this.lineSize = lineSize;
        }
        public void OnDrag(bool isDrag)
        {
            this.isDrag = isDrag;
        }
        public void ChangeCenter(Point center)
        {
            this.center = center;
        }
        public void Mover(int dx, int dy)
        {
            gp.Transform(new Matrix(1, 0, 0, 1, dx, dy));
         
        }
        public abstract Boolean dentro(Point p);
        


    }
}
