using System;

namespace Kaelo.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string Marca { get; set; }

        public string Tamanho { get; set; }

        public decimal Valor { get; set; }

        public string Foto { get; set; }

        public string Descricao { get; set; }
    }
}
