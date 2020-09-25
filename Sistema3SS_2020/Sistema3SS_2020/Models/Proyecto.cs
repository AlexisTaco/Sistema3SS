using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Proyecto
    {
        public int Id { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
