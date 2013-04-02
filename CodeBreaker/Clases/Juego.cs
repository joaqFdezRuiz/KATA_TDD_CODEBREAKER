using System.Linq;
using System.Collections.Generic;

namespace CodeBreaker.Clases
{
    public class Juego : CodeBreaker.Clases.IJuego
    {
        public static char POSICION_INEXACTA = '*';
        public static char POSICION_EXACTA = 'X';

        public enum Argumentos { EXACTA, INEXACTA }

        private string clave { get; set; }
        private string cadena { get; set; }

        public Juego(string clave, string cadena)
        {
            this.clave = clave;
            this.cadena = cadena;
        }

        public string ObtenerResultado()
        {
            List<char> copiaCadena = cadena.Select(x => x).ToList<char>();
            List<char> copiaClave = clave.Select(x => x).ToList<char>();

            BusquedaExactaInexacta(copiaCadena, copiaClave, Argumentos.EXACTA);
            BusquedaExactaInexacta(copiaCadena, copiaClave, Argumentos.INEXACTA);

            return 
                string.Join("", copiaClave.Select(x => x).Where(x => x == POSICION_EXACTA).ToList<char>()) +
                string.Join("", copiaClave.Select(x => x).Where(x => x == POSICION_INEXACTA).ToList<char>());
        }

        private static void BusquedaExactaInexacta(List<char> copiaCadena, List<char> copiaClave, Argumentos arg) {
            for (int i = 0; i < Clases.ClaveMaligno.LONGITUD_CODIGO; i++)
            {
                switch (arg)
                {
                    case Argumentos.EXACTA:
                        if (copiaClave[i].Equals(copiaCadena[i]))
                            copiaClave[i] = POSICION_EXACTA;
                        break;
                    case Argumentos.INEXACTA:
                        if (copiaCadena.Contains(copiaClave[i]))
                            copiaClave[i] = POSICION_INEXACTA;
                        break;
                }
            }
        }
    }
}
