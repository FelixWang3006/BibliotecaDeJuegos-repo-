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
    public partial class Perfil_Gamer : Form
    {
        public Perfil_Gamer()
        {
            InitializeComponent();
        }

        private void btBibliotecaEnPerfilGamer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btAgregarJuegoEnPerfilGamer_Click(object sender, EventArgs e)
        {
            Agregar_juego agregar_juego = new Agregar_juego();
            agregar_juego.Show();
            this.Hide();
        }
    }
}
