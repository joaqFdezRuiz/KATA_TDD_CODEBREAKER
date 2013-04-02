using System;

namespace CodeBreaker.Clases
{
    public class ClaveMaligno : CodeBreaker.Clases.IClaveMaligno
    {
        public static string[] CARACTERES_VALIDOS = new string[] { "R", "A", "M", "V", "I", "N" };
        public static int LONGITUD_CODIGO = 4;
        
        public string GenerarClave()
        {
            string clave = string.Empty;
            Random random = new Random();
            for (int i = 0; i < LONGITUD_CODIGO; i++) 
                clave = String.Concat(clave, CARACTERES_VALIDOS[random.Next(LONGITUD_CODIGO)]);
            return clave;
        }
    }
}
