using EcommerceSW.Domain;
using EcommerceSW.Service.Contracts;
using System.Collections.Generic;

namespace EcommerceSW.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository repository;

        public ProdutoService(IProdutoRepository repository)
        {
            this.repository = repository;
        }

        public Produto ObterProduto(int id)
        {
            var produto = repository.ObterProduto(id);

            return produto;
        }

        public bool InserirProduto(Produto produto)
        {
            return repository.InserirProduto(produto);
        }

        public bool EditarProduto(Produto produto)
        {
            return repository.EditarProduto(produto);
        }

        public bool ExcluirProduto(int id)
        {
            return repository.ExcluirProduto(id);
        }

        public IEnumerable<Produto> ListarTodosProdutos()
        {
            return repository.ListarTodosProdutos();
        }

        public Produto ObterProdutoPorNome(string nome)
        {
            return repository.ObterProdutoPorNome(nome);
        }
    }
}
