using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack.clases
{
    public class PartidaCl
    {
        private Label lblResultado;

        public JugadorCl Jugador { get; private set; }
        public JugadorCl Croupier { get; private set; }
        public CartaCl Cartas { get; private set; }

        public PartidaCl(Label resultadoLabel)
        {
            Jugador = new JugadorCl();
            Croupier = new JugadorCl();
            Cartas = new CartaCl();
            lblResultado = resultadoLabel;
        }

        public void Ganador()
        {
            if (Croupier.Puntaje > 21 && Jugador.Puntaje <= 21)
            {
                lblResultado.Text = "Ganaste. El croupier se pasó de 21. 🥳";
            }
            if (Jugador.Puntaje > 21 && Croupier.Puntaje <= 21)
            {
                lblResultado.Text = "Perdiste. Te pasaste de 21. 😔";
            }
            if (Jugador.Puntaje == 21)
            {
                lblResultado.Text = "Ganaste. Obtuviste un Blackjack. 🥳";
            }
            if (Croupier.Puntaje == 21)
            {
                lblResultado.Text = "Perdiste. El croupier obtuvo un Blackjack. 😔";
            }
            if (Jugador.Puntaje > Croupier.Puntaje && Jugador.Puntaje <= 21)
            {
                lblResultado.Text = "Ganaste. El croupier perdió por puntos. 🥳";
            }
            if (Croupier.Puntaje > Jugador.Puntaje && Croupier.Puntaje <= 21)
            {
                lblResultado.Text = "Perdiste. El croupier te ganó por puntos. 😔";
            }
            if (Jugador.Puntaje = Croupier.Puntaje)
            {
                lblResultado.Text = "Es un empate. 😐";
            }
            if (Jugador.Puntaje > 21 && Croupier.Puntaje > 21)
            {
                lblResultado.Text = "Ambos se pasaron. 😐";
            }
        }
    }
}
