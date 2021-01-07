
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
            this.buttonColorBlack = new System.Windows.Forms.Button();
            this.buttonColorWhite = new System.Windows.Forms.Button();
            this.buttonColorRed = new System.Windows.Forms.Button();
            this.buttonColorGray = new System.Windows.Forms.Button();
            this.buttonColorBrown = new System.Windows.Forms.Button();
            this.buttonColorOrange = new System.Windows.Forms.Button();
            this.buttonColorYellow = new System.Windows.Forms.Button();
            this.buttonColorGreen = new System.Windows.Forms.Button();
            this.buttonColorBlue = new System.Windows.Forms.Button();
            this.buttonColorPurple = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuppCanvas = new System.Windows.Forms.Panel();
            this.panelFiguras.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSuppCanvas.SuspendLayout();
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
            this.hexagonButton.Location = new System.Drawing.Point(3, 366);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Size = new System.Drawing.Size(194, 38);
            this.hexagonButton.TabIndex = 8;
            this.hexagonButton.Text = "Hexagono";
            this.hexagonButton.UseVisualStyleBackColor = true;
            this.hexagonButton.Click += new System.EventHandler(this.ButtonHexagon_Click);
            // 
            // diamondButton
            // 
            this.diamondButton.Location = new System.Drawing.Point(3, 234);
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
            this.buttonEllipse.Location = new System.Drawing.Point(3, 103);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(194, 38);
            this.buttonEllipse.TabIndex = 5;
            this.buttonEllipse.Text = "Elipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // buttonPentagono
            // 
            this.buttonPentagono.Location = new System.Drawing.Point(3, 322);
            this.buttonPentagono.Name = "buttonPentagono";
            this.buttonPentagono.Size = new System.Drawing.Size(194, 38);
            this.buttonPentagono.TabIndex = 4;
            this.buttonPentagono.Text = "Pentagono";
            this.buttonPentagono.UseVisualStyleBackColor = true;
            this.buttonPentagono.Click += new System.EventHandler(this.ButtonPentagon_Click);
            // 
            // buttonRectangulo
            // 
            this.buttonRectangulo.Location = new System.Drawing.Point(3, 190);
            this.buttonRectangulo.Name = "buttonRectangulo";
            this.buttonRectangulo.Size = new System.Drawing.Size(194, 38);
            this.buttonRectangulo.TabIndex = 3;
            this.buttonRectangulo.Text = "Rectangulo";
            this.buttonRectangulo.UseVisualStyleBackColor = true;
            this.buttonRectangulo.Click += new System.EventHandler(this.ButtonRect_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(3, 147);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(194, 38);
            this.squareButton.TabIndex = 2;
            this.squareButton.Text = "Cuadrado";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(3, 59);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(194, 38);
            this.buttonCircle.TabIndex = 1;
            this.buttonCircle.Text = "Circulo";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.ButtonCircle_Click);
            // 
            // botonTriangulo
            // 
            this.botonTriangulo.Location = new System.Drawing.Point(3, 278);
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
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(0, 0);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(783, 551);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
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
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asdasdToolStripMenuItem.Text = "Abrir";
            this.asdasdToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // buttonColorBlack
            // 
            this.buttonColorBlack.BackColor = System.Drawing.Color.Black;
            this.buttonColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBlack.Location = new System.Drawing.Point(86, 1);
            this.buttonColorBlack.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBlack.Name = "buttonColorBlack";
            this.buttonColorBlack.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBlack.TabIndex = 1;
            this.buttonColorBlack.UseVisualStyleBackColor = false;
            // 
            // buttonColorWhite
            // 
            this.buttonColorWhite.BackColor = System.Drawing.Color.White;
            this.buttonColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorWhite.Location = new System.Drawing.Point(111, 1);
            this.buttonColorWhite.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorWhite.Name = "buttonColorWhite";
            this.buttonColorWhite.Size = new System.Drawing.Size(21, 21);
            this.buttonColorWhite.TabIndex = 2;
            this.buttonColorWhite.UseVisualStyleBackColor = false;
            // 
            // buttonColorRed
            // 
            this.buttonColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorRed.Location = new System.Drawing.Point(136, 1);
            this.buttonColorRed.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorRed.Name = "buttonColorRed";
            this.buttonColorRed.Size = new System.Drawing.Size(21, 21);
            this.buttonColorRed.TabIndex = 3;
            this.buttonColorRed.UseVisualStyleBackColor = false;
            // 
            // buttonColorGray
            // 
            this.buttonColorGray.BackColor = System.Drawing.Color.Gray;
            this.buttonColorGray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorGray.Location = new System.Drawing.Point(161, 1);
            this.buttonColorGray.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorGray.Name = "buttonColorGray";
            this.buttonColorGray.Size = new System.Drawing.Size(21, 21);
            this.buttonColorGray.TabIndex = 4;
            this.buttonColorGray.UseVisualStyleBackColor = false;
            // 
            // buttonColorBrown
            // 
            this.buttonColorBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonColorBrown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBrown.Location = new System.Drawing.Point(186, 1);
            this.buttonColorBrown.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBrown.Name = "buttonColorBrown";
            this.buttonColorBrown.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBrown.TabIndex = 5;
            this.buttonColorBrown.UseVisualStyleBackColor = false;
            // 
            // buttonColorOrange
            // 
            this.buttonColorOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorOrange.Location = new System.Drawing.Point(211, 1);
            this.buttonColorOrange.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorOrange.Name = "buttonColorOrange";
            this.buttonColorOrange.Size = new System.Drawing.Size(21, 21);
            this.buttonColorOrange.TabIndex = 6;
            this.buttonColorOrange.UseVisualStyleBackColor = false;
            // 
            // buttonColorYellow
            // 
            this.buttonColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorYellow.Location = new System.Drawing.Point(236, 1);
            this.buttonColorYellow.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorYellow.Name = "buttonColorYellow";
            this.buttonColorYellow.Size = new System.Drawing.Size(21, 21);
            this.buttonColorYellow.TabIndex = 7;
            this.buttonColorYellow.UseVisualStyleBackColor = false;
            // 
            // buttonColorGreen
            // 
            this.buttonColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonColorGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorGreen.Location = new System.Drawing.Point(261, 1);
            this.buttonColorGreen.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorGreen.Name = "buttonColorGreen";
            this.buttonColorGreen.Size = new System.Drawing.Size(21, 21);
            this.buttonColorGreen.TabIndex = 8;
            this.buttonColorGreen.UseVisualStyleBackColor = false;
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBlue.Location = new System.Drawing.Point(286, 1);
            this.buttonColorBlue.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBlue.TabIndex = 9;
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            // 
            // buttonColorPurple
            // 
            this.buttonColorPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonColorPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorPurple.Location = new System.Drawing.Point(311, 1);
            this.buttonColorPurple.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorPurple.Name = "buttonColorPurple";
            this.buttonColorPurple.Size = new System.Drawing.Size(21, 21);
            this.buttonColorPurple.TabIndex = 10;
            this.buttonColorPurple.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonColorPurple);
            this.panel2.Controls.Add(this.buttonColorBlack);
            this.panel2.Controls.Add(this.buttonColorBlue);
            this.panel2.Controls.Add(this.buttonColorWhite);
            this.panel2.Controls.Add(this.buttonColorGreen);
            this.panel2.Controls.Add(this.buttonColorRed);
            this.panel2.Controls.Add(this.buttonColorYellow);
            this.panel2.Controls.Add(this.buttonColorGray);
            this.panel2.Controls.Add(this.buttonColorOrange);
            this.panel2.Controls.Add(this.buttonColorBrown);
            this.panel2.Location = new System.Drawing.Point(216, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 24);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color Borde: ";
            // 
            // panelSuppCanvas
            // 
            this.panelSuppCanvas.Controls.Add(this.panelCanvas);
            this.panelSuppCanvas.Location = new System.Drawing.Point(219, 36);
            this.panelSuppCanvas.Name = "panelSuppCanvas";
            this.panelSuppCanvas.Size = new System.Drawing.Size(783, 551);
            this.panelSuppCanvas.TabIndex = 3;
            // 
            // MasterUIVDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 598);
            this.Controls.Add(this.panelSuppCanvas);
            this.Controls.Add(this.panel1);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSuppCanvas.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColorPurple;
        private System.Windows.Forms.Button buttonColorBlack;
        private System.Windows.Forms.Button buttonColorBlue;
        private System.Windows.Forms.Button buttonColorWhite;
        private System.Windows.Forms.Button buttonColorGreen;
        private System.Windows.Forms.Button buttonColorRed;
        private System.Windows.Forms.Button buttonColorYellow;
        private System.Windows.Forms.Button buttonColorGray;
        private System.Windows.Forms.Button buttonColorOrange;
        private System.Windows.Forms.Button buttonColorBrown;
        private System.Windows.Forms.Panel panelSuppCanvas;
    }
}

