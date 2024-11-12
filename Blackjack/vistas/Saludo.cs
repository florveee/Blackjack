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
    public partial class Saludo : Form
    {
        private string nombre;

        public Saludo()
        {
            InitializeComponent();

            lblChau.Text = "Gracias por jugar con nosotros " + nombre + "!!";

            Cerrar();
        }

        public Saludo(string nombre)
        {
            this.nombre = nombre;
        }

        private async void Cerrar()
        {
            await Task.Delay(3000);
            Application.Exit();
        }
    }
}
