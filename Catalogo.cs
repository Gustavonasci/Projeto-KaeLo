using System.Collections.Generic;

namespace Kaelo.Models
{
    public class Catalogo : ErrorViewModel
    {
        public int IdCatalogo { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
