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

        public Produto ObterProdutoPorId(int id)
        {
            return _myWebAppContex.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Salvar(Produto produto)
        {
            _myWebAppContex.Produtos.Add(produto);
            _myWebAppContex.SaveChanges();
        }
    }
}
