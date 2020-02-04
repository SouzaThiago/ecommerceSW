using EcommerceSW.Domain;
using System.Collections.Generic;

namespace EcommerceSW.Service.Contracts
{
    public interface IProdutoService
    {
        Produto ObterProduto(int id);

        bool InserirProduto(Produto produto);

        bool EditarProduto(Produto produto);
        
        bool ExcluirProduto(int id);

        IEnumerable<Produto> ListarTodosProdutos();

        Produto ObterProdutoPorNome(string nome);
    }
}
    