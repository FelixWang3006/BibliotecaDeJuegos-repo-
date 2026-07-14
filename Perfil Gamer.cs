using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public partial class Perfil_Gamer : Form
    {
        private bool actualizandoTabla;
        private ToolTip ayuda = new ToolTip();

        public Perfil_Gamer()
        {
            InitializeComponent();

            this.Load += Perfil_Gamer_Load;
            btnQuitarSeleccionado.Click += btnQuitarSeleccionado_Click;
            dgvAgregados.CurrentCellDirtyStateChanged += dgvAgregados_CurrentCellDirtyStateChanged;
            dgvAgregados.CellValueChanged += dgvAgregados_CellValueChanged;
            dgvAgregados.SelectionChanged += dgvAgregados_SelectionChanged;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            this.FormClosed += Ventana_FormClosed;

            CrearControlesAuxiliares();
            AplicarEstiloInterfaz();
        }

        private void CrearControlesAuxiliares()
        {
            //label4.Visible = false;
            //label5.Visible = false;
            label1.Visible = true;
            lbTotalPerfil.Text = "Total en el perfil: 0";
            lbPerfil.Text = "Juegos en perfil: 0" +
                "\nFavoritos: 0" +
                "\nGénero mas frecuente: Sin datos" +
                "\nPlataforma favorita: Sin datos" +
                "\nValoración promedio: 0.0";

            dgvAgregados.MultiSelect = false;
            dgvAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgregados.AllowUserToDeleteRows = false;
            btnQuitarSeleccionado.Text = "Eliminar del perfil";

            groupBox2.Text = "Mis favoritos (0)";

            lbDetalleRecomendacion.Text = "Seleccione una recomendación.";
            groupBox4.Text = "Coincidencia";

            dgvJuegos.ReadOnly = true;
            dgvJuegos.MultiSelect = false;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AplicarEstiloInterfaz()
        {
          
            this.BackColor = Color.FromArgb(27, 38, 59); 

           
            groupBox1.BackColor = Color.Transparent;
            groupBox1.ForeColor = Color.White; 

            groupBox2.BackColor = Color.Transparent;
            groupBox2.ForeColor = Color.White; 

            groupBox3.BackColor = Color.Transparent;
            groupBox3.ForeColor = Color.White;

            groupBox4.BackColor = Color.Transparent;
            groupBox4.ForeColor = Color.White;

            groupBox5.BackColor = Color.Transparent;
            groupBox5.ForeColor = Color.White; 

            AplicarEstiloTabla(dgvAgregados);
            AplicarEstiloTabla(dgvJuegos);

            dgvAgregados.Columns[1].HeaderText = "Favorito (Si/No)";
            dgvAgregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgregados.Columns[0].FillWeight = 65;
            dgvAgregados.Columns[1].FillWeight = 35;

          
            btnQuitarSeleccionado.AutoSize = false;
            btnQuitarSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
            btnQuitarSeleccionado.FlatStyle = FlatStyle.Flat;
            btnQuitarSeleccionado.FlatAppearance.BorderSize = 0;
            btnQuitarSeleccionado.Enabled = false;
            btnQuitarSeleccionado.BackColor = Color.FromArgb(80, 60, 120);
            btnQuitarSeleccionado.ForeColor = Color.FromArgb(180, 180, 180);

            liboFavoritos.BorderStyle = BorderStyle.None;
            liboFavoritos.BackColor = Color.FromArgb(30, 41, 59); 
            liboFavoritos.ForeColor = Color.White;

            lbTotalPerfil.ForeColor = Color.White;
            lbPerfil.ForeColor = Color.White;
            lbDetalleRecomendacion.ForeColor = Color.FromArgb(200, 200, 200); 

            ayuda.SetToolTip(dgvAgregados,
                "Marque la casilla para agregar o quitar un juego de favoritos.");
            ayuda.SetToolTip(btnQuitarSeleccionado, "Eliminar el juego seleccionado del perfil.");
            ayuda.SetToolTip(dgvJuegos, "Las recomendaciones cambian automaticamente con sus favoritos.");
            ayuda.SetToolTip(liboFavoritos, "Juegos utilizados para calcular el Top 20.");
        }
        

        private void AplicarEstiloTabla(DataGridView tabla)
        {
            tabla.BackgroundColor = Color.FromArgb(30, 41, 59);
            tabla.BorderStyle = BorderStyle.None;
            tabla.RowHeadersVisible = false;

            
            tabla.CellBorderStyle = DataGridViewCellBorderStyle.Single; 
            tabla.GridColor = Color.FromArgb(255, 255, 255); 

            tabla.EnableHeadersVisualStyles = false;
            tabla.ColumnHeadersVisible = true;

           
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 58, 237);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font(tabla.Font, FontStyle.Bold);

           
            tabla.DefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            tabla.DefaultCellStyle.ForeColor = Color.White;
            tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(39, 51, 71);

         
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 58, 237);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void Perfil_Gamer_Load(object sender, EventArgs e)
        {
            try
            {
                DatosGameMatch.CargarBiblioteca();
                ActualizarPerfilCompleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el perfil: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPerfilCompleto()
        {
            actualizandoTabla = true;
            dgvAgregados.Rows.Clear();

            for (int i = 0; i < DatosGameMatch.JuegosPerfil.Count; i++)
            {
                Videojuego juego = DatosGameMatch.JuegosPerfil[i];
                dgvAgregados.Rows.Add(juego.Nombre, DatosGameMatch.EsFavorito(juego.Nombre));
            }

            actualizandoTabla = false;
            lbTotalPerfil.Text = "Total en el perfil: " + DatosGameMatch.JuegosPerfil.Count;

            MostrarFavoritos();
            MostrarRecomendaciones();
            MostrarResumenPerfil();
            dgvAgregados_SelectionChanged(null, null);
        }

        private void MostrarFavoritos()
        {
            List<Videojuego> favoritos = DatosGameMatch.ObtenerFavoritos();
            liboFavoritos.Items.Clear();

            for (int i = 0; i < favoritos.Count; i++)
            {
                liboFavoritos.Items.Add(favoritos[i].Nombre);
            }

            groupBox2.Text = "Mis favoritos (" + favoritos.Count + ")";
        }

        private void MostrarRecomendaciones()
        {
            List<Videojuego> recomendaciones = DatosGameMatch.ObtenerRecomendaciones();
            dgvJuegos.Rows.Clear();

            for (int i = 0; i < recomendaciones.Count; i++)
            {
                Videojuego juego = recomendaciones[i];
                dgvJuegos.Rows.Add(juego.Nombre, juego.Género, juego.Subgénero,
                    juego.Plataforma, juego.Dificultad, juego.Duración,
                    juego.EstiloVisual, juego.Experiencia, juego.Popularidad,
                    juego.Puntuación.ToString("0.0"));
            }

            groupBox3.Text = "Top 20 recomendaciones (" + recomendaciones.Count + ")";

            if (recomendaciones.Count == 0)
            {
                lbDetalleRecomendacion.Text = "Marque uno o mas juegos como favoritos para generar recomendaciones.";
            }
        }

        private void MostrarResumenPerfil()
        {
            List<Videojuego> perfil = DatosGameMatch.JuegosPerfil;
            List<Videojuego> favoritos = DatosGameMatch.ObtenerFavoritos();
            string generoFrecuente = ObtenerDatoFrecuente(perfil, true);
            string plataformaFrecuente = ObtenerDatoFrecuente(perfil, false);
            double promedio = 0;

            for (int i = 0; i < perfil.Count; i++)
            {
                promedio += perfil[i].Puntuación;
            }

            if (perfil.Count > 0)
            {
                promedio = promedio / perfil.Count;
            }

            lbPerfil.Text = "Juegos en perfil: " + perfil.Count +
                "\nFavoritos: " + favoritos.Count +
                "\nGenero mas frecuente: " + generoFrecuente +
                "\nPlataforma favorita: " + plataformaFrecuente +
                "\nValoracion promedio: " + promedio.ToString("0.0");
        }

        private string ObtenerDatoFrecuente(List<Videojuego> juegos, bool usarGenero)
        {
            string datoFrecuente = "Sin datos";
            int mayorCantidad = 0;

            for (int i = 0; i < juegos.Count; i++)
            {
                string datoActual = usarGenero ? juegos[i].Género : juegos[i].Plataforma;
                int cantidad = 0;

                for (int j = 0; j < juegos.Count; j++)
                {
                    string datoComparado = usarGenero ? juegos[j].Género : juegos[j].Plataforma;

                    if (datoActual == datoComparado)
                    {
                        cantidad++;
                    }
                }

                if (cantidad > mayorCantidad)
                {
                    mayorCantidad = cantidad;
                    datoFrecuente = datoActual;
                }
            }

            return datoFrecuente;
        }

        private void dgvAgregados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAgregados.IsCurrentCellDirty)
            {
                dgvAgregados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvAgregados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (actualizandoTabla || e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            string nombre = dgvAgregados.Rows[e.RowIndex].Cells[0].Value.ToString();
            object valor = dgvAgregados.Rows[e.RowIndex].Cells[1].Value;
            bool esFavorito = valor != null && Convert.ToBoolean(valor);

            DatosGameMatch.CambiarFavorito(nombre, esFavorito);
            MostrarFavoritos();
            MostrarRecomendaciones();
            MostrarResumenPerfil();
        }

        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            if (dgvAgregados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un juego del perfil.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = dgvAgregados.SelectedRows[0].Cells[0].Value.ToString();
            DatosGameMatch.QuitarDelPerfil(nombre);
            ActualizarPerfilCompleto();
        }

        private void dgvAgregados_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvAgregados.SelectedRows.Count > 0 && dgvAgregados.SelectedRows[0].Cells[0].Value != null;

            btnQuitarSeleccionado.Enabled = haySeleccion;

            if (haySeleccion)
            {
               
                btnQuitarSeleccionado.BackColor = Color.FromArgb(124, 58, 237);
                btnQuitarSeleccionado.ForeColor = Color.White;
            }
            else
            {
              
                btnQuitarSeleccionado.BackColor = Color.FromArgb(80, 60, 120);
                btnQuitarSeleccionado.ForeColor = Color.FromArgb(180, 180, 180);
            }
        }

        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJuegos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvJuegos.SelectedRows[0];
                lbDetalleRecomendacion.Text = fila.Cells[0].Value +
                    "\nGénero: " + fila.Cells[1].Value +
                    "\nPlataforma: " + fila.Cells[3].Value +
                    "\nValoración: " + fila.Cells[9].Value;
            }
        }

        private void btBibliotecaEnPerfilGamer_Click(object sender, EventArgs e)
        {
            Form1 biblioteca = new Form1();
            biblioteca.Show();
            this.Hide();
        }

        private void btAgregarJuegoEnPerfilGamer_Click(object sender, EventArgs e)
        {
            Agregar_juego agregarJuego = new Agregar_juego();
            agregarJuego.Show();
            this.Hide();
        }

        private void Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
