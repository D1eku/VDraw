using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VDraw
{
    public class VDWPolygon : VDWFigure
    {
        private float radius;
        private float startAngle;
        private int sides;
        public VDWPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides)
            : base(lineColor, fillColor, lineSize, center)
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
    }
}
