using Blackjack.vistas;
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
        public string resultado;
        public JugadorCl Jugador { get; private set; }
        public JugadorCl Croupier { get; private set; }
        public CartaCl Cartas { get; private set; }

        public PartidaCl()
        {
            Partida partida = new Partida();

            Jugador = new JugadorCl();
            Croupier = new JugadorCl();
            Cartas = new CartaCl();
            resultado = partida.Ganador();
        }
    }
}
