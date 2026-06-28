using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaDeJuegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picGenero_Click(object sender, EventArgs e)
        {

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string generoSeleccionado = cbGenero.SelectedItem?.ToString();

            switch (generoSeleccionado)
            {
                case "Acción":
                    picGenero.Image = Properties.Resources.accion_preview;
                    break;

                case "Aventura":
                    picGenero.Image = Properties.Resources.aventura_preview;
                    break;

                case "Deporte":
                    picGenero.Image = Properties.Resources.deporte_preview;
                    break;

                case "Carreras":
                    
                    break;

                case "Estrategia":
                    picGenero.Image = Properties.Resources.estrategia_preview;
                    break;

                case "Plataforma":
                    picGenero.Image = Properties.Resources.plataformas_preview;
                    break;

                case "Puzzle":
                    picGenero.Image = Properties.Resources.puzzle_preview;
                    break;

                case "RPG":
                    picGenero.Image = Properties.Resources.RPG_preview;
                    break;

                default:
               
                    picGenero.Image = null;
                    break;
            }
        }
    }
}





