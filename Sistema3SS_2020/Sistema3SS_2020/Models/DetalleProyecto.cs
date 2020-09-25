using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class DetalleProyecto
    {
        public int Id { get; set; }
        public int IdProyecto { get; set; }
        public int IdTemporada { get; set; }
    }
}
