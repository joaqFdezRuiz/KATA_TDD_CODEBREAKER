namespace CodeBreaker.Clases
{
    public class CadenaUsuario : CodeBreaker.Clases.ICadenaUsuario
    {
        public string ObtenerCadenaUsuario(string cadena) {
            return cadena.ToUpper();
        }
    }
}
