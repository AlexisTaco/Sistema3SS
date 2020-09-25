using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class DetalleGranja
    {
        public int Id { get; set; }
        public int IdDetalleProyecto { get; set; }
        public int IdGranja { get; set; }
        public int? NumeroEstanque { get; set; }

        public virtual Granja IdGranjaNavigation { get; set; }
    }
}
