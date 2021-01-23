using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VDraw
{
    public abstract class VDWFigure
    {
        private Color lineColor;
        private Color fillColor;
        private float lineSize;
        private bool Selected;
        private Point center;
        private GraphicsPath gp;

        protected VDWFigure(Color lineColor, Color fillColor, float lineSize, Point center, GraphicsPath gp)
        {
            this.gp = gp;
            this.lineColor = lineColor;
            this.fillColor = fillColor;
            this.lineSize = lineSize;
            this.Selected = false;
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
        public void ChangeCenter(Point center)
        {
            this.center = center;
        }
        public bool IsSelected(Point p)
        {
            Selected = gp.IsVisible(p);
            return Selected;
        }
        public bool IsSelected()
        {
            return Selected;
        }

        public abstract void Move(Point center);

        public GraphicsPath GetGraphicsPath()
        {
            return gp;
        }

        public void SetGraphicsPath(GraphicsPath gp) { this.gp = gp; }

        public void SetSelected(bool state) { this.Selected = false; }

        public abstract GraphicsPath GetPathContornShape();
    }
}
