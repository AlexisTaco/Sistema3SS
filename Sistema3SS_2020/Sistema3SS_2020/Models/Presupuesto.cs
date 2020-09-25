using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Presupuesto
    {
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public double? TotalPresupuesto { get; set; }
    }
}
