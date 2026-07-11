using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public partial class Agregar_juego : Form
    {
        private ToolTip ayuda = new ToolTip();

        public Agregar_juego()
        {
            InitializeComponent();

            this.Load += Agregar_juego_Load;
            button2.Click += button2_Click;
            btnQuitarSeleccionado.Click += btnQuitarSeleccionado_Click;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.TextChanged += CamposJuego_Cambiaron;
            cbGenero.SelectedIndexChanged += CamposJuego_Cambiaron;
            comboBox3.SelectedIndexChanged += CamposJuego_Cambiaron;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            this.KeyDown += Agregar_juego_KeyDown;
            this.FormClosed += Ventana_FormClosed;

            AplicarEstiloInterfaz();
        }

        private void AplicarEstiloInterfaz()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.KeyPreview = true;
            groupBox1.BackColor = Color.White;
            groupBox3.BackColor = Color.White;

            button6.BackColor = Color.FromArgb(37, 99, 235);
            button6.ForeColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.Enabled = false;

            button2.BackColor = Color.FromArgb(226, 232, 240);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            btnQuitarSeleccionado.BackColor = Color.FromArgb(220, 38, 38);
            btnQuitarSeleccionado.ForeColor = Color.White;
            btnQuitarSeleccionado.FlatStyle = FlatStyle.Flat;
            btnQuitarSeleccionado.FlatAppearance.BorderSize = 0;
            btnQuitarSeleccionado.Enabled = false;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            textBox1.MaxLength = 80;

            ayuda.SetToolTip(textBox1, "Escriba un nombre unico para el juego.");
            ayuda.SetToolTip(cbGenero, "Use el mismo genero disponible en la Biblioteca.");
            ayuda.SetToolTip(comboBox3, "Las plataformas coinciden con el filtro de Biblioteca.");
            ayuda.SetToolTip(numericUpDown1, "Valoracion personal entre 1 y 10.");
            ayuda.SetToolTip(button6, "Guardar el juego (tambien puede presionar Enter).");
        }

        private void Agregar_juego_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label2.Text = "Total de agregados: 0";

            try
            {
                DatosGameMatch.CargarBiblioteca();
                dataGridView1.ReadOnly = true;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                MostrarJuegosAgregados();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la biblioteca: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox1.Text.Trim();
                string genero = ObtenerGeneroValido(cbGenero.Text);
                string plataforma = ObtenerPlataformaValida(comboBox3.Text);
                double valoracion = Convert.ToDouble(numericUpDown1.Value);

                if (nombre.Contains(";"))
                {
                    throw new ArgumentException("El nombre no puede contener punto y coma.");
                }

                Videojuego juego = new Videojuego(nombre, genero, "Agregado por usuario",
                    plataforma, "No especificada", "No especificada", "No especificado",
                    "Personal", "Nueva", valoracion);

                DatosGameMatch.AgregarJuego(juego);
                MostrarJuegosAgregados();
                LimpiarCampos();
                lbEstadoFormulario.ForeColor = Color.FromArgb(22, 163, 74);
                lbEstadoFormulario.Text = juego.Nombre + " se guardo correctamente.";

                MessageBox.Show("El juego fue agregado al archivo y a la biblioteca.",
                    "Juego agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                lbEstadoFormulario.ForeColor = Color.FromArgb(220, 38, 38);
                lbEstadoFormulario.Text = ex.Message;
                MessageBox.Show(ex.Message, "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                lbEstadoFormulario.ForeColor = Color.FromArgb(220, 38, 38);
                lbEstadoFormulario.Text = "No se pudo guardar el juego.";
                MessageBox.Show("No se pudo guardar el juego: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerPlataformaValida(string plataforma)
        {
            if (plataforma == "")
            {
                throw new ArgumentException("Debe seleccionar la plataforma.");
            }

            return plataforma;
        }

        private string ObtenerGeneroValido(string genero)
        {
            if (genero == "")
            {
                throw new ArgumentException("Debe seleccionar el genero.");
            }

            return genero;
        }

        private void MostrarJuegosAgregados()
        {
            dataGridView1.Rows.Clear();
            int total = 0;

            for (int i = 0; i < DatosGameMatch.Biblioteca.Count; i++)
            {
                if (DatosGameMatch.Biblioteca[i].EsAgregadoPorUsuario())
                {
                    dataGridView1.Rows.Add(DatosGameMatch.Biblioteca[i].Nombre);
                    total++;
                }
            }

            label2.Text = "Total de agregados: " + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            cbGenero.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            numericUpDown1.Value = 1;
            textBox1.Focus();
        }

        private void CamposJuego_Cambiaron(object sender, EventArgs e)
        {
            button6.Enabled = textBox1.Text.Trim() != "" &&
                cbGenero.SelectedIndex != -1 && comboBox3.SelectedIndex != -1;

            if (!button6.Enabled && lbEstadoFormulario != null)
            {
                lbEstadoFormulario.ForeColor = Color.FromArgb(71, 85, 105);
                lbEstadoFormulario.Text = "Complete los datos para habilitar el boton Agregar.";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnQuitarSeleccionado.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void Agregar_juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button6.Enabled)
            {
                button6.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                LimpiarCampos();
                e.SuppressKeyPress = true;
            }
        }

        private void btnQuitarSeleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new ArgumentException("Seleccione un juego agregado para eliminarlo.");
                }

                string nombre = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar " + nombre + "?",
                    "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    DatosGameMatch.EliminarJuegoAgregado(nombre);
                    MostrarJuegosAgregados();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el juego: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void btBibliotecaEnAgregarJuego_Click(object sender, EventArgs e)
        {
            Form1 biblioteca = new Form1();
            biblioteca.Show();
            this.Hide();
        }

        private void btPerfilGamerEnAgregarJuego_Click(object sender, EventArgs e)
        {
            Perfil_Gamer perfilGamer = new Perfil_Gamer();
            perfilGamer.Show();
            this.Hide();
        }

        private void Ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
