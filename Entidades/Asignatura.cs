using System;
using System.Collections.Generic;
<<<<<<< HEAD
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Asignatura: ObjetoEscuelaBase
    {
        
=======

namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
>>>>>>> origin/master
    }
}