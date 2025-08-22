using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.models
{
    public class BlocoEconomico
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Pais>? Paises { get; set; }
    }
}