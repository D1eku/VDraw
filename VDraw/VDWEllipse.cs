using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VDraw
{
    public class VDWEllipse : VDWFigure
    {
        private float a;
        private float b;
        public VDWEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b)
            : base(lineColor, fillColor, lineSize, center)
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
    }
}
