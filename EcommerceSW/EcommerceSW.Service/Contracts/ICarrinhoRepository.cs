using EcommerceSW.Domain;
using System.Collections.Generic;

namespace EcommerceSW.Service.Contracts
{
    public interface ICarrinhoRepository
    {
        bool InserirProdutoNoCarrinho(Carrinho produto);

        bool ExcluirProdutoDoCarrinho(int id);

        IEnumerable<Carrinho> ListarTodosProdutosNoCarrinho();

        Carrinho ObterProdutoNoCarrinho(string nomeProduto);
    }
}
