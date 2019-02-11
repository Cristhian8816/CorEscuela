using System; 
using System.Collections.Generic;//es para el uso de Colecciones 
using CorEscuela.Entidades; //Para agregar los archivos contenidos en la carpeta "Entidades"
using CorEscuela.Util;//para el uso de "Printer" que se encuentra en la carpeta "Util"
using static System.Console; //para no escribir mas Console.write sino directamente write....

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar(); 
            Printer.writeTitle("Bienvenidos a la Escuela");
            Printer.Beep();
            ImprimirCursosEscuela(engine.Escuela);
            var listaObjetos = engine.GetObjetosEscuela();              
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
           Printer.writeTitle("Cursos de la Escuela");

           if (escuela?.Cursos != null) // Para asegurarnos que ni escuela ni cursos es NULL
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, ID: {curso.UniqueId}");
                }
            }
        }
    }
}
