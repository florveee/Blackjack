using blackjack.clases;
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
    public partial class Partida : Form
    {
        PartidaCl partida = new PartidaCl();

        private CartaCl cartaJ1;
        private CartaCl cartaJ2;
        private CartaCl cartaC1;
        private CartaCl cartaC2;

        public Partida()
        {
            InitializeComponent();
            cartaJ1 = new CartaCl();
            cartaJ2 = new CartaCl();
            cartaC1 = new CartaCl();
            cartaC2 = new CartaCl();

            EsconderTirada();

            PrimerTirada();

            Esperar();

        }
        private async void EsconderTirada()
        {
            lbltucarta.Visible = false;
            lblcartacr.Visible = false;
            panelJ1.Visible = false;
            panelJ2.Visible = false;
            panelC1.Visible = false;
            panelC2.Visible = false;

            await Task.Delay(2000);

            lblTirada.Visible = false;
        }

        private async void Esperar()
        {
            await Task.Delay(2000);
        }

        private async void PrimerTirada()
        {
            lblvalorj1.Text = cartaJ1.Valor;
            lblvalor1.Text = cartaJ1.Valor;
            paloj1.Text = cartaJ1.Palo;

            await Task.Delay(2000);

            panelJ1.Visible = true;
            lbltucarta.Visible = true;

            lblvalorj2.Text = cartaJ2.Valor;
            lblvalor2.Text = cartaJ2.Valor;
            paloj2.Text = cartaJ2.Palo;

            await Task.Delay(2000);

            panelJ2.Visible = true;

            await Task.Delay(2000);

            lblcartacr.Visible = true;

            lblvalorC1.Text = cartaC1.Valor;
            lblvalC1.Text = cartaC1.Valor;
            paloC1.Text = cartaC1.Palo;

            await Task.Delay(2000);

            panelC1.Visible = true;
            //lbltucarta.Visible = true;

            lblvalorC2.Text = cartaC2.Valor;
            lblvalC2.Text = cartaC2.Valor;
            paloC2.Text = cartaC2.Palo;

            await Task.Delay(2000);

            panelC2.Visible = true;
        }
    }
}
