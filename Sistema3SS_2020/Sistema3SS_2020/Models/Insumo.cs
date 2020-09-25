using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Insumo
    {
        public int Id { get; set; }
        public int? IdTipo { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }
        public double? Cantidad { get; set; }

        public virtual TiposInsumo IdTipoNavigation { get; set; }
    }
}
