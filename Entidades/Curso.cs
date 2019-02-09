using System;
using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }//obtengo public pero seteo solo en la clase
        public string Nombre { get; set; }

        string mejorAlumno;
        public string MejorAlumno 
         {
            get { return mejorAlumno; }
            set { mejorAlumno = value.ToUpper(); }
        }           
        public TiposJornada Jornada { get; set; }
        public float MejorPromedio { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }           
        public Curso() => UniqueId = Guid.NewGuid().ToString();        
    }
}