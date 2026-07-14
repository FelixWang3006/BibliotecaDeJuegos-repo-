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
            btnLimpiar.Click += btnLimpiar_Click;
            btnQuitarSeleccionado.Click += btnQuitarSeleccionado_Click;
            txtNombreJuego.KeyPress += txtNombreJuego_KeyPress;
            txtNombreJuego.TextChanged += CamposJuego_Cambiaron;
            cbGenero.SelectedIndexChanged += CamposJuego_Cambiaron;
            cbPlataforma.SelectedIndexChanged += CamposJuego_Cambiaron;
            dgvAgregados.SelectionChanged += dgvAgregados_SelectionChanged;
            this.KeyDown += Agregar_juego_KeyDown;
            this.FormClosed += Ventana_FormClosed;

            AplicarEstiloInterfaz();
        }

        private void AplicarEstiloInterfaz()
        {
          
            this.BackColor = Color.FromArgb(27, 38, 59); 
            this.KeyPreview = true;

          
            groupBox1.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;

         
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Enabled = false;
            btnAgregar.BackColor = Color.FromArgb(80, 60, 120); 
            btnAgregar.ForeColor = Color.FromArgb(180, 180, 180); 

           
            btnLimpiar.BackColor = Color.FromArgb(71, 85, 105); 
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;

            
            btnQuitarSeleccionado.FlatStyle = FlatStyle.Flat;
            btnQuitarSeleccionado.FlatAppearance.BorderSize = 0;
            btnQuitarSeleccionado.Enabled = false;
            btnQuitarSeleccionado.BackColor = Color.FromArgb(80, 60, 120); 
            btnQuitarSeleccionado.ForeColor = Color.FromArgb(180, 180, 180);

           
            dgvAgregados.BackgroundColor = Color.FromArgb(30, 41, 59); 
            dgvAgregados.BorderStyle = BorderStyle.None;
            dgvAgregados.RowHeadersVisible = false;
            dgvAgregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgregados.MultiSelect = false;

            
            dgvAgregados.EnableHeadersVisualStyles = false;
            dgvAgregados.ColumnHeadersVisible = true;

           
            dgvAgregados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 92, 246);
            dgvAgregados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAgregados.ColumnHeadersDefaultCellStyle.Font = new Font(dgvAgregados.Font, FontStyle.Bold);

            
            dgvAgregados.DefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvAgregados.DefaultCellStyle.ForeColor = Color.White;
            dgvAgregados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(39, 51, 71); 

            dgvAgregados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 58, 237); 
            dgvAgregados.DefaultCellStyle.SelectionForeColor = Color.White;

            txtNombreJuego.MaxLength = 80;

            ayuda.SetToolTip(txtNombreJuego, "Escriba un nombre único para el juego.");
            ayuda.SetToolTip(cbGenero, "Use el mismo género disponible en la Biblioteca.");
            ayuda.SetToolTip(cbPlataforma, "Las plataformas coinciden con el filtro de Biblioteca.");
            ayuda.SetToolTip(nudValoracion, "Valoración personal entre 1 y 10.");
            ayuda.SetToolTip(btnAgregar, "Guardar el juego (también puede presionar Enter).");
        }

        private void Agregar_juego_Load(object sender, EventArgs e)
        {
            dgvAgregados.Rows.Clear();
            lbTotalAgregados.Text = "Total de agregados: 0";

            try
            {
                DatosGameMatch.CargarBiblioteca();
                dgvAgregados.ReadOnly = true;
                dgvAgregados.MultiSelect = false;
                dgvAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                MostrarJuegosAgregados();
                txtNombreJuego.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la biblioteca: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreJuego.Text.Trim();
                string genero = ObtenerGeneroValido(cbGenero.Text);
                string plataforma = ObtenerPlataformaValida(cbPlataforma.Text);
                double valoracion = Convert.ToDouble(nudValoracion.Value);

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
                MessageBox.Show(ex.Message, "Dato inválido",
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
                throw new ArgumentException("Debe seleccionar el género.");
            }

            return genero;
        }

        private void MostrarJuegosAgregados()
        {
            dgvAgregados.Rows.Clear();
            int total = 0;

            for (int i = 0; i < DatosGameMatch.Biblioteca.Count; i++)
            {
                if (DatosGameMatch.Biblioteca[i].EsAgregadoPorUsuario())
                {
                    dgvAgregados.Rows.Add(DatosGameMatch.Biblioteca[i].Nombre);
                    total++;
                }
            }

            lbTotalAgregados.Text = "Total de agregados: " + total;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreJuego.Clear();
            cbGenero.SelectedIndex = -1;
            cbPlataforma.SelectedIndex = -1;
            nudValoracion.Value = 1;
            txtNombreJuego.Focus();

           
            CamposJuego_Cambiaron(null, null);


        }

        private void CamposJuego_Cambiaron(object sender, EventArgs e)
        {
            bool camposValidos = !string.IsNullOrWhiteSpace(txtNombreJuego.Text) &&
                         cbGenero.SelectedIndex != -1 &&
                         cbPlataforma.SelectedIndex != -1;

            btnAgregar.Enabled = camposValidos;

            if (camposValidos)
            {
                
                btnAgregar.BackColor = Color.FromArgb(124, 58, 237);
                btnAgregar.ForeColor = Color.White;

                if (lbEstadoFormulario != null)
                {
                    lbEstadoFormulario.ForeColor = Color.FromArgb(34, 197, 94);
                    lbEstadoFormulario.Text = "Campos listos para guardar.";
                }
            }
            else
            {
          
                btnAgregar.BackColor = Color.FromArgb(80, 60, 120);
                btnAgregar.ForeColor = Color.FromArgb(180, 180, 180);

                if (lbEstadoFormulario != null)
                {
                    lbEstadoFormulario.ForeColor = Color.FromArgb(148, 163, 184);
                    lbEstadoFormulario.Text = "Complete los datos para habilitar el botón Agregar.";
                }
            }
        }
        

        private void dgvAgregados_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvAgregados.SelectedRows.Count > 0;
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

        private void Agregar_juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnAgregar.Enabled)
            {
                btnAgregar.PerformClick();
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
                if (dgvAgregados.SelectedRows.Count == 0)
                {
                    throw new ArgumentException("Seleccione un juego agregado para eliminarlo.");
                }

                string nombre = dgvAgregados.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar " + nombre + "?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    DatosGameMatch.EliminarJuegoAgregado(nombre);
                    MostrarJuegosAgregados();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el juego: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreJuego_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nudValoracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

          
            NumericUpDown control = (NumericUpDown)sender;
            string textoResultante = control.Text + e.KeyChar.ToString();

            
            string patronProgreso = @"^[0-9]{1,2}$|^[0-9]{1,2}\.$|^[0-9]{1,2}\.[0-9]$";

            
            if (System.Text.RegularExpressions.Regex.IsMatch(textoResultante, patronProgreso))
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true;  
            }
        }

        private void nudValoracion_Enter(object sender, EventArgs e)
        {
          
            this.BeginInvoke((MethodInvoker)delegate
            {
                nudValoracion.Select(nudValoracion.Text.Length, 0);
            });
        }
    }
}
