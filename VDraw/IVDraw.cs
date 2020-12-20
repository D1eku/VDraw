using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VDraw
{
    interface IVDraw
    {
        void DrawRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height);
        void DrawEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b);
        void DrawPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides);
    }
}
