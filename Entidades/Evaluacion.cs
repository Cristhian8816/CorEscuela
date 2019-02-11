using System;
using System.Collections.Generic;
<<<<<<< HEAD
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Evaluacion: ObjetoEscuelaBase
    {       
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; } 
               
=======

namespace CorEscuela.Entidades
{
    public class Evaluacion
    {
        public string UniqueId { get; private set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
        public string Nombre { get; set; }

        public Evaluacion() => UniqueId = Guid.NewGuid().ToString();
        
>>>>>>> origin/master
        public override string  ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}