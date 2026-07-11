using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public partial class Form1 : Form
    {
        private ToolTip ayuda = new ToolTip();

        public Form1()
        {
            InitializeComponent();
            btAgregarPerfil.Click += btAgregarPerfil_Click;
            dgvJuegos.CellDoubleClick += dgvJuegos_CellDoubleClick;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormClosed += Ventana_FormClosed;
            AplicarEstiloInterfaz();
        }

        private void AplicarEstiloInterfaz()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            groupBox1.BackColor = Color.White;
            groupBox2.BackColor = Color.White;
            groupBox3.BackColor = Color.White;

            dgvJuegos.BackgroundColor = Color.White;
            dgvJuegos.BorderStyle = BorderStyle.None;
            dgvJuegos.RowHeadersVisible = false;
            dgvJuegos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvJuegos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvJuegos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvJuegos.EnableHeadersVisualStyles = false;

            btBuscar.BackColor = Color.FromArgb(37, 99, 235);
            btBuscar.ForeColor = Color.White;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.FlatAppearance.BorderSize = 0;

            btAgregarPerfil.BackColor = Color.FromArgb(22, 163, 74);
            btAgregarPerfil.ForeColor = Color.White;
            btAgregarPerfil.FlatStyle = FlatStyle.Flat;
            btAgregarPerfil.FlatAppearance.BorderSize = 0;

            btVerDetalles.BackColor = Color.FromArgb(71, 85, 105);
            btVerDetalles.ForeColor = Color.White;
            btVerDetalles.FlatStyle = FlatStyle.Flat;
            btVerDetalles.FlatAppearance.BorderSize = 0;

            btAgregarPerfil.Enabled = false;
            btVerDetalles.Enabled = false;
            lbTotalJuegos.Font = new Font(lbTotalJuegos.Font, FontStyle.Bold);
            lbTotalJuegos.ForeColor = Color.FromArgb(30, 64, 175);

            ayuda.SetToolTip(btBuscar, "Aplicar los tres filtros seleccionados.");
            ayuda.SetToolTip(btLimpiar, "Restablecer filtros y mostrar todos los juegos.");
            ayuda.SetToolTip(btAgregarPerfil, "Agregar el juego seleccionado al perfil gamer.");
            ayuda.SetToolTip(btVerDetalles, "Mostrar todos los datos del juego seleccionado.");
            ayuda.SetToolTip(dgvJuegos, "Seleccione una fila o haga doble clic para ver detalles.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvJuegos.Rows.Clear();
            lbTotalJuegos.Text = "Total de juegos: 0";
            liboDetalles.Items.Clear();

            try
            {
                DatosGameMatch.CargarBiblioteca();
                MostrarJuegos(DatosGameMatch.Biblioteca);
                cbGenero.SelectedIndex = 0;
                cbPlataforma.SelectedIndex = 0;
                cbValoración.SelectedIndex = 0;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Archivo no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la biblioteca: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            List<Videojuego> resultados = new List<Videojuego>();

            for (int i = 0; i < DatosGameMatch.Biblioteca.Count; i++)
            {
                Videojuego juego = DatosGameMatch.Biblioteca[i];
                bool coincide = true;

                if (cbGenero.SelectedIndex > 0 &&
                    !juego.Género.Equals(cbGenero.Text, StringComparison.OrdinalIgnoreCase))
                {
                    coincide = false;
                }

                if (cbPlataforma.SelectedIndex > 0 &&
                    !juego.Plataforma.ToLower().Contains(cbPlataforma.Text.ToLower()))
                {
                    coincide = false;
                }

                if (cbValoración.SelectedIndex > 0 && !CumpleValoracion(juego.Puntuación))
                {
                    coincide = false;
                }

                if (coincide)
                {
                    resultados.Add(juego);
                }
            }

            MostrarJuegos(resultados);
            liboDetalles.Items.Clear();
        }

        private bool CumpleValoracion(double puntuacion)
        {
            string[] rango = cbValoración.Text.Split('-');
            double minimo;
            double maximo;

            if (rango.Length != 2 || !double.TryParse(rango[0].Trim(), out minimo) ||
                !double.TryParse(rango[1].Trim(), out maximo))
            {
                return true;
            }

            if (maximo == 10)
            {
                return puntuacion >= minimo && puntuacion <= maximo;
            }

            return puntuacion >= minimo && puntuacion < maximo;
        }

        private void MostrarJuegos(List<Videojuego> juegos)
        {
            dgvJuegos.Rows.Clear();

            for (int i = 0; i < juegos.Count; i++)
            {
                dgvJuegos.Rows.Add(juegos[i].Nombre, juegos[i].Género,
                    juegos[i].Plataforma, juegos[i].Puntuación.ToString("0.0"));
            }

            lbTotalJuegos.Text = "Total de juegos: " + juegos.Count;
        }

        private Videojuego ObtenerJuegoSeleccionado()
        {
            if (dgvJuegos.SelectedRows.Count == 0)
            {
                throw new ArgumentException("Seleccione un juego de la biblioteca.");
            }

            string nombre = dgvJuegos.SelectedRows[0].Cells[0].Value.ToString();

            for (int i = 0; i < DatosGameMatch.Biblioteca.Count; i++)
            {
                if (DatosGameMatch.Biblioteca[i].Nombre == nombre)
                {
                    return DatosGameMatch.Biblioteca[i];
                }
            }

            throw new ArgumentException("No se encontro el juego seleccionado.");
        }

        private void btVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                Videojuego juego = ObtenerJuegoSeleccionado();
                liboDetalles.Items.Clear();
                liboDetalles.Items.Add("Nombre: " + juego.Nombre);
                liboDetalles.Items.Add("Genero: " + juego.Género);
                liboDetalles.Items.Add("Subgenero: " + juego.Subgénero);
                liboDetalles.Items.Add("Plataforma: " + juego.Plataforma);
                liboDetalles.Items.Add("Dificultad: " + juego.Dificultad);
                liboDetalles.Items.Add("Duracion: " + juego.Duración);
                liboDetalles.Items.Add("Estilo visual: " + juego.EstiloVisual);
                liboDetalles.Items.Add("Experiencia: " + juego.Experiencia);
                liboDetalles.Items.Add("Popularidad: " + juego.Popularidad);
                liboDetalles.Items.Add("Puntuacion: " + juego.Puntuación.ToString("0.0"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btAgregarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                Videojuego juego = ObtenerJuegoSeleccionado();
                bool agregado = DatosGameMatch.AgregarAlPerfil(juego);

                if (agregado)
                {
                    MessageBox.Show(juego.Nombre + " fue agregado al perfil gamer.",
                        "Juego agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El juego ya se encuentra en el perfil gamer.",
                        "Juego existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvJuegos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btVerDetalles_Click(sender, e);
            }
        }

        private void dgvJuegos_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvJuegos.SelectedRows.Count > 0;
            btAgregarPerfil.Enabled = haySeleccion;
            btVerDetalles.Enabled = haySeleccion;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;
            cbPlataforma.SelectedIndex = 0;
            cbValoración.SelectedIndex = 0;
            liboDetalles.Items.Clear();
            MostrarJuegos(DatosGameMatch.Biblioteca);
        }

        private void btPerfilGamer_Click(object sender, EventArgs e)
        {
            Perfil_Gamer perfilGamer = new Perfil_Gamer();
            perfilGamer.Show();
            this.Hide();
        }

        private void btAgregarJuego_Click(object sender, EventArgs e)
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
