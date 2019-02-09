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
           Printer.Beep();
           Printer.ImprimirInformacionEscuela(engine.Escuela);                     
        }
    }
}
