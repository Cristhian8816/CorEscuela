using System;
using System.Collections.Generic;
using CorEscuela.Entidades;
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

        public static void ImprimirInformacionEscuela(Escuela escuela)
        {
           Printer.writeTitle("Cursos de la Escuela");

           if (escuela?.Cursos != null) // Para asegurarnos que ni escuela ni cursos es NULL
            {
                var lista = new List<Evaluacion>();
                foreach (var curso in escuela.Cursos)
                {
                    curso.MejorPromedio = 0;
                    Printer.DibujarLinea(200);
                    WriteLine($"Curso: {curso.Nombre}");
                    Printer.DibujarLinea(200);
                    foreach (var alumno in curso.Alumnos)
                    {
                        Printer.DibujarLinea(100);
                        WriteLine($"Alumno: {alumno.Nombre}");
                        Printer.DibujarLinea(100);
                        foreach (var asignatura in curso.Asignaturas)
                        {                            
                            WriteLine($"                                   Asignatura: {asignatura.Nombre}");                            
                            var rnd = new Random();

                            for (int i = 0; i < 5; i++)
                            {
                                var evaluacion = new Evaluacion
                                {
                                    Asignatura = asignatura,
                                    Nombre = $"{asignatura.Nombre} Parcial#{i + 1}",
                                    Nota = (float)(5 * rnd.NextDouble()),
                                    Alumno = alumno                                    
                                };                                
                                WriteLine($"                                   Evaluacion#{i + 1}, Calificacion: "+"{0:N2}", evaluacion.Nota);                              
                                asignatura.Sumatoria += evaluacion.Nota;                                                                                                                          
                            } 
                            asignatura.Promedio= asignatura.Sumatoria/5;
                            alumno.Sumatoria += asignatura.Promedio; 
                            WriteLine("                                                      Promedio:{0:N2}", asignatura.Promedio);                            
                            if (asignatura.Promedio > 3.0)
                            {
                                WriteLine($"                                   Asignatura APROVADA");
                                WriteLine($"                                  =====================");               
                            }   
                            else{
                                WriteLine($"                                   Asignatura REPROVADA");
                                WriteLine($"                                  =======================");
                            }
                            asignatura.Sumatoria = 0; 
                            asignatura.Promedio = 0;                                                                                                  
                        }
                        alumno.Promedio = alumno.Sumatoria/4;                                               
                        if(curso.MejorPromedio < alumno.Promedio)
                        {
                            curso.MejorPromedio = alumno.Promedio;
                            curso.MejorAlumno = alumno.Nombre;
                        }
                        WriteLine("                                   Promedio General del Alumno:{0:N2}", alumno.Promedio);  
                        alumno.Sumatoria = 0;
                        alumno.Promedio = 0;                     
                    } 
                    WriteLine("");
                    WriteLine($"El mejor promedio del curso: {curso.Nombre} es {curso.MejorAlumno}:"+" con un promedio de {0:N2} :" , curso.MejorPromedio);
                    WriteLine("");
                }
            }
        }
    }
}
