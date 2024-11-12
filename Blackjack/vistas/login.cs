using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Blackjack.vistas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void btJugar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            menu menu1 = new menu(nombre);

            Saludo saludo = new Saludo(nombre);

            lblTitulo.Enabled = false;
            lblNombre.Enabled = false;
            txtNombre.Enabled = false;
            btJugar.Enabled = false;

            lblTitulo.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            btJugar.Visible = false;

            menu1.Visible = true;

            menu1.Show();

            this.Hide();
        }
    }
}
