using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack.clases
{
    public class PartidaCl
    {
        public JugadorCl Jugador { get; private set; }
        public JugadorCl Croupier { get; private set; }
        public CartaCl Cartas { get; private set; }

        public PartidaCl()
        {
            Jugador = new JugadorCl();
            Croupier = new JugadorCl();
            Cartas = new CartaCl();
        }

        //public void IniciarPartida()
        //{
        //    Jugador.Reiniciar();
        //    Croupier.Reiniciar();
        //
        //   Jugador.AgregarCarta(Cartas.GenerarCarta());
        //   Jugador.AgregarCarta(Cartas.GenerarCarta());

        //    Croupier.AgregarCarta(Cartas.GenerarCarta());
        //    Croupier.AgregarCarta(Cartas.GenerarCarta());
        //}

        public string VerificarResultado()
        {
            if (Jugador.SePasoDe21())
                return "Perdiste. Te pasaste de 21. 😔";

            else if (Croupier.SePasoDe21())
                return "Ganaste. El croupier se pasó de 21. 🤩";

            else if (Jugador.TieneBlackjack())
                return "Ganaste. Tienes un Blackjack. 🤩";

            else if (Croupier.TieneBlackjack())
                return "Perdiste. El croupier tiene un Blackjack. 😔";

            else if (Jugador.Puntaje > Croupier.Puntaje)
                return "Ganaste. El croupier perdió por puntos. 🤩";

            else if (Jugador.Puntaje < Croupier.Puntaje)
                return "Perdiste. El croupier ganó por puntos. 😔";

            else
                return "Empate. 😐";
        }
    }
}
