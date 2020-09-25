using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int IdTipo { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }
        public string NumeroCelular { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaNecimineto { get; set; }
        public bool? Activo { get; set; }

        public virtual TiposUsuario IdTipoNavigation { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
