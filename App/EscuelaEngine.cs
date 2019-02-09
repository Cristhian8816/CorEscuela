using System;
using System.Collections.Generic;
using System.Linq; //soporta querys dentro del desarrollo de este algoritmo
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class EscuelaEngine
    {        
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
            
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");
            CargarCurso();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            var lista = new List<Evaluacion>();
            foreach (var curso in Escuela.Cursos)
            {                
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);

                        for (int i = 0; i < 5; i++)
                        {
                            var evaluacion = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} evaluacion#{i+1}",
                                Nota = (float)(5* rnd.NextDouble()),
                                Alumno = alumno                                
                            };                            
                            lista.Add(evaluacion);
                        }                                                 
                    }
                }
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura {Nombre = "Matematicas"},
                    new Asignatura {Nombre = "Educacion Fisica"},
                    new Asignatura {Nombre = "Castellano"},
                    new Asignatura {Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;                             
            }
        }
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = {"Cristhian","Andres","Carlos","Fabio","Javier"};
            string[] Apellido1 = {"Lizcano","Ortiz","Silva","Prada"};
            string[] nombre2 = {"Julian","Juan","Jose"};

            var listaAlumnos =  from n1 in nombre1 //Esto es un producto cartesiano de los tres arreglos arriba creados
                                from n2 in nombre2
                                from a1 in Apellido1
                                select new Alumno{ Nombre = $"{n1} {n2} {a1}"};
            
            return listaAlumnos.OrderBy( (al) => al.UniqueId ).Take(cantidad).ToList();            
        }
        private void CargarCurso()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde}
            };
            Random rnd = new Random();
            
            foreach(var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 5);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }
}
 