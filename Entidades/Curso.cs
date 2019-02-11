using System;
using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
<<<<<<< HEAD
    public class Curso: ObjetoEscuelaBase
    {      
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }       
=======
    public class Curso
    {
        public string UniqueId { get; private set; }//obtengo public pero seteo solo en la clase
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }           
        public Curso() => UniqueId = Guid.NewGuid().ToString();        
>>>>>>> origin/master
    }
}