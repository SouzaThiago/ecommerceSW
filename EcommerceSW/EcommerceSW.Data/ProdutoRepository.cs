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
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string dataDirectory = string.Empty;
        private readonly string stringConnection;
        private readonly string basePath;
        private readonly string pathDataBase;
        private readonly ILogger<ProdutoRepository> log;

        public ProdutoRepository(IConfiguration configuration, ILogger<ProdutoRepository> log)
        {
            basePath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            pathDataBase = configuration.GetSection("PathDataBase").Value;
            dataDirectory = basePath + pathDataBase;
            stringConnection = string.Format($@"Server=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName={dataDirectory};");
            this.log = log;
        }

        public bool InserirProduto(Produto produto)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(stringConnection))
                {
                    var newTeste = db.Insert(new Produto { Nome = produto.Nome, Preco = produto.Preco, Promocao = produto.Promocao });
                }
                return true;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (inserir produto): {ex}");
                return false;
            }
        }

        public bool EditarProduto(Produto produto)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(stringConnection))
                {
                    var newTeste = db.Update(new Produto { Id = produto.Id, Nome = produto.Nome, Preco = produto.Preco, Promocao = produto.Promocao });
                }
                return true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return false;
            }
        }

        public bool ExcluirProduto(int id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(stringConnection))
                {
                    bool result = db.Delete(new Produto { Id = id });
                }

                return true;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (editar produto): {ex}");
                return false;
            }
        }

        public Produto ObterProduto(int id)
        {
            Produto produto = new Produto();
            try
            {
                using IDbConnection db = new SqlConnection(stringConnection);
                produto = db.Get<Produto>(id);

            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (obter produto): {ex}");
            }

            return produto;
        }

        public Produto ObterProdutoPorNome(string nome)
        {
            Produto produto = new Produto()
            {
                Nome = nome,
            };

            try
            {
                using IDbConnection db = new SqlConnection(stringConnection);
                produto = db.QueryFirstOrDefault<Produto>("SELECT Id as Id FROM Produto WHERE Nome = @Nome", produto);
                return produto;
            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (obter por nome produto): {ex}");
                return null;
            }
        }

        public IEnumerable<Produto> ListarTodosProdutos()
        {
            IEnumerable<Produto> todosProdutos;
            try
            {
                using IDbConnection db = new SqlConnection(stringConnection);
                todosProdutos = db.GetAll<Produto>();
                return todosProdutos;

            }
            catch (Exception ex)
            {
                log.LogError($"Erro no banco de dados (listar todos): {ex}");
                return null;
            }
        }
    }
}
