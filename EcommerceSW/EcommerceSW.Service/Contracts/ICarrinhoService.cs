using EcommerceSW.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EcommerceSW.Service.Contracts
{
    public interface ICarrinhoService
    {
        List<SelectListItem> ListarProdutos();

        void InserirProdutoNoCarrinho(Carrinho produto);

        bool ExcluirProdutoDoCarrinho(int id);

        Carrinho ObterProdutoNoCarrinho(string nomeProduto);

        IEnumerable<Carrinho> ValidarPromocoes(IEnumerable<Carrinho> produtosNoCarrinho);

        IEnumerable<Carrinho> ListarTodosProdutosCarrinho();
    }
}
