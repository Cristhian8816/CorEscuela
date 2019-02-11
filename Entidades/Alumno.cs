using System;
using System.Collections.Generic;
<<<<<<< HEAD
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase

    {     
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
               
=======

namespace CorEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno() => UniqueId = Guid.NewGuid().ToString();        
>>>>>>> origin/master
    }
}