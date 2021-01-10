
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonInfoColorSelected = new System.Windows.Forms.Button();
            this.labelColorSeleccionado = new System.Windows.Forms.Label();
            this.labelColorBorde = new System.Windows.Forms.Label();
            this.buttonColorPurple = new System.Windows.Forms.Button();
            this.buttonColorBlack = new System.Windows.Forms.Button();
            this.buttonColorBlue = new System.Windows.Forms.Button();
            this.buttonColorWhite = new System.Windows.Forms.Button();
            this.buttonColorGreen = new System.Windows.Forms.Button();
            this.buttonColorRed = new System.Windows.Forms.Button();
            this.buttonColorYellow = new System.Windows.Forms.Button();
            this.buttonColorGray = new System.Windows.Forms.Button();
            this.buttonColorOrange = new System.Windows.Forms.Button();
            this.buttonColorBrown = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSuppCanvas = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBrushColorSelected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRelleno = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panelFiguras.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelSuppCanvas.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelFiguras.Location = new System.Drawing.Point(3, 36);
            this.panelFiguras.Name = "panelFiguras";
            this.panelFiguras.Size = new System.Drawing.Size(201, 679);
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
            this.panelCanvas.Size = new System.Drawing.Size(1060, 679);
            this.panelCanvas.TabIndex = 1;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCanvas_Paint);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 29);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonInfoColorSelected);
            this.panel2.Controls.Add(this.labelColorSeleccionado);
            this.panel2.Controls.Add(this.labelColorBorde);
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
            this.panel2.Location = new System.Drawing.Point(138, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 24);
            this.panel2.TabIndex = 0;
            // 
            // buttonInfoColorSelected
            // 
            this.buttonInfoColorSelected.BackColor = System.Drawing.Color.Black;
            this.buttonInfoColorSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfoColorSelected.Location = new System.Drawing.Point(134, 1);
            this.buttonInfoColorSelected.Margin = new System.Windows.Forms.Padding(1);
            this.buttonInfoColorSelected.Name = "buttonInfoColorSelected";
            this.buttonInfoColorSelected.Size = new System.Drawing.Size(21, 21);
            this.buttonInfoColorSelected.TabIndex = 13;
            this.buttonInfoColorSelected.UseVisualStyleBackColor = false;
            // 
            // labelColorSeleccionado
            // 
            this.labelColorSeleccionado.AutoSize = true;
            this.labelColorSeleccionado.Location = new System.Drawing.Point(3, 5);
            this.labelColorSeleccionado.Name = "labelColorSeleccionado";
            this.labelColorSeleccionado.Size = new System.Drawing.Size(130, 13);
            this.labelColorSeleccionado.TabIndex = 12;
            this.labelColorSeleccionado.Text = "Color Borde Seleccionado";
            // 
            // labelColorBorde
            // 
            this.labelColorBorde.AutoSize = true;
            this.labelColorBorde.Location = new System.Drawing.Point(159, 5);
            this.labelColorBorde.Name = "labelColorBorde";
            this.labelColorBorde.Size = new System.Drawing.Size(62, 13);
            this.labelColorBorde.TabIndex = 11;
            this.labelColorBorde.Text = "Color Borde";
            // 
            // buttonColorPurple
            // 
            this.buttonColorPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonColorPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorPurple.Location = new System.Drawing.Point(447, 1);
            this.buttonColorPurple.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorPurple.Name = "buttonColorPurple";
            this.buttonColorPurple.Size = new System.Drawing.Size(21, 21);
            this.buttonColorPurple.TabIndex = 10;
            this.buttonColorPurple.UseVisualStyleBackColor = false;
            this.buttonColorPurple.Click += new System.EventHandler(this.ChangeBorderColorPenPurple_Click);
            // 
            // buttonColorBlack
            // 
            this.buttonColorBlack.BackColor = System.Drawing.Color.Black;
            this.buttonColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBlack.Location = new System.Drawing.Point(222, 1);
            this.buttonColorBlack.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBlack.Name = "buttonColorBlack";
            this.buttonColorBlack.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBlack.TabIndex = 1;
            this.buttonColorBlack.UseVisualStyleBackColor = false;
            this.buttonColorBlack.Click += new System.EventHandler(this.ChangeBorderColorPenBlack_Click);
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBlue.Location = new System.Drawing.Point(422, 1);
            this.buttonColorBlue.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBlue.TabIndex = 9;
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            this.buttonColorBlue.Click += new System.EventHandler(this.ChangeBorderColorPenBlue_Click);
            // 
            // buttonColorWhite
            // 
            this.buttonColorWhite.BackColor = System.Drawing.Color.White;
            this.buttonColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorWhite.Location = new System.Drawing.Point(247, 1);
            this.buttonColorWhite.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorWhite.Name = "buttonColorWhite";
            this.buttonColorWhite.Size = new System.Drawing.Size(21, 21);
            this.buttonColorWhite.TabIndex = 2;
            this.buttonColorWhite.UseVisualStyleBackColor = false;
            this.buttonColorWhite.Click += new System.EventHandler(this.ChangeBorderColorPenWhite_Click);
            // 
            // buttonColorGreen
            // 
            this.buttonColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonColorGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorGreen.Location = new System.Drawing.Point(397, 1);
            this.buttonColorGreen.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorGreen.Name = "buttonColorGreen";
            this.buttonColorGreen.Size = new System.Drawing.Size(21, 21);
            this.buttonColorGreen.TabIndex = 8;
            this.buttonColorGreen.UseVisualStyleBackColor = false;
            this.buttonColorGreen.Click += new System.EventHandler(this.ChangeBorderColorPenGreen_Click);
            // 
            // buttonColorRed
            // 
            this.buttonColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorRed.Location = new System.Drawing.Point(272, 1);
            this.buttonColorRed.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorRed.Name = "buttonColorRed";
            this.buttonColorRed.Size = new System.Drawing.Size(21, 21);
            this.buttonColorRed.TabIndex = 3;
            this.buttonColorRed.UseVisualStyleBackColor = false;
            this.buttonColorRed.Click += new System.EventHandler(this.ChangeBorderColorPenRed_Click);
            // 
            // buttonColorYellow
            // 
            this.buttonColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorYellow.Location = new System.Drawing.Point(372, 1);
            this.buttonColorYellow.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorYellow.Name = "buttonColorYellow";
            this.buttonColorYellow.Size = new System.Drawing.Size(21, 21);
            this.buttonColorYellow.TabIndex = 7;
            this.buttonColorYellow.UseVisualStyleBackColor = false;
            this.buttonColorYellow.Click += new System.EventHandler(this.ChangeBorderColorPenYellow_Click);
            // 
            // buttonColorGray
            // 
            this.buttonColorGray.BackColor = System.Drawing.Color.Gray;
            this.buttonColorGray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorGray.Location = new System.Drawing.Point(297, 1);
            this.buttonColorGray.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorGray.Name = "buttonColorGray";
            this.buttonColorGray.Size = new System.Drawing.Size(21, 21);
            this.buttonColorGray.TabIndex = 4;
            this.buttonColorGray.UseVisualStyleBackColor = false;
            this.buttonColorGray.Click += new System.EventHandler(this.ChangeBorderColorPenGray_Click);
            // 
            // buttonColorOrange
            // 
            this.buttonColorOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorOrange.Location = new System.Drawing.Point(347, 1);
            this.buttonColorOrange.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorOrange.Name = "buttonColorOrange";
            this.buttonColorOrange.Size = new System.Drawing.Size(21, 21);
            this.buttonColorOrange.TabIndex = 6;
            this.buttonColorOrange.UseVisualStyleBackColor = false;
            this.buttonColorOrange.Click += new System.EventHandler(this.ChangeBorderColorPenOrange_Click);
            // 
            // buttonColorBrown
            // 
            this.buttonColorBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonColorBrown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorBrown.Location = new System.Drawing.Point(322, 1);
            this.buttonColorBrown.Margin = new System.Windows.Forms.Padding(1);
            this.buttonColorBrown.Name = "buttonColorBrown";
            this.buttonColorBrown.Size = new System.Drawing.Size(21, 21);
            this.buttonColorBrown.TabIndex = 5;
            this.buttonColorBrown.UseVisualStyleBackColor = false;
            this.buttonColorBrown.Click += new System.EventHandler(this.ChangeBorderColorPenBrown_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EditarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
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
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItem_Click);
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
            // panelSuppCanvas
            // 
            this.panelSuppCanvas.Controls.Add(this.panelCanvas);
            this.panelSuppCanvas.Location = new System.Drawing.Point(212, 36);
            this.panelSuppCanvas.Margin = new System.Windows.Forms.Padding(200, 3, 3, 3);
            this.panelSuppCanvas.Name = "panelSuppCanvas";
            this.panelSuppCanvas.Size = new System.Drawing.Size(1060, 679);
            this.panelSuppCanvas.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonBrushColorSelected);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelRelleno);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Location = new System.Drawing.Point(778, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 24);
            this.panel3.TabIndex = 14;
            // 
            // buttonBrushColorSelected
            // 
            this.buttonBrushColorSelected.BackColor = System.Drawing.Color.White;
            this.buttonBrushColorSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrushColorSelected.Location = new System.Drawing.Point(145, 1);
            this.buttonBrushColorSelected.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBrushColorSelected.Name = "buttonBrushColorSelected";
            this.buttonBrushColorSelected.Size = new System.Drawing.Size(21, 21);
            this.buttonBrushColorSelected.TabIndex = 13;
            this.buttonBrushColorSelected.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color Relleno Seleccionado";
            // 
            // labelRelleno
            // 
            this.labelRelleno.AutoSize = true;
            this.labelRelleno.Location = new System.Drawing.Point(170, 5);
            this.labelRelleno.Name = "labelRelleno";
            this.labelRelleno.Size = new System.Drawing.Size(70, 13);
            this.labelRelleno.TabIndex = 11;
            this.labelRelleno.Text = "Color Relleno";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(469, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangeFilletColorPenPurple_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(244, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ChangeFilletColorPenBlack_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(444, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 21);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ChangeFilletColorPenBlue_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(269, 1);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 21);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ChangeFilletColorPenWhite_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(419, 1);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 21);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ChangeFilletColorPenGreen_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(294, 1);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 21);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ChangeFilletColorPenRed_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Yellow;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(394, 1);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 21);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ChangeFilletColorPenYellow_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(319, 1);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 21);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ChangeFilletColorPenGray_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Orange;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(369, 1);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 21);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ChangeFilletColorPenOrange_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Brown;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(344, 1);
            this.button11.Margin = new System.Windows.Forms.Padding(1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(21, 21);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.ChangeFilletColorPenBrown_Click);
            // 
            // MasterUIVDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 727);
            this.Controls.Add(this.panelSuppCanvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFiguras);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterUIVDraw";
            this.Text = "VDraw";
            this.panelFiguras.ResumeLayout(false);
            this.panelFiguras.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSuppCanvas.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label labelColorBorde;
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
        private System.Windows.Forms.Button buttonInfoColorSelected;
        private System.Windows.Forms.Label labelColorSeleccionado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBrushColorSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRelleno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

