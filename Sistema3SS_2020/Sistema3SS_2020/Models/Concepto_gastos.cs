using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema3SS_2020.Models
{
    public class Concepto_gastos
    {
        public int id { get; set; }
        public string  ConceptoDes { get; set; }
       public List<Gastos> gastos { get; set; }
    }
}
