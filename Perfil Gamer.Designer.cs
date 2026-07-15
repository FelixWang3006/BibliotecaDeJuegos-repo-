namespace BibliotecaDeJuegos
{
    partial class Perfil_Gamer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_Gamer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPerfilGamerEnPerfilGamer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btAgregarJuegoEnPerfilGamer = new System.Windows.Forms.Button();
            this.btBibliotecaEnPerfilGamer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.reco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subgénero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dificultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popularidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTotalPerfil = new System.Windows.Forms.Label();
            this.btnQuitarSeleccionado = new System.Windows.Forms.Button();
            this.dgvAgregados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favorito = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.liboFavoritos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDetalleRecomendacion = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btPerfilGamerEnPerfilGamer);
            this.panel1.Controls.Add(this.btAgregarJuegoEnPerfilGamer);
            this.panel1.Controls.Add(this.btBibliotecaEnPerfilGamer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 749);
            this.panel1.TabIndex = 11;
            // 
            // btPerfilGamerEnPerfilGamer
            // 
            this.btPerfilGamerEnPerfilGamer.BackColor = System.Drawing.Color.Indigo;
            this.btPerfilGamerEnPerfilGamer.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btPerfilGamerEnPerfilGamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPerfilGamerEnPerfilGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerfilGamerEnPerfilGamer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPerfilGamerEnPerfilGamer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerfilGamerEnPerfilGamer.ImageIndex = 1;
            this.btPerfilGamerEnPerfilGamer.ImageList = this.imageList1;
            this.btPerfilGamerEnPerfilGamer.Location = new System.Drawing.Point(3, 212);
            this.btPerfilGamerEnPerfilGamer.Name = "btPerfilGamerEnPerfilGamer";
            this.btPerfilGamerEnPerfilGamer.Size = new System.Drawing.Size(176, 39);
            this.btPerfilGamerEnPerfilGamer.TabIndex = 27;
            this.btPerfilGamerEnPerfilGamer.Text = "Perfil Gamer";
            this.btPerfilGamerEnPerfilGamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPerfilGamerEnPerfilGamer.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Biblio.jpg");
            this.imageList1.Images.SetKeyName(1, "P.png");
            this.imageList1.Images.SetKeyName(2, "A.png");
            // 
            // btAgregarJuegoEnPerfilGamer
            // 
            this.btAgregarJuegoEnPerfilGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btAgregarJuegoEnPerfilGamer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregarJuegoEnPerfilGamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAgregarJuegoEnPerfilGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarJuegoEnPerfilGamer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregarJuegoEnPerfilGamer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAgregarJuegoEnPerfilGamer.ImageIndex = 2;
            this.btAgregarJuegoEnPerfilGamer.ImageList = this.imageList1;
            this.btAgregarJuegoEnPerfilGamer.Location = new System.Drawing.Point(3, 152);
            this.btAgregarJuegoEnPerfilGamer.Name = "btAgregarJuegoEnPerfilGamer";
            this.btAgregarJuegoEnPerfilGamer.Size = new System.Drawing.Size(176, 39);
            this.btAgregarJuegoEnPerfilGamer.TabIndex = 1;
            this.btAgregarJuegoEnPerfilGamer.Text = "Agregar Juego";
            this.btAgregarJuegoEnPerfilGamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAgregarJuegoEnPerfilGamer.UseVisualStyleBackColor = false;
            this.btAgregarJuegoEnPerfilGamer.Click += new System.EventHandler(this.btAgregarJuegoEnPerfilGamer_Click);
            // 
            // btBibliotecaEnPerfilGamer
            // 
            this.btBibliotecaEnPerfilGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btBibliotecaEnPerfilGamer.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btBibliotecaEnPerfilGamer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBibliotecaEnPerfilGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBibliotecaEnPerfilGamer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBibliotecaEnPerfilGamer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBibliotecaEnPerfilGamer.ImageIndex = 0;
            this.btBibliotecaEnPerfilGamer.ImageList = this.imageList1;
            this.btBibliotecaEnPerfilGamer.Location = new System.Drawing.Point(3, 92);
            this.btBibliotecaEnPerfilGamer.Name = "btBibliotecaEnPerfilGamer";
            this.btBibliotecaEnPerfilGamer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btBibliotecaEnPerfilGamer.Size = new System.Drawing.Size(176, 39);
            this.btBibliotecaEnPerfilGamer.TabIndex = 0;
            this.btBibliotecaEnPerfilGamer.Text = "Biblioteca";
            this.btBibliotecaEnPerfilGamer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBibliotecaEnPerfilGamer.UseVisualStyleBackColor = false;
            this.btBibliotecaEnPerfilGamer.Click += new System.EventHandler(this.btBibliotecaEnPerfilGamer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox3.Controls.Add(this.dgvJuegos);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(222, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1055, 309);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Top 20 recomendación";
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvJuegos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJuegos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvJuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reco,
            this.Genero,
            this.Subgénero,
            this.Plataforma,
            this.Dificultad,
            this.Duración,
            this.Estilo,
            this.Experiencia,
            this.Popularidad,
            this.Puntuación});
            this.dgvJuegos.EnableHeadersVisualStyles = false;
            this.dgvJuegos.Location = new System.Drawing.Point(6, 24);
            this.dgvJuegos.MultiSelect = false;
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.ReadOnly = true;
            this.dgvJuegos.RowHeadersVisible = false;
            this.dgvJuegos.RowHeadersWidth = 51;
            this.dgvJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJuegos.Size = new System.Drawing.Size(1043, 253);
            this.dgvJuegos.TabIndex = 0;
            // 
            // reco
            // 
            this.reco.HeaderText = "Juego recomendado";
            this.reco.MinimumWidth = 6;
            this.reco.Name = "reco";
            this.reco.ReadOnly = true;
            this.reco.Width = 125;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 125;
            // 
            // Subgénero
            // 
            this.Subgénero.HeaderText = "Subgénero";
            this.Subgénero.MinimumWidth = 6;
            this.Subgénero.Name = "Subgénero";
            this.Subgénero.ReadOnly = true;
            this.Subgénero.Width = 125;
            // 
            // Plataforma
            // 
            this.Plataforma.HeaderText = "Plataforma";
            this.Plataforma.MinimumWidth = 6;
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.ReadOnly = true;
            this.Plataforma.Width = 125;
            // 
            // Dificultad
            // 
            this.Dificultad.HeaderText = "Dificultad";
            this.Dificultad.MinimumWidth = 6;
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.ReadOnly = true;
            this.Dificultad.Width = 125;
            // 
            // Duración
            // 
            this.Duración.HeaderText = "Duración";
            this.Duración.MinimumWidth = 6;
            this.Duración.Name = "Duración";
            this.Duración.ReadOnly = true;
            this.Duración.Width = 125;
            // 
            // Estilo
            // 
            this.Estilo.HeaderText = "Estilo Visual";
            this.Estilo.MinimumWidth = 6;
            this.Estilo.Name = "Estilo";
            this.Estilo.ReadOnly = true;
            this.Estilo.Width = 125;
            // 
            // Experiencia
            // 
            this.Experiencia.HeaderText = "Experiencia";
            this.Experiencia.MinimumWidth = 6;
            this.Experiencia.Name = "Experiencia";
            this.Experiencia.ReadOnly = true;
            this.Experiencia.Width = 125;
            // 
            // Popularidad
            // 
            this.Popularidad.HeaderText = "Popularidad";
            this.Popularidad.MinimumWidth = 6;
            this.Popularidad.Name = "Popularidad";
            this.Popularidad.ReadOnly = true;
            this.Popularidad.Width = 125;
            // 
            // Puntuación
            // 
            this.Puntuación.HeaderText = "Puntuación";
            this.Puntuación.MinimumWidth = 6;
            this.Puntuación.Name = "Puntuación";
            this.Puntuación.ReadOnly = true;
            this.Puntuación.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.lbTotalPerfil);
            this.groupBox1.Controls.Add(this.btnQuitarSeleccionado);
            this.groupBox1.Controls.Add(this.dgvAgregados);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 324);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregados al perfil";
            // 
            // lbTotalPerfil
            // 
            this.lbTotalPerfil.AutoSize = true;
            this.lbTotalPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lbTotalPerfil.Location = new System.Drawing.Point(12, 243);
            this.lbTotalPerfil.Name = "lbTotalPerfil";
            this.lbTotalPerfil.Size = new System.Drawing.Size(101, 13);
            this.lbTotalPerfil.TabIndex = 3;
            this.lbTotalPerfil.Text = "Total en el perfil: 0";
            // 
            // btnQuitarSeleccionado
            // 
            this.btnQuitarSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnQuitarSeleccionado.Enabled = false;
            this.btnQuitarSeleccionado.FlatAppearance.BorderSize = 0;
            this.btnQuitarSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarSeleccionado.ForeColor = System.Drawing.Color.White;
            this.btnQuitarSeleccionado.Location = new System.Drawing.Point(15, 272);
            this.btnQuitarSeleccionado.Name = "btnQuitarSeleccionado";
            this.btnQuitarSeleccionado.Size = new System.Drawing.Size(114, 23);
            this.btnQuitarSeleccionado.TabIndex = 2;
            this.btnQuitarSeleccionado.Text = "Eliminar del perfil";
            this.btnQuitarSeleccionado.UseVisualStyleBackColor = false;
            // 
            // dgvAgregados
            // 
            this.dgvAgregados.AllowUserToAddRows = false;
            this.dgvAgregados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvAgregados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgregados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAgregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Favorito});
            this.dgvAgregados.EnableHeadersVisualStyles = false;
            this.dgvAgregados.Location = new System.Drawing.Point(15, 40);
            this.dgvAgregados.MultiSelect = false;
            this.dgvAgregados.Name = "dgvAgregados";
            this.dgvAgregados.RowHeadersVisible = false;
            this.dgvAgregados.RowHeadersWidth = 51;
            this.dgvAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregados.Size = new System.Drawing.Size(240, 185);
            this.dgvAgregados.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 65F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Favorito
            // 
            this.Favorito.FillWeight = 35F;
            this.Favorito.HeaderText = "Favorito (Si/No)";
            this.Favorito.MinimumWidth = 6;
            this.Favorito.Name = "Favorito";
            this.Favorito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Favorito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox2.Controls.Add(this.liboFavoritos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(519, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 324);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mis favoritos";
            // 
            // liboFavoritos
            // 
            this.liboFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.liboFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liboFavoritos.ForeColor = System.Drawing.Color.White;
            this.liboFavoritos.FormattingEnabled = true;
            this.liboFavoritos.Location = new System.Drawing.Point(22, 40);
            this.liboFavoritos.Margin = new System.Windows.Forms.Padding(2);
            this.liboFavoritos.Name = "liboFavoritos";
            this.liboFavoritos.Size = new System.Drawing.Size(186, 262);
            this.liboFavoritos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Call of duty";
            this.label1.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox4.Controls.Add(this.lbDetalleRecomendacion);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(777, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coincidencia";
            // 
            // lbDetalleRecomendacion
            // 
            this.lbDetalleRecomendacion.ForeColor = System.Drawing.Color.White;
            this.lbDetalleRecomendacion.Location = new System.Drawing.Point(10, 22);
            this.lbDetalleRecomendacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDetalleRecomendacion.Name = "lbDetalleRecomendacion";
            this.lbDetalleRecomendacion.Size = new System.Drawing.Size(180, 67);
            this.lbDetalleRecomendacion.TabIndex = 0;
            this.lbDetalleRecomendacion.Text = "Marque uno o mas juegos como favoritos para generar recomendaciones.";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.groupBox5.Controls.Add(this.lbPerfil);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(777, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 165);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Perfil Gamer";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lbPerfil.ForeColor = System.Drawing.Color.White;
            this.lbPerfil.Location = new System.Drawing.Point(10, 40);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(174, 65);
            this.lbPerfil.TabIndex = 5;
            this.lbPerfil.Text = "Juegos en perfil: 0\nFavoritos: 0\nGenero mas frecuente: Sin datos\nPlataforma favor" +
    "ita: Sin datos\nValoracion promedio: 0.0";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Image = global::BibliotecaDeJuegos.Properties.Resources.GameMatch11;
            this.pbLogo.Location = new System.Drawing.Point(1031, 49);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(246, 105);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 34;
            this.pbLogo.TabStop = false;
            // 
            // Perfil_Gamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1307, 749);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Perfil_Gamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil Gamer";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPerfilGamerEnPerfilGamer;
        private System.Windows.Forms.Button btAgregarJuegoEnPerfilGamer;
        private System.Windows.Forms.Button btBibliotecaEnPerfilGamer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotalPerfil;
        private System.Windows.Forms.Button btnQuitarSeleccionado;
        private System.Windows.Forms.DataGridView dgvAgregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn reco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subgénero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dificultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duración;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popularidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Favorito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.ListBox liboFavoritos;
        private System.Windows.Forms.Label lbDetalleRecomendacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
