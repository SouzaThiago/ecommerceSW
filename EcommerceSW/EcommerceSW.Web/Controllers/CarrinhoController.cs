using System;
using System.Collections.Generic;
using System.Threading;
using AutoMapper;
using EcommerceSW.Domain;
using EcommerceSW.Service.Contracts;
using EcommerceSW.Web.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EcommerceSW.Web.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ICarrinhoService carrinhoService;
        private readonly IProdutoService produtoService;
        private readonly ILogger<CarrinhoController> log;
        private IMapper mapper;

        public CarrinhoController(ICarrinhoService carrinhoService, IProdutoService produtoService, IMapper mapper, ILogger<CarrinhoController> log)
        {
            this.carrinhoService = carrinhoService;
            this.produtoService = produtoService;
            this.mapper = mapper;
            this.log = log;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View(SelecionarTodos());
        }

        public ActionResult Create()
        {
            ViewData["ListaProdutos"] = carrinhoService.ListarProdutos();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, IFormCollection collection)
        {
            try
            {
                var NomeProduto = collection["Nome"];
                var prod = produtoService.ObterProduto(Convert.ToInt32(NomeProduto));

                var quantidade = collection["Quantidade"];
                var valorTotal = prod.Preco * Convert.ToInt32(quantidade);

                Carrinho produto = new Carrinho()
                {
                    NomeProduto = prod.Nome,
                    PrecoUnitario = prod.Preco,
                    PromocaoProduto = prod.Promocao,
                    QuantidadeProduto = Convert.ToInt32(quantidade),
                    ValorTotal = valorTotal,
                };

                var produtoNoCarrinho = carrinhoService.ObterProdutoNoCarrinho(prod.Nome);

                if (produtoNoCarrinho != null)
                {
                    carrinhoService.ExcluirProdutoDoCarrinho(produtoNoCarrinho.Id);
                }

                carrinhoService.InserirProdutoNoCarrinho(produto);

                Thread.Sleep(2000);
                return RedirectToAction(nameof(Create));
            }
            catch (Exception ex)
            {
                log.LogError($"Erro ao inserir produto no carrinho: {ex}");
                return RedirectToAction(nameof(Create));
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var produto = collection["Nome"];
                var prod = produtoService.ObterProduto(Convert.ToInt32(produto));
                var quantidade = collection["Quantidade"];
                var valorTotal = prod.Preco * Convert.ToInt32(quantidade);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                log.LogError($"Erro ao editar produto no carrinho: {ex}");
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            carrinhoService.ExcluirProdutoDoCarrinho(id);
            return RedirectToAction(nameof(Details));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                carrinhoService.ExcluirProdutoDoCarrinho(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                log.LogError($"Erro ao deletar produto no carrinho: {ex}");
                return View();
            }
        }

        public IEnumerable<CarrinhoViewModel> SelecionarTodos()
        {
            var produtosNoCarrinho = this.carrinhoService.ListarTodosProdutosCarrinho();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Carrinho, CarrinhoViewModel>();
            });

            var produtosValidados = carrinhoService.ValidarPromocoes(produtosNoCarrinho);

            mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<Carrinho>, List<CarrinhoViewModel>>(produtosValidados);
        }
    }
}