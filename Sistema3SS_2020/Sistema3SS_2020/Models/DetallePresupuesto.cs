using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class DetallePresupuesto
    {
        public int Id { get; set; }
        public int? IdPresupuesto { get; set; }
        public int? IdConcepcion { get; set; }
        public int? IdGranja { get; set; }
        public string Estanques { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdGasto { get; set; }
    }
}
