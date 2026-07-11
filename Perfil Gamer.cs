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
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            this.FormClosed += Ventana_FormClosed;

            CrearControlesAuxiliares();
            AplicarEstiloInterfaz();
        }

        private void CrearControlesAuxiliares()
        {
            label4.Visible = false;
            label5.Visible = false;
            label1.Visible = false;
            label2.Text = "Total en el perfil: 0";
            label3.Text = "Juegos en perfil: 0" +
                "\nFavoritos: 0" +
                "\nGenero mas frecuente: Sin datos" +
                "\nPlataforma favorita: Sin datos" +
                "\nValoracion promedio: 0.0";

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToDeleteRows = false;
            btnQuitarSeleccionado.Text = "Eliminar del perfil";

            groupBox2.Text = "Mis favoritos (0)";

            lbDetalleRecomendacion.Text = "Seleccione una recomendacion.";
            groupBox4.Text = "Coincidencia";

            dgvJuegos.ReadOnly = true;
            dgvJuegos.MultiSelect = false;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AplicarEstiloInterfaz()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            groupBox1.BackColor = Color.White;
            groupBox2.BackColor = Color.White;
            groupBox3.BackColor = Color.White;
            groupBox4.BackColor = Color.White;
            groupBox5.BackColor = Color.White;

            AplicarEstiloTabla(dataGridView1);
            AplicarEstiloTabla(dgvJuegos);
            dataGridView1.Columns[1].HeaderText = "Favorito (Si/No)";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].FillWeight = 65;
            dataGridView1.Columns[1].FillWeight = 35;

            btnQuitarSeleccionado.BackColor = Color.FromArgb(220, 38, 38);
            btnQuitarSeleccionado.ForeColor = Color.White;
            btnQuitarSeleccionado.FlatStyle = FlatStyle.Flat;
            btnQuitarSeleccionado.FlatAppearance.BorderSize = 0;
            btnQuitarSeleccionado.Enabled = false;

            listaFavoritos.BorderStyle = BorderStyle.FixedSingle;
            listaFavoritos.BackColor = Color.FromArgb(248, 250, 252);
            label3.ForeColor = Color.FromArgb(30, 41, 59);
            lbDetalleRecomendacion.ForeColor = Color.FromArgb(51, 65, 85);

            ayuda.SetToolTip(dataGridView1,
                "Marque la casilla para agregar o quitar un juego de favoritos.");
            ayuda.SetToolTip(btnQuitarSeleccionado, "Eliminar el juego seleccionado del perfil.");
            ayuda.SetToolTip(dgvJuegos, "Las recomendaciones cambian automaticamente con sus favoritos.");
            ayuda.SetToolTip(listaFavoritos, "Juegos utilizados para calcular el Top 20.");
        }

        private void AplicarEstiloTabla(DataGridView tabla)
        {
            tabla.BackgroundColor = Color.White;
            tabla.BorderStyle = BorderStyle.None;
            tabla.RowHeadersVisible = false;
            tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.EnableHeadersVisualStyles = false;
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
            dataGridView1.Rows.Clear();

            for (int i = 0; i < DatosGameMatch.JuegosPerfil.Count; i++)
            {
                Videojuego juego = DatosGameMatch.JuegosPerfil[i];
                dataGridView1.Rows.Add(juego.Nombre, DatosGameMatch.EsFavorito(juego.Nombre));
            }

            actualizandoTabla = false;
            label2.Text = "Total en el perfil: " + DatosGameMatch.JuegosPerfil.Count;

            MostrarFavoritos();
            MostrarRecomendaciones();
            MostrarResumenPerfil();
        }

        private void MostrarFavoritos()
        {
            List<Videojuego> favoritos = DatosGameMatch.ObtenerFavoritos();
            listaFavoritos.Items.Clear();

            for (int i = 0; i < favoritos.Count; i++)
            {
                listaFavoritos.Items.Add(favoritos[i].Nombre);
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

            label3.Text = "Juegos en perfil: " + perfil.Count +
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

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (actualizandoTabla || e.RowIndex < 0 || e.ColumnIndex != 1)
            {
                return;
            }

            string nombre = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            object valor = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            bool esFavorito = valor != null && Convert.ToBoolean(valor);

            DatosGameMatch.CambiarFavorito(nombre, esFavorito);
            MostrarFavoritos();
            MostrarRecomendaciones();
            MostrarResumenPerfil();
        }

        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un juego del perfil.", "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DatosGameMatch.QuitarDelPerfil(nombre);
            ActualizarPerfilCompleto();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnQuitarSeleccionado.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvJuegos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvJuegos.SelectedRows[0];
                lbDetalleRecomendacion.Text = fila.Cells[0].Value +
                    "\nGenero: " + fila.Cells[1].Value +
                    "\nPlataforma: " + fila.Cells[3].Value +
                    "\nValoracion: " + fila.Cells[9].Value;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
