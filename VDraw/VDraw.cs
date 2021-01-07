using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
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
                else
                {
                    vDraw.DrawPolygon(Color.Black, Color.Transparent, 6, new Point(mouseX, mouseY), 45f, 0f, 6);
                }

            }
        }

        /*Esta funcion es para cargar o abrir un archivo con formato .vdraw */
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();//Abre un nuevo cuadro de dialogo para abrir archivo
            open.Filter = "VDraw Files | *.vdraw";//Define el filtro de archivos que mostrara, es decir los formatos en este caso solo "vdraw"
            
            if(open.ShowDialog() == DialogResult.OK)//Si se eligio el archivo a abrir y se pulso aceptar, entonces...
            {
                //Cargalo
            }
        }

        /*Esta funcion es para guardar un archivo con formato .vdraw Es decir, para guardar proyectos*/
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();//Crea un cuadro de dialogo para guardar archivo
            save.Filter = "VDraw files| *.vdraw";//Los formatos permitidos son

            if(save.ShowDialog() == DialogResult.OK)//Si se pulso aceptar.
            {
                //Hace las cosas para guardar el archivo.
            }
        }

        
        /*Limpia el lienzo para empezar a dibujar nuevamente. */
        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vDraw.NewPaint();
        }

        /* Esta funcion exporta el dibujo a un archivo png o jpg como foto */
        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panelCanvas.Width, panelCanvas.Height);//Crea un bitmap del tamaño del canvas
            Graphics setPaint = Graphics.FromImage(bm);//Obten un graphics para el bitmap
            Rectangle rect = panelCanvas.RectangleToScreen(panelCanvas.ClientRectangle);//CREA un rectangulo del tamaño del canvas 
            setPaint.CopyFromScreen(rect.Location, Point.Empty, panelCanvas.Size);//Dibuja desde el rectangulo
            //panelCanvas.Dispose();

            SaveFileDialog save = new SaveFileDialog();//Crea un cuadro de dialogo para guardar archivo
            save.Filter = "Png files| *.png| jpeg files| *jpg";//Los formatos permitidos son

            if (save.ShowDialog() == DialogResult.OK)//Si se apreto save, entonces
            {
                try
                {
                    if (File.Exists(save.FileName))//Si ya existe el archivo 
                    {
                        File.Delete(save.FileName);//Eliminalo
                    }
                    //Luego
                    if (save.FileName.Contains(".jpg"))//Si se quiere guardar como jpg
                    {
                        bm.Save(save.FileName, ImageFormat.Jpeg);
                    }
                    else if (save.FileName.Contains(".png"))//Si se quiere guardar como png
                    {
                        bm.Save(save.FileName, ImageFormat.Png);
                    }
                    else//Aqui si no se selecciono el formato escribiendolo, entonces
                    {//Se guarda como 
                        if(save.FilterIndex == 0)//PNG
                        {
                            bm.Save(save.FileName + ".png" , ImageFormat.Png);
                        }
                        else//JPG
                        {
                            bm.Save(save.FileName + ".jpg", ImageFormat.Jpeg);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File save error : " + ex.Message);
                }
            }
        }
        /* Selecciona la figura seleccionada y la setea como 1 o Circulo*/
        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            shapeSelected = 1;
        }
        /* Selecciona la figura seleccionada y la setea como 2*/
        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            shapeSelected = 2;
        }
        /* Selecciona la figura seleccionada y la setea como 3*/
        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            shapeSelected = 3;
        }
        /* Selecciona la figura seleccionada y la setea como 4*/
        private void ButtonRect_Click(object sender, EventArgs e)
        {
            shapeSelected = 4;
        }
        /* Selecciona la figura seleccionada y la setea como 5*/
        private void ButtonDiamond_Click(object sender, EventArgs e)
        {
            shapeSelected = 5;
        }
        /* Selecciona la figura seleccionada y la setea como 6*/
        private void ButtonTriangle_Click(object sender, EventArgs e)
        {
            shapeSelected = 6;
        }
        /* Selecciona la figura seleccionada y la setea como 7*/
        private void ButtonPentagon_Click(object sender, EventArgs e)
        {
            shapeSelected = 7;
        }
        /* Selecciona la figura seleccionada y la setea como 8*/
        private void ButtonHexagon_Click(object sender, EventArgs e)
        {
            shapeSelected = 8;
        }
        //Funcion que convierte un panel a BitMap y retorna el Objeto Image
        private static Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
    }
}
