using System;

namespace CorEscuela.Entidades
{
    public  class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString() 
        {
            return $"{Nombre}, {UniqueId}";
        }
    }
}