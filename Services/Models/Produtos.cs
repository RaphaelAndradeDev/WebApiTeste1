using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class Produtos : Entity
    {
        public string Nome { get; set; }
        public string ImageUrl { get; set; }

        // Relacionamento
        public Guid VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
