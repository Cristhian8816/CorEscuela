using System;
using System.Collections.Generic;

namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public float Sumatoria { get; set; }
        public float Promedio { get; set; }        
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
    }
}