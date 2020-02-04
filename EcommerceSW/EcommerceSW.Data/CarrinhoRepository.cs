using Dapper;
using Dapper.Contrib.Extensions;
using EcommerceSW.Domain;
using EcommerceSW.Service.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace EcommerceSW.Data
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly string dataDirectory = string.Empty;
        private readonly string stringConnection;
        private readonly string basePath;
        private readonly string pathDataBase;
        private readonly ILogger<CarrinhoRepository> log;

        public CarrinhoRepository(IConfiguration configuration, ILogger<CarrinhoRepository> log)
        {
            basePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            pathDataBase = configuration.GetSection("PathDataBase").Value;
            dataDirectory = basePath + pathDataBase;
            stringConnection = string.Format($@"Server=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName={dataDirectory};");
            this.log = log;
        }

        public bool InserirProdutoNoCarrinho(Carrinho produto)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(stringConnection))
                {
                    var newTeste = db.Insert(produto);
                }
                return true;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (inserir carrinho): {ex}");
                return false;
            }
        }

        public IEnumerable<Carrinho> ListarTodosProdutosNoCarrinho()
        {
            IEnumerable<Carrinho> todosProdutos;
            try
            {
                using IDbConnection db = new SqlConnection(stringConnection);
                todosProdutos = db.GetAll<Carrinho>();
                return todosProdutos;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (listar todos carrinho): {ex}");
                return null;
            }
        }

        public bool ExcluirProdutoDoCarrinho(int id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(stringConnection))
                {

                    var newTeste = db.Delete(new Carrinho { Id = id });

                }
                return true;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (excluir produto carrinho): {ex}");
                return false;
            }
        }

        public Carrinho ObterProdutoNoCarrinho(string nomeProduto)
        {
            try
            {

                Carrinho produto = new Carrinho()
                {
                    NomeProduto = nomeProduto,
                };

                using IDbConnection db = new SqlConnection(stringConnection);
                produto = db.QueryFirstOrDefault<Carrinho>("SELECT Id as Id FROM Carrinho WHERE NomeProduto = @nomeProduto", produto);
                return produto;

            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (obter produto carrinho): {ex}");
                return null;
            }
        }
    }
}
