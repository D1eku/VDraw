using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.Win32;

namespace VDraw
{
    class VDrawImpl : IVDraw
    {
        private List<VDWFigure> figures;
        private Graphics canvas;
        private int penSize = 100;
        private VDWFigure selectedShape = null;

        public VDrawImpl(Panel p)
        {
            figures = new List<VDWFigure>();
            canvas = p.CreateGraphics();
            canvas.SmoothingMode = SmoothingMode.AntiAlias;
            canvas.SmoothingMode = SmoothingMode.HighQuality;
            this.RegisterKey();
        }
        public void DrawRectangle(Color lineColor, Color fillColor, float lineSize, Point center, float width, float height)
        {
            GraphicsPath gp = new GraphicsPath();//Crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            RectangleF rect = new RectangleF(center.X - width, center.Y - height, 2 * width, 2 * height);
            gp.AddRectangle(rect);
            gp.CloseFigure();//Termina la figura
            VDWRectangle r = new VDWRectangle(lineColor, fillColor, lineSize, center, width, height, gp);
            figures.Add(r);
        }
        public void DrawEllipse(Color lineColor, Color fillColor, float lineSize, Point center, float a, float b)
        {//Al dibujar una elipse
            //Pen pen = new Pen(lineColor, lineSize);//DEFINE el color de la linea y el tamaño de la linea.
            GraphicsPath gp = new GraphicsPath();//Crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            gp.AddEllipse(center.X - a, center.Y - b, 2 * a, 2 * b);//Dibuja
            gp.CloseFigure();//Termina la figura
            VDWEllipse e = new VDWEllipse(lineColor, fillColor, lineSize, center, a, b, gp);//Crea un nuevo objeto para almacenar la figura y sus datos
            figures.Add(e);//Agrega la figura a la lista de figuras.
        }
        public void DrawPolygon(Color lineColor, Color fillColor, float lineSize, Point center, float radius, float startAngle, int sides)
        {//Al dibujar un polygono
            GraphicsPath gp = new GraphicsPath();//crea un nuevo graphics path
            gp.StartFigure();//Comienza a dibujar
            gp.AddPolygon(CalculateVertices(startAngle, radius, center, sides));//Dibuja un polygono por cada vertice
            gp.CloseFigure();//Termina de dibujar
            VDWPolygon p = new VDWPolygon(lineColor, fillColor, lineSize, center, radius, startAngle, sides, gp);
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
            canvas.Clear(Color.White);
            for (int i = 0; i < this.figures.Count; i++)
            {
                VDWFigure f = figures.ElementAt<VDWFigure>(i);
                GraphicsPath gp = f.GetGraphicsPath();
                Pen pen = new Pen(f.GetLineColor(), f.GetLineSize());
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                canvas.DrawPath(pen, gp);
                canvas.FillPath(new SolidBrush(f.GetFillColor()), gp); 
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
        public string SaveFile()
        {
            string resp = "";
            foreach (VDWFigure f in figures)
            {
                if (f.GetType() == typeof(VDWRectangle))
                {
                    VDWRectangle r = (VDWRectangle)f;
                    resp += r.ToString() + "\n";
                }
                else if (f.GetType() == typeof(VDWEllipse))
                {
                    VDWEllipse e = (VDWEllipse)f;
                    resp += e.ToString() + "\n";
                }
                else
                {
                    VDWPolygon p = (VDWPolygon)f;
                    resp += p.ToString() + "\n";
                }
            }
            if (resp.Length > 0)
            {
                resp = resp.Substring(0, resp.Length - 1);
            }
            return resp;
        }
        public void OpenFile(string file)
        {
            NewPaint();
            try
            {
                StreamReader sr = new StreamReader(file, System.Text.Encoding.Default);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split(',');
                    if (split[0] == "R")
                    {
                        if (split[2] != "Transparent")
                        {
                            DrawRectangle(Color.FromArgb(int.Parse(split[1])), Color.FromArgb(int.Parse(split[2])), float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]));
                        }
                        else
                        {
                            DrawRectangle(Color.FromArgb(int.Parse(split[1])), Color.Transparent, float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]));
                        }

                    }
                    else if (split[0] == "E")
                    {
                        if (split[2] != "Transparent")
                        {
                            DrawEllipse(Color.FromArgb(int.Parse(split[1])), Color.FromArgb(int.Parse(split[2])), float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]));
                        }
                        else
                        {
                            DrawEllipse(Color.FromArgb(int.Parse(split[1])), Color.Transparent, float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]));
                        }
                    }
                    else
                    {
                        if (split[2] != "Transparent")
                        {
                            DrawPolygon(Color.FromArgb(int.Parse(split[1])), Color.FromArgb(int.Parse(split[2])), float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]), int.Parse(split[8]));
                        }
                        else
                        {
                            DrawPolygon(Color.FromArgb(int.Parse(split[1])), Color.Transparent, float.Parse(split[3]), new Point(int.Parse(split[4]), int.Parse(split[5])), float.Parse(split[6]), float.Parse(split[7]), int.Parse(split[8]));
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                this.RePaint();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File open error: " + ex.Message);
            }
        }
        public void RegisterKey()
        {
            RegistryKey c1 = Registry.CurrentUser.OpenSubKey("Software", true);
            c1.CreateSubKey("Classes");
            c1 = c1.OpenSubKey("Classes", true);
            c1.CreateSubKey(".vdw");
            c1 = c1.OpenSubKey(".vdw", true);
            c1.SetValue("", "archivo.vdw");
            c1.Close();

            RegistryKey c2 = Registry.CurrentUser.OpenSubKey("Software", true);
            c2.CreateSubKey("Classes");
            c2 = c2.OpenSubKey("Classes", true);
            c2.CreateSubKey("archivo.vdw");
            c2 = c2.OpenSubKey("archivo.vdw", true);
            c2.SetValue("", "VDraw Proyect");
            c2.CreateSubKey("DefaultIcon");
            c2 = c2.OpenSubKey("DefaultIcon", true);
            c2.SetValue("", Application.StartupPath + "\\Icon\\VDW-Archivo.ico");
            c2.Close();

            RegistryKey c3 = Registry.CurrentUser.OpenSubKey("Software", true);
            c3.CreateSubKey("Classes");
            c3 = c3.OpenSubKey("Classes", true);
            c3.CreateSubKey("archivo.vdw");
            c3 = c3.OpenSubKey("archivo.vdw", true);
            c3.SetValue("", "VDraw Proyect");
            c3.CreateSubKey("shell");
            c3 = c3.OpenSubKey("shell", true);
            c3.CreateSubKey("open");
            c3 = c3.OpenSubKey("open", true);
            c3.CreateSubKey("command");
            c3 = c3.OpenSubKey("command", true);
            c3.SetValue("", "\"" + Application.StartupPath + "\\VDraw.exe\" \"%1\"");
            c3.Close();
        }

    }
}
