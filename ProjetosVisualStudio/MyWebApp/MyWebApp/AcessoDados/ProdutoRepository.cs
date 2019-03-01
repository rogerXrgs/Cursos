using MyWebApp.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.AcessoDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContex _myWebAppContex;

        public ProdutoRepository(MyWebAppContex myWebAppContex)
        {
            _myWebAppContex = myWebAppContex;
        }

        public List<Produto> ListarProdutos()
        {
            return _myWebAppContex.Produtos.ToList();
        }
    }
}
