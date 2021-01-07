
namespace VDraw
{
    partial class MasterUIVDraw
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFiguras = new System.Windows.Forms.Panel();
            this.hexagonButton = new System.Windows.Forms.Button();
            this.diamondButton = new System.Windows.Forms.Button();
            this.labelFigurasInPanelFiguras = new System.Windows.Forms.Label();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonPentagono = new System.Windows.Forms.Button();
            this.buttonRectangulo = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.botonTriangulo = new System.Windows.Forms.Button();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFiguras.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFiguras
            // 
            this.panelFiguras.Controls.Add(this.hexagonButton);
            this.panelFiguras.Controls.Add(this.diamondButton);
            this.panelFiguras.Controls.Add(this.labelFigurasInPanelFiguras);
            this.panelFiguras.Controls.Add(this.buttonEllipse);
            this.panelFiguras.Controls.Add(this.buttonPentagono);
            this.panelFiguras.Controls.Add(this.buttonRectangulo);
            this.panelFiguras.Controls.Add(this.squareButton);
            this.panelFiguras.Controls.Add(this.buttonCircle);
            this.panelFiguras.Controls.Add(this.botonTriangulo);
            this.panelFiguras.Location = new System.Drawing.Point(12, 36);
            this.panelFiguras.Name = "panelFiguras";
            this.panelFiguras.Size = new System.Drawing.Size(201, 551);
            this.panelFiguras.TabIndex = 0;
            // 
            // hexagonButton
            // 
            this.hexagonButton.Location = new System.Drawing.Point(3, 395);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Size = new System.Drawing.Size(194, 38);
            this.hexagonButton.TabIndex = 8;
            this.hexagonButton.Text = "Hexagono";
            this.hexagonButton.UseVisualStyleBackColor = true;
            this.hexagonButton.Click += new System.EventHandler(this.ButtonHexagon_Click);
            // 
            // diamondButton
            // 
            this.diamondButton.Location = new System.Drawing.Point(3, 263);
            this.diamondButton.Name = "diamondButton";
            this.diamondButton.Size = new System.Drawing.Size(194, 38);
            this.diamondButton.TabIndex = 7;
            this.diamondButton.Text = "Rombo";
            this.diamondButton.UseVisualStyleBackColor = true;
            this.diamondButton.Click += new System.EventHandler(this.ButtonDiamond_Click);
            // 
            // labelFigurasInPanelFiguras
            // 
            this.labelFigurasInPanelFiguras.AutoSize = true;
            this.labelFigurasInPanelFiguras.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.labelFigurasInPanelFiguras.Location = new System.Drawing.Point(3, 17);
            this.labelFigurasInPanelFiguras.Name = "labelFigurasInPanelFiguras";
            this.labelFigurasInPanelFiguras.Size = new System.Drawing.Size(138, 39);
            this.labelFigurasInPanelFiguras.TabIndex = 6;
            this.labelFigurasInPanelFiguras.Text = "Figuras";
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(3, 132);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(194, 38);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Text = "Elipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // buttonPentagono
            // 
            this.buttonPentagono.Location = new System.Drawing.Point(3, 351);
            this.buttonPentagono.Name = "buttonPentagono";
            this.buttonPentagono.Size = new System.Drawing.Size(194, 38);
            this.buttonPentagono.TabIndex = 4;
            this.buttonPentagono.Text = "Pentagono";
            this.buttonPentagono.UseVisualStyleBackColor = true;
            this.buttonPentagono.Click += new System.EventHandler(this.ButtonPentagon_Click);
            // 
            // buttonRectangulo
            // 
            this.buttonRectangulo.Location = new System.Drawing.Point(3, 219);
            this.buttonRectangulo.Name = "buttonRectangulo";
            this.buttonRectangulo.Size = new System.Drawing.Size(194, 38);
            this.buttonRectangulo.TabIndex = 3;
            this.buttonRectangulo.Text = "Rectangulo";
            this.buttonRectangulo.UseVisualStyleBackColor = true;
            this.buttonRectangulo.Click += new System.EventHandler(this.ButtonRect_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(3, 176);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(194, 38);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Cuadrado";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(3, 88);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(194, 38);
            this.buttonCircle.TabIndex = 1;
            this.buttonCircle.Text = "Circulo";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonCircle_Click);
            // 
            // botonTriangulo
            // 
            this.botonTriangulo.Location = new System.Drawing.Point(3, 307);
            this.botonTriangulo.Name = "botonTriangulo";
            this.botonTriangulo.Size = new System.Drawing.Size(194, 38);
            this.botonTriangulo.TabIndex = 0;
            this.botonTriangulo.Text = "Triangulo";
            this.botonTriangulo.UseVisualStyleBackColor = true;
            this.botonTriangulo.Click += new System.EventHandler(this.ButtonTriangle_Click);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCanvas.Location = new System.Drawing.Point(219, 36);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(783, 551);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 29);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EditarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.asdasdToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.asdasdToolStripMenuItem.Text = "Abrir";
            this.asdasdToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // EditarToolStripMenuItem
            // 
            this.EditarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem});
            this.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem";
            this.EditarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.EditarToolStripMenuItem.Text = "Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rehacerToolStripMenuItem.Text = "Rehacer";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
            // 
            // MasterUIVDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelFiguras);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterUIVDraw";
            this.Text = "VDraw";
            this.panelFiguras.ResumeLayout(false);
            this.panelFiguras.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFiguras;
        private System.Windows.Forms.Button botonTriangulo;
        private System.Windows.Forms.Button buttonPentagono;
        private System.Windows.Forms.Button buttonRectangulo;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.Label labelFigurasInPanelFiguras;
        private System.Windows.Forms.Button hexagonButton;
        private System.Windows.Forms.Button diamondButton;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
    }
}

