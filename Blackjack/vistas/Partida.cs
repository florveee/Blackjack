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
        private PartidaCl partida;

        private CartaCl cartaJ1;
        private CartaCl cartaJ2;
        private CartaCl cartaC1;
        private CartaCl cartaC2;
        private CartaCl cartaJrand;
        private CartaCl cartaCrand;

        private JugadorCl Jugador;
        private JugadorCl Croupier;
        private string nombre;

        public Partida()
        {
            InitializeComponent();

            partida = new PartidaCl(lblResultado);

            cartaJ1 = new CartaCl();
            cartaJ2 = new CartaCl();
            cartaC1 = new CartaCl();
            cartaC2 = new CartaCl();
            cartaJrand = new CartaCl();
            cartaCrand = new CartaCl();

            Jugador = new JugadorCl();
            Croupier = new JugadorCl();

            Jugador.Reiniciar();
            Croupier.Reiniciar();

            Jugador.AgregarCarta(cartaJ1);
            Jugador.AgregarCarta(cartaJ2);
            Croupier.AgregarCarta(cartaC1);
            Croupier.AgregarCarta(cartaC2);

            EsconderTirada();

            PrimerTirada();
        }
        private async void EsconderTirada()
        {
            lblSeguir.Visible = false;
            btSeguir.Visible = false;
            btIrse.Visible = false;
            lbltucarta.Visible = false;
            lblcartacr.Visible = false;
            panelJ1.Visible = false;
            panelJ2.Visible = false;
            panelC1.Visible = false;
            panelC2.Visible = false;
            panelCran.Visible = false;
            panelJran.Visible = false;
            lblotracarta.Visible = false;
            BtOtraC.Visible = false;
            BtPlantarse.Visible = false;

            await Task.Delay(2000);

            lblTirada.Visible = false;
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

            await Task.Delay(1000);

            panelJ2.Visible = true;

            await Task.Delay(1000);

            lblcartacr.Visible = true;

            lblvalorC1.Text = cartaC1.Valor;
            lblvalC1.Text = cartaC1.Valor;
            paloC1.Text = cartaC1.Palo;

            await Task.Delay(1000);

            panelC1.Visible = true;

            await Task.Delay(1000);

            lblvalorC2.Text = cartaC2.Valor;
            lblvalC2.Text = cartaC2.Valor;
            paloC2.Text = cartaC2.Palo;

            panelC2.Visible = true;

            await Task.Delay(1000);

            lblPuntJug.Text = "Tu puntaje es: " + Jugador.Puntaje.ToString();
            lblPuntJug.Visible = true;

            lblPuntCr.Text = "El puntaje del croupier es: " + Croupier.Puntaje.ToString();
            lblPuntCr.Visible = true;

            await Task.Delay(2000);

            MostrarBt();
        }

        private void MostrarBt()
        {
            panelJ1.Visible = false;
            panelJ2.Visible = false;
            panelCran.Visible = false;
            lblotracarta.Visible = true;
            BtOtraC.Visible = true;
            BtPlantarse.Visible = true;
        }
        private void BtOtraC_Click(object sender, EventArgs e)
        {
            OtraCarta();
        }
        private async void OtraCarta()
        {

            cartaJrand = new CartaCl();
            Jugador.AgregarCarta(cartaJrand);


            lblvalorJran.Text = cartaJrand.Valor;
            lblvalJran.Text = cartaJrand.Valor;
            paloJrand.Text = cartaJrand.Palo;

            await Task.Delay(1000);

            panelJran.Visible = true;

            lblPuntJug.Text = "Tu puntaje es: " + Jugador.Puntaje.ToString();
            lblPuntJug.Visible = true;

            if (Jugador.Puntaje >= 21)
            {
                BtOtraC.Enabled = false;
                BtPlantarse.Enabled = false;
                TiradaCroupier();
            }
        }
        private async void TiradaCroupier()
        {
            while (Croupier.Puntaje < 17)
            {
                await Task.Delay(1000);
                cartaCrand = new CartaCl();
                Croupier.AgregarCarta(cartaCrand);

                panelC1.Visible = false;
                panelC2.Visible = false;

                lblvalorCran.Text = cartaCrand.Valor;
                lblvalCran.Text = cartaCrand.Valor;
                paloCrand.Text = cartaCrand.Palo;

                await Task.Delay(1500);

                panelCran.Visible = true;
                lblPuntCr.Text = "El puntaje del croupier es: " + Croupier.Puntaje.ToString();
            }

            Ganador();
            lblotracarta.Visible = false;
            BtOtraC.Visible = false;
            BtPlantarse.Visible = false;
            lblResultado.Visible = true;

            await Task.Delay(2000);
            SeguirJugando();
        }
        private void BtPlantarse_Click(object sender, EventArgs e)
        {
            BtOtraC.Enabled = false;
            BtPlantarse.Enabled = false;
            TiradaCroupier();
        }

        private void SeguirJugando()
        {
            panelJ1.Visible = false;
            panelJ2.Visible = false;
            lblotracarta.Visible = false;
            BtOtraC.Visible = false;
            BtPlantarse.Visible = false;
            lblSeguir.Visible = true;
            btSeguir.Visible = true;
            btIrse.Visible = true;
        }

        private void btSeguir_Click(object sender, EventArgs e)
        {
            login login = new login();

            login.Show();

            this.Hide();
        }

        private void btIrse_Click(object sender, EventArgs e)
        {
            Saludo fSaludo = new Saludo();

            this.Close();
            fSaludo.Show();
        }
        public void Ganador()
        {
            lblResultado.Visible = true;
            if (Croupier.Puntaje > 21 && Jugador.Puntaje < 21)
            {
                lblResultado.Text = "Ganaste. El croupier se pasó de 21. 🥳";
            }
            else if (Jugador.Puntaje > 21 && Croupier.Puntaje < 21)
            {
                lblResultado.Text = "Perdiste. Te pasaste de 21. 😔";
            }
            else if (Jugador.Puntaje == 21)
            {
                lblResultado.Text = "Ganaste. Obtuviste un Blackjack. 🥳";
            }
            else if (Croupier.Puntaje == 21)
            {
                lblResultado.Text = "Perdiste. El croupier obtuvo un Blackjack. 😔";
            }
            else if (Jugador.Puntaje > Croupier.Puntaje && Jugador.Puntaje <= 21)
            {
                lblResultado.Text = "Ganaste. El croupier perdió por puntos. 🥳";
            }
            else if (Croupier.Puntaje > Jugador.Puntaje && Croupier.Puntaje <= 21)
            {
                lblResultado.Text = "Perdiste. El croupier te ganó por puntos. 😔";
            }
            else if (Jugador.Puntaje == Croupier.Puntaje)
            {
                lblResultado.Text = "Es un empate. 😐";
            }
            else if (Jugador.Puntaje > 21 && Croupier.Puntaje > 21)
            {
                lblResultado.Text = "Ambos se pasaron. 😐";
            }
        }
    }
}
