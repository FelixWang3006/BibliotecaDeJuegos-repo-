namespace BibliotecaDeJuegos
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnAgregarPerfil = new System.Windows.Forms.Button();
            this.lbTotalJuegos = new System.Windows.Forms.Label();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbValoración = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbValoracion = new System.Windows.Forms.Label();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.lbPlataforma = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPerfilGamer = new System.Windows.Forms.Button();
            this.btAgregarJuego = new System.Windows.Forms.Button();
            this.btBiblioteca = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.liboDetalles = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.btnVerDetalles);
            this.groupBox1.Controls.Add(this.btnAgregarPerfil);
            this.groupBox1.Controls.Add(this.lbTotalJuegos);
            this.groupBox1.Controls.Add(this.dgvJuegos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(223, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biblioteca de Juegos";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnVerDetalles.Enabled = false;
            this.btnVerDetalles.FlatAppearance.BorderSize = 0;
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Location = new System.Drawing.Point(318, 238);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(108, 23);
            this.btnVerDetalles.TabIndex = 7;
            this.btnVerDetalles.Text = "Ver detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btVerDetalles_Click);
            // 
            // btnAgregarPerfil
            // 
            this.btnAgregarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnAgregarPerfil.Enabled = false;
            this.btnAgregarPerfil.FlatAppearance.BorderSize = 0;
            this.btnAgregarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPerfil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPerfil.Location = new System.Drawing.Point(189, 238);
            this.btnAgregarPerfil.Name = "btnAgregarPerfil";
            this.btnAgregarPerfil.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarPerfil.TabIndex = 2;
            this.btnAgregarPerfil.Text = "Agregar al perfil";
            this.btnAgregarPerfil.UseVisualStyleBackColor = false;
            // 
            // lbTotalJuegos
            // 
            this.lbTotalJuegos.AutoSize = true;
            this.lbTotalJuegos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalJuegos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lbTotalJuegos.Location = new System.Drawing.Point(12, 243);
            this.lbTotalJuegos.Name = "lbTotalJuegos";
            this.lbTotalJuegos.Size = new System.Drawing.Size(98, 13);
            this.lbTotalJuegos.TabIndex = 1;
            this.lbTotalJuegos.Text = "Total de juegos: 0";
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AllowUserToAddRows = false;
            this.dgvJuegos.AllowUserToDeleteRows = false;
            this.dgvJuegos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvJuegos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJuegos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dgvJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJuegos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJuegos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Genero,
            this.Plataforma,
            this.Valoración});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJuegos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJuegos.EnableHeadersVisualStyles = false;
            this.dgvJuegos.Location = new System.Drawing.Point(6, 35);
            this.dgvJuegos.MultiSelect = false;
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.ReadOnly = true;
            this.dgvJuegos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvJuegos.RowHeadersVisible = false;
            this.dgvJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJuegos.Size = new System.Drawing.Size(529, 182);
            this.dgvJuegos.TabIndex = 0;
            this.dgvJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellContentClick_1);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 121;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 121;
            // 
            // Plataforma
            // 
            this.Plataforma.HeaderText = "Plataforma";
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.ReadOnly = true;
            this.Plataforma.Width = 121;
            // 
            // Valoración
            // 
            this.Valoración.HeaderText = "Valoración";
            this.Valoración.Name = "Valoración";
            this.Valoración.ReadOnly = true;
            this.Valoración.Width = 121;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox2.Controls.Add(this.cbValoración);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lbValoracion);
            this.groupBox2.Controls.Add(this.cbPlataforma);
            this.groupBox2.Controls.Add(this.lbPlataforma);
            this.groupBox2.Controls.Add(this.cbGenero);
            this.groupBox2.Controls.Add(this.lbGenero);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(217, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda";
            // 
            // cbValoración
            // 
            this.cbValoración.BackColor = System.Drawing.Color.White;
            this.cbValoración.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValoración.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbValoración.FormattingEnabled = true;
            this.cbValoración.Items.AddRange(new object[] {
            "Todos",
            "1 - 2",
            "2 - 3",
            "3 - 4",
            "4 - 5",
            "5 - 6",
            "6 - 7",
            "7 - 8",
            "8 - 9",
            "9 - 10"});
            this.cbValoración.Location = new System.Drawing.Point(297, 60);
            this.cbValoración.Name = "cbValoración";
            this.cbValoración.Size = new System.Drawing.Size(85, 21);
            this.cbValoración.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(420, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(420, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbValoracion
            // 
            this.lbValoracion.AutoSize = true;
            this.lbValoracion.Location = new System.Drawing.Point(294, 35);
            this.lbValoracion.Name = "lbValoracion";
            this.lbValoracion.Size = new System.Drawing.Size(61, 13);
            this.lbValoracion.TabIndex = 7;
            this.lbValoracion.Text = "Valoración";
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.BackColor = System.Drawing.Color.White;
            this.cbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlataforma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Items.AddRange(new object[] {
            "Todos",
            "Móviles",
            "Nintendo",
            "PlayStation",
            "PC",
            "Sega Genesis",
            "Xbox"});
            this.cbPlataforma.Location = new System.Drawing.Point(152, 60);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(121, 21);
            this.cbPlataforma.TabIndex = 6;
            // 
            // lbPlataforma
            // 
            this.lbPlataforma.AutoSize = true;
            this.lbPlataforma.Location = new System.Drawing.Point(149, 35);
            this.lbPlataforma.Name = "lbPlataforma";
            this.lbPlataforma.Size = new System.Drawing.Size(62, 13);
            this.lbPlataforma.TabIndex = 5;
            this.lbPlataforma.Text = "Plataforma";
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.Color.White;
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Todos",
            "Acción",
            "Aventura",
            "Carreras",
            "Deporte",
            "Estrategia",
            "Plataforma",
            "RPG",
            "Puzzle"});
            this.cbGenero.Location = new System.Drawing.Point(11, 60);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 4;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(12, 35);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(45, 13);
            this.lbGenero.TabIndex = 1;
            this.lbGenero.Text = "Género";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btPerfilGamer);
            this.panel1.Controls.Add(this.btAgregarJuego);
            this.panel1.Controls.Add(this.btBiblioteca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 557);
            this.panel1.TabIndex = 4;
            // 
            // btPerfilGamer
            // 
            this.btPerfilGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btPerfilGamer.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btPerfilGamer.FlatAppearance.BorderSize = 0;
            this.btPerfilGamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPerfilGamer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerfilGamer.ForeColor = System.Drawing.Color.White;
            this.btPerfilGamer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerfilGamer.ImageKey = "P.png";
            this.btPerfilGamer.ImageList = this.imageList1;
            this.btPerfilGamer.Location = new System.Drawing.Point(3, 210);
            this.btPerfilGamer.Name = "btPerfilGamer";
            this.btPerfilGamer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btPerfilGamer.Size = new System.Drawing.Size(176, 38);
            this.btPerfilGamer.TabIndex = 5;
            this.btPerfilGamer.Text = "Perfil Gamer";
            this.btPerfilGamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPerfilGamer.UseVisualStyleBackColor = false;
            this.btPerfilGamer.Click += new System.EventHandler(this.btPerfilGamer_Click);
            // 
            // btAgregarJuego
            // 
            this.btAgregarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btAgregarJuego.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregarJuego.FlatAppearance.BorderSize = 0;
            this.btAgregarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAgregarJuego.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarJuego.ForeColor = System.Drawing.Color.White;
            this.btAgregarJuego.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarJuego.ImageKey = "A.png";
            this.btAgregarJuego.ImageList = this.imageList1;
            this.btAgregarJuego.Location = new System.Drawing.Point(3, 151);
            this.btAgregarJuego.Name = "btAgregarJuego";
            this.btAgregarJuego.Size = new System.Drawing.Size(176, 40);
            this.btAgregarJuego.TabIndex = 1;
            this.btAgregarJuego.Text = "Agregar Juego";
            this.btAgregarJuego.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgregarJuego.UseVisualStyleBackColor = false;
            this.btAgregarJuego.Click += new System.EventHandler(this.btAgregarJuego_Click);
            // 
            // btBiblioteca
            // 
            this.btBiblioteca.BackColor = System.Drawing.Color.Indigo;
            this.btBiblioteca.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btBiblioteca.FlatAppearance.BorderSize = 0;
            this.btBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBiblioteca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBiblioteca.ForeColor = System.Drawing.Color.White;
            this.btBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBiblioteca.ImageIndex = 3;
            this.btBiblioteca.ImageList = this.imageList1;
            this.btBiblioteca.Location = new System.Drawing.Point(3, 91);
            this.btBiblioteca.Name = "btBiblioteca";
            this.btBiblioteca.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btBiblioteca.Size = new System.Drawing.Size(176, 39);
            this.btBiblioteca.TabIndex = 0;
            this.btBiblioteca.Text = "Biblioteca";
            this.btBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBiblioteca.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox3.Controls.Add(this.liboDetalles);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(796, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 292);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles";
            // 
            // liboDetalles
            // 
            this.liboDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.liboDetalles.ForeColor = System.Drawing.Color.White;
            this.liboDetalles.FormattingEnabled = true;
            this.liboDetalles.Location = new System.Drawing.Point(10, 23);
            this.liboDetalles.Name = "liboDetalles";
            this.liboDetalles.Size = new System.Drawing.Size(191, 251);
            this.liboDetalles.TabIndex = 13;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = global::BibliotecaDeJuegos.Properties.Resources.GameMatch11;
            this.pbLogo.Location = new System.Drawing.Point(796, 91);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(246, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "b.png");
            this.imageList1.Images.SetKeyName(1, "P.png");
            this.imageList1.Images.SetKeyName(2, "A.png");
            this.imageList1.Images.SetKeyName(3, "Biblio.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1120, 557);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca de Juegos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarPerfil;
        private System.Windows.Forms.Label lbTotalJuegos;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAgregarJuego;
        private System.Windows.Forms.Button btBiblioteca;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbValoracion;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label lbPlataforma;
        private System.Windows.Forms.Button btPerfilGamer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.ListBox liboDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoración;
        private System.Windows.Forms.ComboBox cbValoración;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ImageList imageList1;
    }
}

