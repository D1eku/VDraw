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
        bool Drawing;
        bool isSave;
        Color lineColor, fillColor;

        public MasterUIVDraw()
        {
            InitializeComponent();
            vDraw = new VDrawImpl(panelCanvas);
            shapeSelected = 0;
            mouseX = 0;
            mouseY = 0;
            mouseDown = false;
            lineColor = Color.Black;
            fillColor = Color.Transparent;
            Drawing = false;
            isSave = false;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)//Cuando haces click
        {
            mouseDown = true;//Informas que haces click
            mouseX = e.X;//Genera la informacion del mouse
            mouseY = e.Y;//Genera la otra informacion del mouse.
            Point p = new Point(mouseX, mouseY);//Genera un punto
            
            if (!vDraw.HaveSelected())//Si no tienes una figura seleccionada.
            {
                vDraw.IsTouchingShape(p);
            }
            panelCanvas.Invalidate();//Actualiz el panel
        }

        private void PanelCanvas_MouseMove(object sender, MouseEventArgs e)//Cuando mueves el mouse
        {
            Point p = new Point(e.X, e.Y);//Genera un punto
            if (mouseDown)//Si se esta haciendo click
            {
                if (vDraw.HaveSelected())// Y tienes una figura seleccionada.
                {
                    vDraw.MoveShape(p);//Muevela.
                    panelCanvas.Invalidate();//Actualiza el panel
                }

            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                isSave = false;
                if (Drawing)//Si estas dibujando.
                {
                    // Circle
                    if (shapeSelected == 1)
                    {
                        vDraw.DrawEllipse(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 45f);
                        
                    }
                    //Ellipse
                    else if (shapeSelected == 2)
                    {
                        vDraw.DrawEllipse(lineColor, fillColor, 6, new Point(mouseX, mouseY), 60f, 30f);
                        
                    }
                    //Square
                    else if (shapeSelected == 3)
                    {
                        vDraw.DrawRectangle(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 45f);
                        
                    }
                    //Rectangle
                    else if (shapeSelected == 4)
                    {
                        vDraw.DrawRectangle(lineColor, fillColor, 6, new Point(mouseX, mouseY), 60f, 30f);
                        
                    }
                    //Diamond
                    else if (shapeSelected == 5)
                    {
                        vDraw.DrawPolygon(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 0f, 4);
                        
                    }
                    //Triangle
                    else if (shapeSelected == 6)
                    {
                        vDraw.DrawPolygon(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 90f, 3);
                        
                    }
                    //Pentagon
                    else if (shapeSelected == 7)
                    {
                        vDraw.DrawPolygon(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 18.5f, 5);
                       
                    }
                    //Hexagon
                    else
                    {
                        vDraw.DrawPolygon(lineColor, fillColor, 6, new Point(mouseX, mouseY), 45f, 0f, 6);
                        
                    }
                    Drawing = false;//Deja de dibujar.
                }
            }

            vDraw.DeselectShape();
            panelCanvas.Invalidate();//Actualiza el panel
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            vDraw.RePaint();
        }

        /*Esta funcion es para cargar o abrir un archivo con formato .vdw */
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isSave)
                {
                    //Mensaje para sugerir guardar el proyecto antes de abrir otro
                    string message = "¿Quieres guardar los cambios del proyecto?";
                    string caption = "Guardar proyecto";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, caption, buttons);//Genera un cuadro con el mensaje y los botones Si, No y Cancelar
                    //En el caso de que quiera guardarlo
                    if (result == DialogResult.Yes)
                    {
                        this.GuardarToolStripMenuItem_Click(sender, e);//Enviamos al método para guardar
                    }
                    //En el caso de que no se quiera guardar abrimos el nuevo proyecto
                    else if (result == DialogResult.No)
                    {
                        OpenFileDialog open = new OpenFileDialog();//Abre un nuevo cuadro de dialogo para abrir archivo
                        open.Filter = "VDraw Proyect | *.vdw";//Define el filtro de archivos que mostrara, es decir los formatos en este caso solo "vdraw"
                        if (open.ShowDialog() == DialogResult.OK)//Si se eligio el archivo a abrir y se pulso aceptar, entonces...
                        {
                            vDraw.OpenFile(open.FileName);
                        }
                    }
                }
                else
                {
                    OpenFileDialog open = new OpenFileDialog();//Abre un nuevo cuadro de dialogo para abrir archivo
                    open.Filter = "VDraw Proyect | *.vdw";//Define el filtro de archivos que mostrara, es decir los formatos en este caso solo "vdraw"
                    if (open.ShowDialog() == DialogResult.OK)//Si se eligio el archivo a abrir y se pulso aceptar, entonces...
                    {
                        vDraw.OpenFile(open.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        /*Esta funcion es para guardar un archivo con formato .vdw Es decir, para guardar proyectos*/
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();//Crea un cuadro de dialogo para guardar archivo
                save.Filter = "VDraw Proyect | *.vdw";//Los formatos permitidos son

                if (save.ShowDialog() == DialogResult.OK)//Si se pulso aceptar.
                {
                    File.WriteAllText(save.FileName, vDraw.SaveFile());
                }
                isSave = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        /*Limpia el lienzo para empezar a dibujar nuevamente. */
        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isSave)
                {
                    //Mensaje para sugerir guardar el proyecto antes de abrir otro
                    string message = "¿Quieres guardar los cambios del proyecto?";
                    string caption = "Guardar proyecto";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, caption, buttons);//Genera un cuadro con el mensaje y los botones Si, No y Cancelar
                    //En el caso de que quiera guardarlo
                    if (result == DialogResult.Yes)
                    {
                        this.GuardarToolStripMenuItem_Click(sender, e);//Enviamos al método para guardar
                    }
                    //En el caso de que no se quiera guardar abrimos el nuevo proyecto
                    else if (result == DialogResult.No)
                    {
                        this.vDraw.NewPaint();
                        panelCanvas.Invalidate();//Actualiza el panel
                    }
                }
                else
                {
                    this.vDraw.NewPaint();
                    panelCanvas.Invalidate();//Actualiza el panel
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir un nuevo archivo: " + ex.Message);
            }
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
                    MessageBox.Show("Error al guardar el archivo : " + ex.Message);
                }
            }
        }
        /* Selecciona la figura seleccionada y la setea como 1 o Circulo*/
        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            shapeSelected = 1;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 2*/
        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            shapeSelected = 2;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 3*/
        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            shapeSelected = 3;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 4*/
        private void ButtonRect_Click(object sender, EventArgs e)
        {
            shapeSelected = 4;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 5*/
        private void ButtonDiamond_Click(object sender, EventArgs e)
        {
            shapeSelected = 5;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 6*/
        private void ButtonTriangle_Click(object sender, EventArgs e)
        {
            shapeSelected = 6;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 7*/
        private void ButtonPentagon_Click(object sender, EventArgs e)
        {
            shapeSelected = 7;
            Drawing = true;
        }
        /* Selecciona la figura seleccionada y la setea como 8*/
        private void ButtonHexagon_Click(object sender, EventArgs e)
        {
            shapeSelected = 8;
            Drawing = true;
        }
        //Funcion que convierte un panel a BitMap y retorna el Objeto Image
        private static Image PanelToBitmap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

        private void ChangeBorderColorPenBlack_Click(object sender, EventArgs e)
        {
            lineColor = Color.Black;
            this.buttonInfoColorSelected.BackColor = Color.Black;
        }

        private void ChangeBorderColorPenWhite_Click(object sender, EventArgs e)
        {
            lineColor = Color.White;
            this.buttonInfoColorSelected.BackColor = Color.White;
        }

        private void ChangeBorderColorPenRed_Click(object sender, EventArgs e)
        {
            lineColor = Color.Red;
            this.buttonInfoColorSelected.BackColor = Color.Red;
        }

        private void ChangeBorderColorPenGray_Click(object sender, EventArgs e)
        {
            lineColor = Color.Gray;
            this.buttonInfoColorSelected.BackColor = Color.Gray;
        }

        private void ChangeBorderColorPenBrown_Click(object sender, EventArgs e)
        {
            lineColor = Color.Brown;
            this.buttonInfoColorSelected.BackColor = Color.Brown;
        }

        private void ChangeBorderColorPenOrange_Click(object sender, EventArgs e)
        {
            lineColor = Color.Orange;
            this.buttonInfoColorSelected.BackColor = Color.Orange;
        }

        private void ChangeBorderColorPenYellow_Click(object sender, EventArgs e)
        {
            lineColor = Color.Yellow;
            this.buttonInfoColorSelected.BackColor = Color.Yellow;
        }

        private void ChangeBorderColorPenGreen_Click(object sender, EventArgs e)
        {
            lineColor = Color.Green;
            this.buttonInfoColorSelected.BackColor = Color.Green;
        }

        private void ChangeBorderColorPenBlue_Click(object sender, EventArgs e)
        {
            lineColor = Color.Blue;
            this.buttonInfoColorSelected.BackColor = Color.Blue;
        }

        private void ChangeBorderColorPenPurple_Click(object sender, EventArgs e)
        {
            lineColor = Color.Purple;
            this.buttonInfoColorSelected.BackColor = Color.Purple;
        }

        private void ChangeFilletColorPenBlack_Click(object sender, EventArgs e)
        {
            fillColor = Color.Black;
            this.buttonBrushColorSelected.BackColor = Color.Black;
        }

        private void ChangeFilletColorPenWhite_Click(object sender, EventArgs e)
        {
            fillColor = Color.White;
            this.buttonBrushColorSelected.BackColor = Color.White;
        }

        private void ChangeFilletColorPenRed_Click(object sender, EventArgs e)
        {
            fillColor = Color.Red;
            this.buttonBrushColorSelected.BackColor = Color.Red;
        }

        private void ChangeFilletColorPenGray_Click(object sender, EventArgs e)
        {
            fillColor = Color.Gray;
            this.buttonBrushColorSelected.BackColor = Color.Gray;
        }

        private void ChangeFilletColorPenBrown_Click(object sender, EventArgs e)
        {
            fillColor = Color.Brown;
            this.buttonBrushColorSelected.BackColor = Color.Brown;
        }

        private void ChangeFilletColorPenOrange_Click(object sender, EventArgs e)
        {
            fillColor = Color.Orange;
            this.buttonBrushColorSelected.BackColor = Color.Orange;
        }

        private void ChangeFilletColorPenYellow_Click(object sender, EventArgs e)
        {
            fillColor = Color.Yellow;
            this.buttonBrushColorSelected.BackColor = Color.Yellow;
        }

        private void ChangeFilletColorPenGreen_Click(object sender, EventArgs e)
        {
            fillColor = Color.Green;
            this.buttonBrushColorSelected.BackColor = Color.Green;
        }

        private void ChangeFilletColorPenBlue_Click(object sender, EventArgs e)
        {
            fillColor = Color.Blue;
            this.buttonBrushColorSelected.BackColor = Color.Blue;
        }

        private void ChangeFilletColorPenPurple_Click(object sender, EventArgs e)
        {
            fillColor = Color.Purple;
            this.buttonBrushColorSelected.BackColor = Color.Purple;
        }
    }
}
