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
    public class ProdutoController : Controller
    {
        private readonly IProdutoService produtoService;
        private readonly IPromocaoService promocaoService;
        private readonly ICarrinhoService carrinhoService;
        private IMapper mapper;
        private readonly ILogger<ProdutoController> log;

        public ProdutoController(
            IProdutoService produtoService, 
            IMapper mapper, 
            IPromocaoService promocaoService, 
            ICarrinhoService carrinhoService,
            ILogger<ProdutoController> log)
        {
            this.produtoService = produtoService;
            this.promocaoService = promocaoService;
            this.mapper = mapper;
            this.carrinhoService = carrinhoService;
            this.log = log;
        }

        public ActionResult Index()
        {
            return View(SelecionarTodos());
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewData["ListaPromocoes"] = promocaoService.ListarPromocoes();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if (collection != null)
                {
                    Produto produto = new Produto
                    {
                        Nome = collection["Nome"],
                        Preco = Convert.ToDecimal(collection["Preco"]),
                        Promocao = collection["Promocao"]
                    };

                    var produtoNoBanco = produtoService.ObterProdutoPorNome(produto.Nome);
                    if(produtoNoBanco != null)
                    {
                        produtoService.ExcluirProduto(produtoNoBanco.Id);
                    }
                    produtoService.InserirProduto(produto);
                }

                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                log.LogError($"Erro ao inserir produto: {ex}");
                return View();
            }
        }

        public ActionResult Edit(int id)
        {

            Produto produto = produtoService.ObterProduto(id);
            if (produto == null)
            {
                return BadRequest();
            }
            
            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                Nome = produto.Nome,
                Preco = produto.Preco,
                Promocao = produto.Promocao,
            };

            ViewData["ListaPromocoes"] = promocaoService.ListarPromocoes();
            
            return View(produtoViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
         {
            try
            {
                Produto produto = new Produto
                {
                    Id = id,
                    Nome = collection["Nome"],
                    Preco = Convert.ToDecimal(collection["Preco"]),
                    Promocao = collection["Promocao"],
                };
                produtoService.EditarProduto(produto);

                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                log.LogError($"Erro ao editar produto: {ex}");
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            Produto produto = produtoService.ObterProduto(id);
            if (produto == null)
            {
                return BadRequest();
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                Nome = produto.Nome,
                Preco = produto.Preco,
                Promocao = produto.Promocao,
            };
            
            return View(produtoViewModel);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var produto = produtoService.ObterProduto(id);
                var produtoNoCarrino = carrinhoService.ObterProdutoNoCarrinho(produto.Nome);
                produtoService.ExcluirProduto(id);
                if (produtoNoCarrino != null)
                {
                    carrinhoService.ExcluirProdutoDoCarrinho(produtoNoCarrino.Id);
                }
                
                Thread.Sleep(2000);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                log.LogError($"Erro ao deletar produto: {ex}");
                return View();
            }
        }

        public IEnumerable<ProdutoViewModel> SelecionarTodos()
        {
            var produtos = this.produtoService.ListarTodosProdutos();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Produto, ProdutoViewModel>();
            });

            mapper = config.CreateMapper();
            return mapper.Map<IEnumerable<Produto>, List<ProdutoViewModel>>(produtos);
        }
    }
}