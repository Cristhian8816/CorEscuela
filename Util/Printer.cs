using static System.Console; //para no escribir mas Console.write sino directamente write....

namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadRight(tam,'=');
            WriteLine(linea);
        }
        public static void writeTitle(string titulo)
        {
            var tamaño = titulo.Length + 8;
            DibujarLinea(tamaño);
            WriteLine($"|   {titulo}   |");
            DibujarLinea(tamaño);
        }

        public static void Beep(int Hz = 1000, int tiempo = 500, int cantidad = 3)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(Hz, tiempo);                            
            }
        }
    }
}
