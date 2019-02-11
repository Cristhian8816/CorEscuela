using System;
using System.Collections.Generic;
using CorEscuela.Entidades;

namespace CorEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase
    {     
        public int añoCreacion {get; set;}
        public string pais { get; set; }
        public string ciudad {get; set;}
        public TiposEscuela TipoEscuela{ get; set;}
        public List<Curso> Cursos { get; set; }      

        public Escuela(string nombre, int año) => (Nombre, añoCreacion) = (nombre,año);

        public Escuela(string nombre, int año, TiposEscuela tipos, string pais="", string ciudad="")
        {
         (Nombre, añoCreacion) = (nombre,año);//asignacion de tuplas
         this.pais = pais;
         this.ciudad = ciudad;

        }

        //Para escribir y mostrar el console
        public override string ToString()
        {
           return $"Nombre: \"{Nombre}\", tipo: {TipoEscuela} {System.Environment.NewLine} pais: {pais}, Ciudad: {ciudad}";
        }
    }
}