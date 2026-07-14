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
            btnAgregarPerfil.Click += btAgregarPerfil_Click;
            btnVerDetalles.Click += btVerDetalles_Click;
            dgvJuegos.CellDoubleClick += dgvJuegos_CellDoubleClick;
            dgvJuegos.SelectionChanged += dgvJuegos_SelectionChanged;
            dgvJuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormClosed += Ventana_FormClosed;
            AplicarEstiloInterfaz();
        }

        private void AplicarEstiloInterfaz()
        {
            
            btnAgregarPerfil.Enabled = true;
            btnVerDetalles.Enabled = true;

            
            btnAgregarPerfil.BackColor = Color.FromArgb(60, 40, 110);
            btnAgregarPerfil.ForeColor = Color.White;
            btnAgregarPerfil.FlatStyle = FlatStyle.Flat;
            btnAgregarPerfil.FlatAppearance.BorderSize = 0;

            btnVerDetalles.BackColor = Color.FromArgb(30, 35, 55);
            btnVerDetalles.ForeColor = Color.White;
            btnVerDetalles.FlatStyle = FlatStyle.Flat;
            btnVerDetalles.FlatAppearance.BorderSize = 0;

            lbTotalJuegos.Font = new Font(lbTotalJuegos.Font, FontStyle.Bold);

         
            dgvJuegos.EnableHeadersVisualStyles = false;
            dgvJuegos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(124, 58, 237);
            dgvJuegos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvJuegos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvJuegos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dgvJuegos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvJuegos.ColumnHeadersHeight = 35;

            dgvJuegos.BackgroundColor = Color.FromArgb(22, 30, 46);
            dgvJuegos.BorderStyle = BorderStyle.None;
            dgvJuegos.RowHeadersVisible = false;
            dgvJuegos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvJuegos.GridColor = Color.FromArgb(51, 65, 85);

            dgvJuegos.RowsDefaultCellStyle.BackColor = Color.FromArgb(22, 30, 46);
            dgvJuegos.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvJuegos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 30, 46);
            dgvJuegos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvJuegos.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 58, 237);
            dgvJuegos.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            ayuda.SetToolTip(btnBuscar, "Aplicar los tres filtros seleccionados.");
            ayuda.SetToolTip(btnLimpiar, "Restablecer filtros y mostrar todos los juegos.");
            ayuda.SetToolTip(btnAgregarPerfil, "Agregar el juego seleccionado al perfil gamer.");
            ayuda.SetToolTip(btnVerDetalles, "Mostrar todos los datos del juego seleccionado.");
            ayuda.SetToolTip(dgvJuegos, "Seleccione una fila o haga doble clic para ver detalles.");

            dgvJuegos.BackgroundColor = Color.FromArgb(22, 30, 46);
            dgvJuegos.BorderStyle = BorderStyle.None;
            dgvJuegos.RowHeadersVisible = false;

          
            dgvJuegos.CellBorderStyle = DataGridViewCellBorderStyle.Single;

           
            dgvJuegos.GridColor = Color.FromArgb(255, 255, 255); 
            
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

        
            if (dgvJuegos.Rows.Count > 0)
            {
                dgvJuegos.Rows[0].Selected = true; 
            }

            dgvJuegos.Refresh();
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
            if (dgvJuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un juego de la biblioteca.", "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Videojuego juego = ObtenerJuegoSeleccionado();
                liboDetalles.Items.Clear();
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Nombre: " + juego.Nombre);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Género: " + juego.Género);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Subgénero: " + juego.Subgénero);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Plataforma: " + juego.Plataforma);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Dificultad: " + juego.Dificultad);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Duración: " + juego.Duración);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Estilo visual: " + juego.EstiloVisual);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Experiencia: " + juego.Experiencia);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Popularidad: " + juego.Popularidad);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Puntuación: " + juego.Puntuación.ToString("0.0"));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btAgregarPerfil_Click(object sender, EventArgs e)
        {
          
            if (dgvJuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un juego de la biblioteca.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show(ex.Message, "Dato inválido",
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

            if (haySeleccion)
            {
                DataGridViewRow fila = dgvJuegos.SelectedRows[0];

                liboDetalles.Items.Clear();
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add(fila.Cells[0].Value.ToString());
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Género: " + fila.Cells[1].Value);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Plataforma: " + fila.Cells[2].Value);
                liboDetalles.Items.Add("");
                liboDetalles.Items.Add("Valoración: " + fila.Cells[3].Value);

                btnAgregarPerfil.BackColor = Color.FromArgb(124, 58, 237); 
                btnAgregarPerfil.ForeColor = Color.White;

                btnVerDetalles.BackColor = Color.FromArgb(41, 49, 79);     
                btnVerDetalles.ForeColor = Color.White;
            }
            else
            {
              
                btnAgregarPerfil.BackColor = Color.FromArgb(60, 40, 110);  
                btnAgregarPerfil.ForeColor = Color.FromArgb(150, 150, 150); 

                btnVerDetalles.BackColor = Color.FromArgb(30, 35, 55);     
                btnVerDetalles.ForeColor = Color.FromArgb(150, 150, 150);
            }

            dgvJuegos.Refresh();
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
