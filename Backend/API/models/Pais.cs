using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.models
{
    public class Pais
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Capital { get; set; }
        public int Populacao { get; set; }
        public Continente? Continente { get; set; }
        public ICollection<Idioma>? Idiomas { get; set; }
        public ICollection<BlocoEconomico>? BlocosEconomicos { get; set; }

    }
}