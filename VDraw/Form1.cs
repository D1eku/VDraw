using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VDraw
{
    public partial class MasterUIVDraw : Form
    {
        IVDraw vDraw;
        int shapeSelected;
        int mouseX;
        int mouseY;
        bool mouseDown;
        public MasterUIVDraw()
        {
            InitializeComponent();
            vDraw = new VDrawImpl(panelCanvas);
            shapeSelected = 0;
            mouseX = 0;
            mouseY = 0;
            mouseDown = false;
        }
        private void asadasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
            if (shapeSelected == 0)
            {
                Point p = panelCanvas.PointToClient(Cursor.Position);
                vDraw.Movement(p, e);
                panelCanvas.Invalidate();
                
            }
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            shapeSelected = 1;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            shapeSelected = 2;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            shapeSelected = 3;
        }

        private void buttonRectangulo_Click(object sender, EventArgs e)
        {
            shapeSelected = 4;
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            shapeSelected = 5;
        }

        private void botonTriangulo_Click(object sender, EventArgs e)
        {
            shapeSelected = 6;
        }

        private void buttonPentagono_Click(object sender, EventArgs e)
        {
            shapeSelected = 7;
        }

        private void hexagonButton_Click(object sender, EventArgs e)
        {
            shapeSelected = 8;
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                //Move
                if (shapeSelected == 0)
                {          
                    
                    
                }

                // Circle
                if (shapeSelected == 1)
                {
                    vDraw.DrawEllipse(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 45f);
                }
                //Ellipse
                else if (shapeSelected == 2)
                {
                    vDraw.DrawEllipse(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 60f, 30f);
                }
                //Square
                else if (shapeSelected == 3)
                {
                    vDraw.DrawRectangle(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 45f);
                }
                //Rectangle
                else if (shapeSelected == 4)
                {
                    vDraw.DrawRectangle(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 60f, 30f);
                }
                //Diamond
                else if (shapeSelected == 5)
                {
                    vDraw.DrawPolygon(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 0f, 4);
                }
                //Triangle
                else if (shapeSelected == 6)
                {
                    vDraw.DrawPolygon(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 90f, 3);
                }
                //Pentagon
                else if (shapeSelected == 7)
                {
                    vDraw.DrawPolygon(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 18.5f, 5);
                }
                //Hexagon
                else if (shapeSelected == 8)
                {
                    vDraw.DrawPolygon(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 0f, 6);
                }

            }
        }

        private void PanelCanvas_MouseMove(object sender, MouseEventArgs ae)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            shapeSelected = 0;
        }

        private void panelCanvas_Paint_1(object sender, PaintEventArgs e)
        {
            vDraw.rePaint();
        }
    }
}
