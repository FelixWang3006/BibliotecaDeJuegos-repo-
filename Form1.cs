using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public partial class Form1 : Form
    {
        List<Videojuego> biblioteca = new List<Videojuego>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btPerfilGamer_Click(object sender, EventArgs e)
        {
            Perfil_Gamer perfil_gamer = new Perfil_Gamer();
            perfil_gamer.Show();
            this.Hide();
        }

        private void btAgregarJuego_Click(object sender, EventArgs e)
        {
            Agregar_juego agregar_juego = new Agregar_juego();
            agregar_juego.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "videojuegos.txt");
            string[] lineas = File.ReadAllLines(ruta);
            foreach(string linea in lineas)
            {
                string[] datos = linea.Split(';');
                Videojuego juego = new Videojuego(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], Convert.ToDouble(datos[9]));
                biblioteca.Add(juego);
                dgvJuegos.Rows.Add(juego.Nombre, juego.Género, juego.Plataforma, juego.Puntuación);
            }
            lbTotalJuegos.Text = $"Total de juegos: {biblioteca.Count}";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            bool coincide;
            dgvJuegos.Rows.Clear();
            foreach(Videojuego juego in biblioteca)
            {
                coincide = true;
                if ((cbGenero.Text != "Todos") && (cbGenero.SelectedIndex != -1))
                {
                    if(!juego.Género.Contains(cbGenero.SelectedItem.ToString()))
                    {
                        coincide = false;
                    }
                }
                if ((cbPlataforma.Text != "Todos") && (cbPlataforma.SelectedIndex != -1))
                {
                    if (!juego.Plataforma.Contains(cbPlataforma.SelectedItem.ToString()))
                    {
                        coincide = false;
                    }
                }
                if((cbValoración.Text != "Todos") && (cbValoración.SelectedIndex != -1))
                {
                    string[] rango = cbValoración.SelectedItem.ToString().Split('-');
                    double minimo = Convert.ToDouble(rango[0]);
                    double maximo = Convert.ToDouble(rango[1]);
                    if(juego.Puntuación < minimo || juego.Puntuación >= maximo)
                    {
                        coincide = false;
                    }
                }
                if (coincide)
                {
                    dgvJuegos.Rows.Add(juego.Nombre, juego.Género, juego.Plataforma, juego.Puntuación);
                }
            }
            lbTotalJuegos.Text = $"Total de juegos: {dgvJuegos.RowCount}";
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = -1;
            cbPlataforma.SelectedIndex = -1;
            cbValoración.SelectedIndex = -1;
        }

        private void btVerDetalles_Click(object sender, EventArgs e)
        {
            if(dgvJuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un juego para ver sus detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            liboDetalles.Items.Clear();
            string nombre = dgvJuegos.SelectedRows[0].Cells[0].Value.ToString();
            foreach(Videojuego juego in biblioteca)
            {
                if (juego.Nombre == nombre)
                {
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Nombre: {juego.Nombre}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Género: {juego.Género}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Subgénero: {juego.Subgénero}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Plataforma: {juego.Plataforma}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Dificultad: {juego.Dificultad}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Duración: {juego.Duración}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Estilo Visual: {juego.EstiloVisual}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Experiencia: {juego.Experiencia}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Popularidad: {juego.Popularidad}");
                    liboDetalles.Items.Add("");
                    liboDetalles.Items.Add($"Puntuación: {juego.Puntuación}");
                    liboDetalles.Items.Add("");
                }
            }
        }
    }
}






