using Kaelo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Kaelo.DAL
{
    public static class ProdutoRepository
    {
        static ProdutoRepository()
        {
            using (var context = new ProdutoContext())
            {
                AdicionarProduto(context, "Oakley", "G", 1, 25, "http://mlb-s2-p.mlstatic.com/vestidos-femininos-curto-festa-peplum-panicat-rodado-vero-462011-MLB20456355022_102015-F.jpg");
                AdicionarProduto(context, "Adidas", "M", 2, 32, "https://http2.mlstatic.com/vestidos-femininos-curtos-D_NQ_NP_574305-MLB25014083154_082016-F.jpg");
                AdicionarProduto(context, "Nike", "P", 3, 55, "https://popdress.com.br/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/0/6/0698_u_19067.jpg");

                context.SaveChanges();
            }
        }

        private static void AdicionarProduto(ProdutoContext context, string marca, string tamanho, int IdProduto, decimal valor, string foto)
        {
            context.Produtos.Add(new Produto()
            {
                Marca = marca,
                Tamanho = tamanho,
                IdProduto = IdProduto,
                Valor = valor,
                Foto = foto
            });
        }

        public static List<Produto> ListarProdutos()
        {
            using var context = new ProdutoContext();
            return context.Produtos.OrderBy(x => x.Marca).ToList();
        }

        public static void ExcluirPrimeiroLivro()
        {
            using (var context = new ProdutoContext())
            {
                context.Produtos.Remove(context.Produtos.FirstOrDefault());
                context.SaveChanges();
            }
        }
    }
}
