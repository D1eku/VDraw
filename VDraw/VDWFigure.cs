using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VDraw
{
    public abstract class VDWFigure
    {
        private Color lineColor;
        private Color fillColor;
        private float lineSize;
        private bool isDrag;
        private Point center;

        protected VDWFigure(Color lineColor, Color fillColor, float lineSize, Point center)
        {
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
    }
}
