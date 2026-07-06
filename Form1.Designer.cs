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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btVerDetalles = new System.Windows.Forms.Button();
            this.btAgregarPerfil = new System.Windows.Forms.Button();
            this.lbTotalJuegos = new System.Windows.Forms.Label();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoración = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbValoración = new System.Windows.Forms.ComboBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPlataforma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPerfilGamer = new System.Windows.Forms.Button();
            this.btAgregarJuego = new System.Windows.Forms.Button();
            this.btBiblioteca = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.liboDetalles = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerDetalles);
            this.groupBox1.Controls.Add(this.btAgregarPerfil);
            this.groupBox1.Controls.Add(this.lbTotalJuegos);
            this.groupBox1.Controls.Add(this.dgvJuegos);
            this.groupBox1.Location = new System.Drawing.Point(165, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biblioteca de Juegos";
            // 
            // btVerDetalles
            // 
            this.btVerDetalles.Location = new System.Drawing.Point(139, 238);
            this.btVerDetalles.Name = "btVerDetalles";
            this.btVerDetalles.Size = new System.Drawing.Size(108, 23);
            this.btVerDetalles.TabIndex = 7;
            this.btVerDetalles.Text = "Ver detalles";
            this.btVerDetalles.UseVisualStyleBackColor = true;
            this.btVerDetalles.Click += new System.EventHandler(this.btVerDetalles_Click);
            // 
            // btAgregarPerfil
            // 
            this.btAgregarPerfil.Location = new System.Drawing.Point(139, 200);
            this.btAgregarPerfil.Name = "btAgregarPerfil";
            this.btAgregarPerfil.Size = new System.Drawing.Size(108, 23);
            this.btAgregarPerfil.TabIndex = 2;
            this.btAgregarPerfil.Text = "Agregar al perfil";
            this.btAgregarPerfil.UseVisualStyleBackColor = true;
            // 
            // lbTotalJuegos
            // 
            this.lbTotalJuegos.AutoSize = true;
            this.lbTotalJuegos.Location = new System.Drawing.Point(14, 205);
            this.lbTotalJuegos.Name = "lbTotalJuegos";
            this.lbTotalJuegos.Size = new System.Drawing.Size(110, 13);
            this.lbTotalJuegos.TabIndex = 1;
            this.lbTotalJuegos.Text = "Total de Juegos: ###";
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AllowUserToAddRows = false;
            this.dgvJuegos.AllowUserToDeleteRows = false;
            this.dgvJuegos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Genero,
            this.Plataforma,
            this.Valoración});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJuegos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJuegos.Location = new System.Drawing.Point(6, 21);
            this.dgvJuegos.MultiSelect = false;
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.ReadOnly = true;
            this.dgvJuegos.Size = new System.Drawing.Size(544, 150);
            this.dgvJuegos.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.cbValoración);
            this.groupBox2.Controls.Add(this.btLimpiar);
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbPlataforma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbGenero);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(165, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de búsqueda";
            // 
            // cbValoración
            // 
            this.cbValoración.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbValoración.Location = new System.Drawing.Point(294, 46);
            this.cbValoración.Name = "cbValoración";
            this.cbValoración.Size = new System.Drawing.Size(121, 21);
            this.cbValoración.TabIndex = 11;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(216, 73);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(123, 23);
            this.btLimpiar.TabIndex = 10;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(31, 73);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(123, 23);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valoración";
            // 
            // cbPlataforma
            // 
            this.cbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlataforma.FormattingEnabled = true;
            this.cbPlataforma.Items.AddRange(new object[] {
            "Todos",
            "Móviles",
            "Nintendo",
            "PlayStation",
            "PC",
            "Sega Genesis",
            "Xbox"});
            this.cbPlataforma.Location = new System.Drawing.Point(149, 44);
            this.cbPlataforma.Name = "cbPlataforma";
            this.cbPlataforma.Size = new System.Drawing.Size(121, 21);
            this.cbPlataforma.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plataforma";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbGenero.Location = new System.Drawing.Point(8, 44);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Género";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btPerfilGamer);
            this.panel1.Controls.Add(this.btAgregarJuego);
            this.panel1.Controls.Add(this.btBiblioteca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 463);
            this.panel1.TabIndex = 4;
            // 
            // btPerfilGamer
            // 
            this.btPerfilGamer.BackColor = System.Drawing.Color.Navy;
            this.btPerfilGamer.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btPerfilGamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerfilGamer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPerfilGamer.Location = new System.Drawing.Point(20, 69);
            this.btPerfilGamer.Name = "btPerfilGamer";
            this.btPerfilGamer.Size = new System.Drawing.Size(109, 23);
            this.btPerfilGamer.TabIndex = 5;
            this.btPerfilGamer.Text = "Perfil Gamer";
            this.btPerfilGamer.UseVisualStyleBackColor = false;
            this.btPerfilGamer.Click += new System.EventHandler(this.btPerfilGamer_Click);
            // 
            // btAgregarJuego
            // 
            this.btAgregarJuego.BackColor = System.Drawing.Color.Navy;
            this.btAgregarJuego.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarJuego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAgregarJuego.Location = new System.Drawing.Point(20, 110);
            this.btAgregarJuego.Name = "btAgregarJuego";
            this.btAgregarJuego.Size = new System.Drawing.Size(109, 23);
            this.btAgregarJuego.TabIndex = 1;
            this.btAgregarJuego.Text = "Agregar Juego";
            this.btAgregarJuego.UseVisualStyleBackColor = false;
            this.btAgregarJuego.Click += new System.EventHandler(this.btAgregarJuego_Click);
            // 
            // btBiblioteca
            // 
            this.btBiblioteca.BackColor = System.Drawing.Color.Red;
            this.btBiblioteca.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBiblioteca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBiblioteca.Location = new System.Drawing.Point(20, 30);
            this.btBiblioteca.Name = "btBiblioteca";
            this.btBiblioteca.Size = new System.Drawing.Size(109, 23);
            this.btBiblioteca.TabIndex = 0;
            this.btBiblioteca.Text = "Biblioteca";
            this.btBiblioteca.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.liboDetalles);
            this.groupBox3.Location = new System.Drawing.Point(737, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 408);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles";
            // 
            // liboDetalles
            // 
            this.liboDetalles.FormattingEnabled = true;
            this.liboDetalles.Location = new System.Drawing.Point(10, 23);
            this.liboDetalles.Name = "liboDetalles";
            this.liboDetalles.Size = new System.Drawing.Size(191, 368);
            this.liboDetalles.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Biblioteca de Juegos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAgregarPerfil;
        private System.Windows.Forms.Label lbTotalJuegos;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAgregarJuego;
        private System.Windows.Forms.Button btBiblioteca;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlataforma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPerfilGamer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btVerDetalles;
        private System.Windows.Forms.ListBox liboDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoración;
        private System.Windows.Forms.ComboBox cbValoración;
    }
}

