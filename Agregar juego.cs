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
    public partial class Agregar_juego : Form
    {
        public Agregar_juego()
        {
            InitializeComponent();
        }

        private void btBibliotecaEnAgregarJuego_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btPerfilGamerEnAgregarJuego_Click(object sender, EventArgs e)
        {
            Perfil_Gamer perfil_gamer = new Perfil_Gamer();
            perfil_gamer.Show();
            this.Hide();
        }
    }
}
