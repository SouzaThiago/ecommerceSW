using EcommerceSW.Domain;
using EcommerceSW.Service.Contracts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSW.Service
{
    public class CarrinhoService : ICarrinhoService
    {
        private readonly IProdutoRepository repository;
        private readonly ICarrinhoRepository carrinhoRepository;

        public CarrinhoService(IProdutoRepository repository, ICarrinhoRepository carrinhoRepository)
        {
            this.repository = repository;
            this.carrinhoRepository = carrinhoRepository;
        }
        public List<SelectListItem> ListarProdutos()
        {
            var produtos = repository.ListarTodosProdutos();
            List<SelectListItem> listaProdutos = new List<SelectListItem>() { new SelectListItem() { Text = null, Value = null } };

            if (produtos.Count() > 0)
            {
                foreach (var produto in produtos)
                {
                    SelectListItem item = new SelectListItem()
                    {
                        Text = produto.Nome,
                        Value = produto.Id.ToString(),
                    };

                    listaProdutos.Add(item);
                }
            }
            else
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = "Sem produtos cadastrados",
                    Value = string.Empty,
                };

                listaProdutos.Add(item);
            }

            return listaProdutos;
        }

        public void InserirProdutoNoCarrinho(Carrinho produto)
        {
            carrinhoRepository.InserirProdutoNoCarrinho(produto);
        }

        public IEnumerable<Carrinho> ListarTodosProdutosCarrinho()
        {
            return carrinhoRepository.ListarTodosProdutosNoCarrinho();
        }

        public bool ExcluirProdutoDoCarrinho(int id)
        {
            return carrinhoRepository.ExcluirProdutoDoCarrinho(id);
        }

        public Carrinho ObterProdutoNoCarrinho(string nomeProduto)
        {
            return carrinhoRepository.ObterProdutoNoCarrinho(nomeProduto);
        }

        public IEnumerable<Carrinho> ValidarPromocoes(IEnumerable<Carrinho> produtosNoCarrinho)
        {
            foreach (var produto in produtosNoCarrinho)
            {
                if (produto.PromocaoProduto == TipoPromocao.tresPorDezReais)
                {
                    if (produto.QuantidadeProduto % 3 == 0)
                    {
                        int novaQuantidade = produto.QuantidadeProduto / 3;
                        produto.PrecoUnitario = 10.00m;
                        produto.ValorTotal = novaQuantidade * produto.PrecoUnitario;
                    }
                    else
                    {
                        int novaQuantidate = produto.QuantidadeProduto / 3;
                        int resto = produto.QuantidadeProduto % 3;
                        decimal precoComPromocao = novaQuantidate * 10.00m;
                        decimal precoSemPromocao = resto * produto.PrecoUnitario;
                        produto.ValorTotal = precoComPromocao + precoSemPromocao;
                    }
                }
                else if (produto.PromocaoProduto == TipoPromocao.pagueUmLeveDois && produto.QuantidadeProduto % 2 == 0)
                {
                    produto.ValorTotal = produto.PrecoUnitario * (produto.QuantidadeProduto / 2);
                }
                else
                {
                    produto.ValorTotal = produto.QuantidadeProduto * produto.PrecoUnitario;
                    produto.PromocaoProduto = string.Empty;
                }
            }
            return produtosNoCarrinho;
        }
    }
}
