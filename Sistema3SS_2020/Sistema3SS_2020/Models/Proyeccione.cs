using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Proyeccione
    {
        public int Id { get; set; }
        public int IdPresupuesto { get; set; }
        public DateTime? FinalSemana { get; set; }
        public DateTime? IncioSemana { get; set; }
        public double? GastoEstimado { get; set; }
        public int? IdSemana { get; set; }
    }
}
