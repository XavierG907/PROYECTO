namespace Mockup
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Menú = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.curvaMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transicionMenu = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transicionMenu2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Portada = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuSide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPagos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnPaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCorte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMedico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.opcionMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).BeginInit();
            this.MenuSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // Menú
            // 
            this.Menú.AutoSize = true;
            this.transicionMenu.SetDecoration(this.Menú, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.Menú, BunifuAnimatorNS.DecorationType.None);
            this.Menú.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menú.ForeColor = System.Drawing.Color.White;
            this.Menú.Location = new System.Drawing.Point(57, 21);
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(58, 21);
            this.Menú.TabIndex = 0;
            this.Menú.Text = "Menú";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.restaurar);
            this.panel1.Controls.Add(this.maximizar);
            this.panel1.Controls.Add(this.minimizar);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.Menú);
            this.panel1.Controls.Add(this.opcionMenu);
            this.panel1.Controls.Add(this.Nombre);
            this.transicionMenu2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 60);
            this.panel1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Nombre.AutoSize = true;
            this.Nombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.Nombre, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.Nombre, BunifuAnimatorNS.DecorationType.None);
            this.Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nombre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(163)))));
            this.Nombre.Location = new System.Drawing.Point(329, 10);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(240, 33);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "NÚCLEO MÉDICO";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSide.Controls.Add(this.MenuSide);
            this.transicionMenu2.SetDecoration(this.panelSide, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.panelSide, BunifuAnimatorNS.DecorationType.None);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 60);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(252, 574);
            this.panelSide.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.Portada);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.bunifuFlatButton11);
            this.panel3.Controls.Add(this.fecha);
            this.panel3.Controls.Add(this.hora);
            this.transicionMenu2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 574);
            this.panel3.TabIndex = 2;
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fecha.AutoSize = true;
            this.transicionMenu.SetDecoration(this.fecha, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.fecha, BunifuAnimatorNS.DecorationType.None);
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(163)))));
            this.fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecha.Location = new System.Drawing.Point(31, 493);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(134, 39);
            this.fecha.TabIndex = 2;
            this.fecha.Text = "FECHA";
            this.fecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hora.AutoSize = true;
            this.transicionMenu.SetDecoration(this.hora, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.hora, BunifuAnimatorNS.DecorationType.None);
            this.hora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(186)))));
            this.hora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hora.Location = new System.Drawing.Point(28, 427);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(164, 58);
            this.hora.TabIndex = 1;
            this.hora.Text = "HORA";
            this.hora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // curvaMenu
            // 
            this.curvaMenu.ElipseRadius = 7;
            this.curvaMenu.TargetControl = this.MenuSide;
            // 
            // transicionMenu
            // 
            this.transicionMenu.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.transicionMenu.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.transicionMenu.DefaultAnimation = animation3;
            this.transicionMenu.Interval = 5;
            // 
            // transicionMenu2
            // 
            this.transicionMenu2.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.transicionMenu2.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.transicionMenu2.DefaultAnimation = animation4;
            this.transicionMenu2.Interval = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transicionMenu2.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.dataGridView1.Location = new System.Drawing.Point(21, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 328);
            this.dataGridView1.TabIndex = 7;
            // 
            // Portada
            // 
            this.Portada.BackColor = System.Drawing.Color.LightSteelBlue;
            this.transicionMenu.SetDecoration(this.Portada, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.Portada, BunifuAnimatorNS.DecorationType.None);
            this.Portada.Image = ((System.Drawing.Image)(resources.GetObject("Portada.Image")));
            this.Portada.InitialImage = null;
            this.Portada.Location = new System.Drawing.Point(21, 72);
            this.Portada.Name = "Portada";
            this.Portada.Size = new System.Drawing.Size(570, 328);
            this.Portada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Portada.TabIndex = 8;
            this.Portada.TabStop = false;
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.Purple;
            this.bunifuFlatButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "Cerrar Sesión";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = global::Mockup.Properties.Resources.icons8_botón_de_apagado_64;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 60D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(175, 7);
            this.bunifuFlatButton11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(142, 37);
            this.bunifuFlatButton11.TabIndex = 6;
            this.bunifuFlatButton11.Text = "Cerrar Sesión";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.BunifuFlatButton11_Click);
            // 
            // MenuSide
            // 
            this.MenuSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuSide.BackgroundImage")));
            this.MenuSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuSide.Controls.Add(this.btnPagos);
            this.MenuSide.Controls.Add(this.line);
            this.MenuSide.Controls.Add(this.btnPaciente);
            this.MenuSide.Controls.Add(this.btnCorte);
            this.MenuSide.Controls.Add(this.btnMedico);
            this.MenuSide.Controls.Add(this.btnInventario);
            this.MenuSide.Controls.Add(this.pictureBox2);
            this.transicionMenu2.SetDecoration(this.MenuSide, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.MenuSide, BunifuAnimatorNS.DecorationType.None);
            this.MenuSide.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(186)))));
            this.MenuSide.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(163)))));
            this.MenuSide.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(163)))));
            this.MenuSide.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuSide.Location = new System.Drawing.Point(12, 6);
            this.MenuSide.Name = "MenuSide";
            this.MenuSide.Quality = 10;
            this.MenuSide.Size = new System.Drawing.Size(225, 560);
            this.MenuSide.TabIndex = 9;
            // 
            // btnPagos
            // 
            this.btnPagos.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagos.BorderRadius = 0;
            this.btnPagos.ButtonText = "      PAGOS";
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.btnPagos, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.btnPagos, BunifuAnimatorNS.DecorationType.None);
            this.btnPagos.DisabledColor = System.Drawing.Color.Gray;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPagos.Iconimage = global::Mockup.Properties.Resources.icons8_pago_en_línea_50;
            this.btnPagos.Iconimage_right = null;
            this.btnPagos.Iconimage_right_Selected = null;
            this.btnPagos.Iconimage_Selected = null;
            this.btnPagos.IconMarginLeft = 0;
            this.btnPagos.IconMarginRight = 0;
            this.btnPagos.IconRightVisible = true;
            this.btnPagos.IconRightZoom = 0D;
            this.btnPagos.IconVisible = true;
            this.btnPagos.IconZoom = 60D;
            this.btnPagos.IsTab = false;
            this.btnPagos.Location = new System.Drawing.Point(14, 299);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPagos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPagos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPagos.selected = false;
            this.btnPagos.Size = new System.Drawing.Size(190, 37);
            this.btnPagos.TabIndex = 14;
            this.btnPagos.Text = "      PAGOS";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Textcolor = System.Drawing.Color.White;
            this.btnPagos.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.transicionMenu2.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.ForeColor = System.Drawing.Color.Wheat;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line.LineThickness = 1;
            this.line.Location = new System.Drawing.Point(14, 102);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(197, 10);
            this.line.TabIndex = 0;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // btnPaciente
            // 
            this.btnPaciente.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaciente.BorderRadius = 0;
            this.btnPaciente.ButtonText = "      PACIENTE";
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.btnPaciente, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.btnPaciente, BunifuAnimatorNS.DecorationType.None);
            this.btnPaciente.DisabledColor = System.Drawing.Color.Gray;
            this.btnPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPaciente.Iconimage = global::Mockup.Properties.Resources.icons8_save_the_children_50;
            this.btnPaciente.Iconimage_right = null;
            this.btnPaciente.Iconimage_right_Selected = null;
            this.btnPaciente.Iconimage_Selected = null;
            this.btnPaciente.IconMarginLeft = 0;
            this.btnPaciente.IconMarginRight = 0;
            this.btnPaciente.IconRightVisible = true;
            this.btnPaciente.IconRightZoom = 0D;
            this.btnPaciente.IconVisible = true;
            this.btnPaciente.IconZoom = 60D;
            this.btnPaciente.IsTab = false;
            this.btnPaciente.Location = new System.Drawing.Point(14, 119);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPaciente.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPaciente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPaciente.selected = false;
            this.btnPaciente.Size = new System.Drawing.Size(190, 37);
            this.btnPaciente.TabIndex = 5;
            this.btnPaciente.Text = "      PACIENTE";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Textcolor = System.Drawing.Color.White;
            this.btnPaciente.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnCorte
            // 
            this.btnCorte.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnCorte.BackColor = System.Drawing.Color.Transparent;
            this.btnCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorte.BorderRadius = 0;
            this.btnCorte.ButtonText = "      CORTE";
            this.btnCorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.btnCorte, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.btnCorte, BunifuAnimatorNS.DecorationType.None);
            this.btnCorte.DisabledColor = System.Drawing.Color.Gray;
            this.btnCorte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCorte.Iconimage = global::Mockup.Properties.Resources.icons8_costo_50;
            this.btnCorte.Iconimage_right = null;
            this.btnCorte.Iconimage_right_Selected = null;
            this.btnCorte.Iconimage_Selected = null;
            this.btnCorte.IconMarginLeft = 0;
            this.btnCorte.IconMarginRight = 0;
            this.btnCorte.IconRightVisible = true;
            this.btnCorte.IconRightZoom = 0D;
            this.btnCorte.IconVisible = true;
            this.btnCorte.IconZoom = 60D;
            this.btnCorte.IsTab = false;
            this.btnCorte.Location = new System.Drawing.Point(14, 254);
            this.btnCorte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCorte.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCorte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCorte.selected = false;
            this.btnCorte.Size = new System.Drawing.Size(190, 37);
            this.btnCorte.TabIndex = 12;
            this.btnCorte.Text = "      CORTE";
            this.btnCorte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorte.Textcolor = System.Drawing.Color.White;
            this.btnCorte.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.Click += new System.EventHandler(this.btnCorte_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnMedico.BackColor = System.Drawing.Color.Transparent;
            this.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedico.BorderRadius = 0;
            this.btnMedico.ButtonText = "      MÉDICO";
            this.btnMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.btnMedico, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.btnMedico, BunifuAnimatorNS.DecorationType.None);
            this.btnMedico.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedico.Iconimage = global::Mockup.Properties.Resources.icons8_doctor_en_medicina_50;
            this.btnMedico.Iconimage_right = null;
            this.btnMedico.Iconimage_right_Selected = null;
            this.btnMedico.Iconimage_Selected = null;
            this.btnMedico.IconMarginLeft = 0;
            this.btnMedico.IconMarginRight = 0;
            this.btnMedico.IconRightVisible = true;
            this.btnMedico.IconRightZoom = 0D;
            this.btnMedico.IconVisible = true;
            this.btnMedico.IconZoom = 60D;
            this.btnMedico.IsTab = false;
            this.btnMedico.Location = new System.Drawing.Point(14, 164);
            this.btnMedico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMedico.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMedico.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedico.selected = false;
            this.btnMedico.Size = new System.Drawing.Size(190, 37);
            this.btnMedico.TabIndex = 7;
            this.btnMedico.Text = "      MÉDICO";
            this.btnMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.Textcolor = System.Drawing.Color.White;
            this.btnMedico.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "      INVENTARIO";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = global::Mockup.Properties.Resources.icons8_test_aprobado_50;
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 60D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(14, 209);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(190, 37);
            this.btnInventario.TabIndex = 11;
            this.btnInventario.Text = "      INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.transicionMenu.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Mockup.Properties.Resources._621958f0_33b8_4372_a777_e8e5472882e4_200x200;
            this.pictureBox2.Location = new System.Drawing.Point(14, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transicionMenu.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.restaurar.Image = global::Mockup.Properties.Resources.icons8_restaurar_ventana_50__1_;
            this.restaurar.Location = new System.Drawing.Point(799, 17);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(25, 25);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 4;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transicionMenu.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.maximizar, BunifuAnimatorNS.DecorationType.None);
            this.maximizar.Image = global::Mockup.Properties.Resources.icons8_maximizar_la_ventana_50;
            this.maximizar.Location = new System.Drawing.Point(799, 17);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(25, 25);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 3;
            this.maximizar.TabStop = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transicionMenu.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.Image = global::Mockup.Properties.Resources.icons8_minimizar_la_ventana_50__1_;
            this.minimizar.Location = new System.Drawing.Point(768, 17);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(25, 25);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transicionMenu.SetDecoration(this.salir, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.salir, BunifuAnimatorNS.DecorationType.None);
            this.salir.Image = global::Mockup.Properties.Resources.icons8_cerrar_ventana_50;
            this.salir.Location = new System.Drawing.Point(830, 17);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(25, 25);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 1;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // opcionMenu
            // 
            this.opcionMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transicionMenu.SetDecoration(this.opcionMenu, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu2.SetDecoration(this.opcionMenu, BunifuAnimatorNS.DecorationType.None);
            this.opcionMenu.Image = global::Mockup.Properties.Resources.icons8_menú_redondeado_50;
            this.opcionMenu.Location = new System.Drawing.Point(26, 17);
            this.opcionMenu.Name = "opcionMenu";
            this.opcionMenu.Size = new System.Drawing.Size(25, 25);
            this.opcionMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opcionMenu.TabIndex = 0;
            this.opcionMenu.TabStop = false;
            this.opcionMenu.Click += new System.EventHandler(this.opcionMenu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panel1);
            this.transicionMenu2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transicionMenu.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portada)).EndInit();
            this.MenuSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox opcionMenu;
        private System.Windows.Forms.Label Menú;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedico;
        private Bunifu.Framework.UI.BunifuFlatButton btnPaciente;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnCorte;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        private Bunifu.Framework.UI.BunifuGradientPanel MenuSide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuElipse curvaMenu;
        private BunifuAnimatorNS.BunifuTransition transicionMenu;
        private BunifuAnimatorNS.BunifuTransition transicionMenu2;
        private System.Windows.Forms.PictureBox Portada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPagos;
    }
}

