using blackjack.clases;
using Blackjack.vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.clases
{
    public class Tabla
    {
        public DataTable PuntajesDT { get; set; } = new DataTable();

        public PartidaCl partida;
        public JugadorCl Jugador;
        public JugadorCl Croupier;

        public Tabla()
        {
            PuntajesDT.TableName = "Historial de partidas";
            PuntajesDT.Columns.Add("Puntaje Jugador", typeof(int));
            PuntajesDT.Columns.Add("Puntaje Croupier", typeof(int));
            PuntajesDT.Columns.Add("Resultado");
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Historial.xml"))
            {
                PuntajesDT.ReadXml("Historial.xml");
            }
        }

        public void InsertPuntaje(PartidaCl partida)
        {
            int id = NuevoId();

            PuntajesDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = PuntajesDT.Rows.Count - 1;
            PuntajesDT.Rows[NuevoRenglon]["Id"] = id;
            PuntajesDT.Rows[NuevoRenglon]["Puntaje Jugador"] = Jugador.Puntaje;
            PuntajesDT.Rows[NuevoRenglon]["Puntaje Croupier"] = Croupier.Puntaje;
            PuntajesDT.Rows[NuevoRenglon]["Resultado"] = partida.resultado;

            PuntajesDT.WriteXml("Historial.xml");
        }

        private int NuevoId()
        {
            int NuevoId = 0;

            foreach (DataRow fila in PuntajesDT.Rows)
            {
                if (NuevoId < Convert.ToInt32(fila["Id"]))
                {
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }

            NuevoId++;
            return NuevoId;
        }
    }
}
