using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Granja
    {
        public Granja()
        {
            DetalleGranjas = new HashSet<DetalleGranja>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string NombreResponsable { get; set; }
        public string ApellidoPaternoResponsable { get; set; }
        public string ApellidoMaternoResponsable { get; set; }
        public int? NumeroEstanques { get; set; }
        public double? PerimetroHectareas { get; set; }

        public virtual ICollection<DetalleGranja> DetalleGranjas { get; set; }
    }
}
