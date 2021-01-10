using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VDraw
{
    class VDrawImpl : IVDraw
    {
        private List<VDWFigure> figures;
        private Graphics canvas;
        private Panel panelCanvas;
        private int penSize = 100;
        private Color penColor = Color.Black;
        private Pen pen;
        private Color brushColor = Color.White;
        private SolidBrush brush;
        private VDWFigure selectedShape = null;

        public VDrawImpl(Panel p)
        {
            figures = new List<VDWFigure>();
            panelCanvas = p;//Almacena el panel que se utiliza como lienzo.
            canvas = p.CreateGraphics();
            pen = new Pen(penColor, penSize);
            brush = new SolidBrush(brushColor);
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.SmoothingMode = SmoothingMode.HighQuality;
        }
        public void DrawRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height)
        {
            GraphicsPath gp = new GraphicsPath();//Crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            RectangleF rect = new RectangleF(center.X - width, center.Y - height, 2 * width, 2 * height);
            gp.AddRectangle(rect);
            gp.CloseFigure();//Termina la figura
            VDWRectangle r = new VDWRectangle(penColor, brushColor, lineSize, center, width, height, gp);
            figures.Add(r);
        }
        public void DrawEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b)
        {//Al dibujar una elipse
            //Pen pen = new Pen(lineColor, lineSize);//DEFINE el color de la linea y el tamaño de la linea.
            GraphicsPath gp = new GraphicsPath();//Crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            gp.AddEllipse(center.X - a, center.Y - b, 2 * a, 2 * b);//Dibuja
            gp.CloseFigure();//Termina la figura
            VDWEllipse e = new VDWEllipse(penColor, brushColor, lineSize, center, a, b, gp);//Crea un nuevo objeto para almacenar la figura y sus datos
            figures.Add(e);//Agrega la figura a la lista de figuras.
        }
        public void DrawPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides)
        {//Al dibujar un polygono
            GraphicsPath gp = new GraphicsPath();//crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            gp.AddPolygon(CalculateVertices(startAngle, radius, center, sides));//Dibuja un polygono por cada vertice
            gp.CloseFigure();//Termina de dibujar
            VDWPolygon p = new VDWPolygon(penColor, brushColor, lineSize, center, radius, startAngle, sides, gp);
            p.SetSelected(true); figures.Add(p);//Agrega la figura a la lista de figuras.
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
        public void NewPaint()
        {
            figures.Clear();//Elimina todas las figuras que hay en la lista
        }
        public bool IsTouchingShape(Point mouseClick)
        {
            for(int i = 0; i<this.figures.Count; i++)//Con cada figura que haya 
            {
                VDWFigure f = figures.ElementAt<VDWFigure>(i);//toma la i-esima figura
                if (f.IsSelected(mouseClick))//revisa si esa figura es tocada en el punto indicado
                {//Si lo es entonces
                    selectedShape = f;
                    return true;//Retorna si
                }
            }
            selectedShape = null;
            return false;//Si no tocaste ninguna figura retorna que no.
        }
        public void RePaint()
        {
            for (int i = 0; i < this.figures.Count; i++)
            {
                VDWFigure f = figures.ElementAt<VDWFigure>(i);
                GraphicsPath gp = f.GetGraphicsPath();
                canvas.DrawPath(new Pen(f.GetLineColor(), f.GetLineSize()), gp);
            }
        }
        public void MoveShape(Point x)
        {
            VDWFigure f = selectedShape;

            if(f != null)//Si hay una figura, muevela.
            {
                f.Move(x);
            }
            else
            {
                return;
            }
        }
        public void DeselectFigures()
        {
            for (int i = 0; i < this.figures.Count; i++)
            {
                VDWFigure f = figures.ElementAt<VDWFigure>(i);//Por cada figura
                if (f.IsSelected())//Si tienes una figura seleccionada 
                {
                    f.SetSelected(false);
                }
            }
        }
        public bool HaveSelected() { return selectedShape != null; }
        public void DeselectShape() { selectedShape = null; }
        public void ChangeColorPen(Color color)
        {
            penColor = color;
        }
        public void ChangeColorBrush(Color color)
        {
            brushColor = color;
        }

    }
}
