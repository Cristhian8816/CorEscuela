using System;
using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase

    {     
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
               
    }
}