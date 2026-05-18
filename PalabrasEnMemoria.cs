namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly List<string> _palabras;
        
            public PalabrasEnMemoria(string categoria)
        {
            if (categoria == "1")
            {
                _palabras = new List<string> { "arquitectura", "componente", "descomposición", "dependencia", "acoplamiento" };
            }
            else if (categoria == "2")
            {
                _palabras = new List<string> { "polimorfismo", "encapsulamiento", "herencia", "abstracción", "clase" };
            }
            else
            {
                _palabras = new List<string> { "ensamblado", "namespace", "interfaz", "delegado", "middleware" };
            }
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();
            return _palabras[random.Next(_palabras.Count)];
        }
    }
}