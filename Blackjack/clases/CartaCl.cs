using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack.clases
{
    public class CartaCl
    {
        public string Valor { get; set; }
        public string Palo { get; set; }

        private static Random rand = new Random();
        private string[] palos = { "♠", "💎", "❤", "🔶" };

        public int valorCarta()
        {
            return int.Parse(Valor);
        }

        public CartaCl()
        {
            GenerarPalo();
            GenerarValor();
        }

        public void GenerarPalo()
        {
            Palo = palos[rand.Next(0, palos.Length)];
        }
        public void GenerarValor()
        {
            Valor = rand.Next(1, 11).ToString();
        }
    }
}
