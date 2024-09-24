using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.vistas
{
    public partial class menu : Form
    {
        private string nombre;

        public menu(string nombre)
        {
            InitializeComponent();

            this.nombre = nombre;

            lblSaludo.Text = "Bienvenid@ " + nombre + "!!";

            lblSaludo.Enabled = true;
            lblSaludo.Visible = true;

            lblChau.Enabled = false;
            lblChau.Visible = false;
        }

        private void btSi_Click_1(object sender, EventArgs e)
        {
            Partida partida = new Partida();

            partida.Show();

            this.Hide();
        }

        private async void btNo_Click_1(object sender, EventArgs e)
        {
            lblSaludo.Visible = false;
            lblPreg.Enabled = false;
            lblPreg.Visible = false;
            btSi.Enabled = false;
            btSi.Visible = false;
            btNo.Enabled = false;
            btNo.Visible = false;

            lblChau.Text = "Gracias por jugar con nosotros, " + nombre + "!!";
            lblChau.Visible = true;

            await Task.Delay(2000);

            Application.Exit();
        }
    }
}
