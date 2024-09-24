using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack.clases
{
    public class JugadorCl
    {
        public List<CartaCl> Cartas { get; set; }
        public int Puntaje { get; set; }

        public JugadorCl()
        {
            Cartas = new List<CartaCl>();
            Puntaje = 0;
        }

        public void AgregarCarta(CartaCl carta)
        {
            Cartas.Add(carta);
            Puntaje += carta.valorCarta();
        }

        public void Reiniciar()
        {
            Cartas.Clear();
            Puntaje = 0;
        }
    }
}
