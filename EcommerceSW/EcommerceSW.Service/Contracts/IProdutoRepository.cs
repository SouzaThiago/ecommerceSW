using EcommerceSW.Domain;
using System.Collections.Generic;

namespace EcommerceSW.Service.Contracts
{
    public interface IProdutoRepository
    {
        bool InserirProduto(Produto produto);

        bool EditarProduto(Produto produto);

        bool ExcluirProduto(int id);

        Produto ObterProduto(int id);

        IEnumerable<Produto> ListarTodosProdutos();

        Produto ObterProdutoPorNome(string nome);
    }
}
