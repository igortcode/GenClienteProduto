using Dapper;
using GCP.Application.Interfaces.Generic;
using GCP.Application.Interfaces.Repository;
using GCP.Application.Settings;
using GCP.Core.Entities;
using Microsoft.Extensions.Options;

namespace GCP.Repository.Repository
{
    public class ProdutoRepository : AbstractRepository, IProdutoRepository
    {
        public ProdutoRepository(IOptions<DbSettings> options) : base(options) { }

        public int Add(Produto entity)
        {
            var sql = "INSERT INTO Produto VALUES(@Nome, @Codigo, @Descricao, @Preco, @Quantidade, @DataInclusao) RETURNING Id";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, entity);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public IEnumerable<Produto> GetAll()
        {
            var sql = "SELECT * FROM Produto";

            try
            {
                OpenConnection();

                return DbConnection.Query<Produto>(sql);
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public Produto? GetById(int id)
        {
            var sql = "SELECT * FROM Produto WHERE Id = @Id";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<Produto>(sql, new { Id = id });
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public int Remove(int id)
        {
            var sql = "DELETE FROM Produto WHERE Id = @Id";

            try
            {
                OpenConnection();

                return DbConnection.Execute(sql, new { Id = id });
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public int Update(Produto entity)
        {
            var sql = @"UPDATE Produto 
                                SET(Nome = @Nome, 
                                    Codigo=@Codigo, 
                                    Descricao=@Descricao, 
                                    Preco=@Preco, 
                                    Quantidade=@Quantidade) 
                                WHERE Id=@Id RETURNING Id";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, entity);
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
