using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class Vendedor : Entity
    {
        public string Nome { get; set; }

        // Relacionamento
        public IEnumerable<Produtos> Produtos { get; set; }
    }
}
