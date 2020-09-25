using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class Gasto
    {
        public int Id { get; set; }
        public int IdConcepto { get; set; }
        public string Nombre { get; set; }

        public virtual ConceptosGasto IdConceptoNavigation { get; set; }
    }
}
