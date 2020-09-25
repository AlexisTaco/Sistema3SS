using System;
using System.Collections.Generic;

#nullable disable

namespace Sistema3SS_2020.Models
{
    public partial class ConceptosGasto
    {
        public ConceptosGasto()
        {
            Gastos = new HashSet<Gasto>();
        }

        public int Id { get; set; }
        public string Contenido { get; set; }

        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
