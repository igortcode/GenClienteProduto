using Dapper;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;
using System.Data;

namespace GCP.Repository.Repository
{
    public class ProdutoRepository : AbstractRepository, IProdutoRepository
    {
        public ProdutoRepository(DbSettings options) : base(options) { }

        public int Add(Produto entity, IDbTransaction transaction = null)
        {
            var sql = "INSERT INTO \"Produto\" (\"Nome\", \"Codigo\", \"Descricao\", \"Preco\", \"Quantidade\", \"DataInclusao\") " +
                        "VALUES(@Nome, @Codigo, @Descricao, @Preco, @Quantidade, @DataInclusao) RETURNING \"Id\"";

            try
            {
                OpenConnection();              
                return DbConnection.ExecuteScalar<int>(sql, entity, transaction);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool ExistByCode(string code)
        {
            var sql = "SELECT COUNT(1) FROM \"Produto\" WHERE \"Codigo\" = @Code";

            try
            {
                OpenConnection();

                return DbConnection.ExecuteScalar<int>(sql, new {Code = code}) > 0;
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public IEnumerable<Produto> GetAll()
        {
            var sql = "SELECT * FROM \"Produto\" ORDER BY \"DataInclusao\" DESC";

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

        public Produto GetByCodigo(string code)
        {
            var sql = "SELECT * FROM \"Produto\" WHERE \"Codigo\" = @codigo";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<Produto>(sql, new { codigo = code });
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public Produto? GetById(int id)
        {
            var sql = "SELECT * FROM \"Produto\" WHERE \"Id\" = @Id" ;

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
            var sql = "DELETE FROM \"Produto\" WHERE \"Id\" = @Id";

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

        public IEnumerable<Produto> Search(string search)
        {

            if(decimal.TryParse(search, out var decimalValue))
            {
                var sql = "SELECT * FROM \"Produto\"" +
                        "WHERE \"Preco\" = @pesquisa OR \"Quantidade\" = @pesquisa";

                try
                {
                    OpenConnection();

                    return DbConnection.Query<Produto>(sql, new {pesquisa = decimalValue});
                }
                finally
                {
                    DbConnection?.Close();
                }

            }
            else
            {
                var sql = "SELECT * FROM \"Produto\"" +
                    "WHERE \"Nome\" LIKE @pesquisa OR \"Codigo\" LIKE @pesquisa OR \"Descricao\" LIKE @pesquisa";

                try
                {
                    OpenConnection();

                    return DbConnection.Query<Produto>(sql, new { pesquisa = $"%{search}%" });
                }
                finally
                {
                    DbConnection?.Close();
                }
            }
        }

        public int Update(Produto entity)
        {
            var sql = "UPDATE \"Produto\" SET \"Nome\" = @Nome, \"Codigo\" = @Codigo, \"Descricao\" = @Descricao, \"Preco\" = @Preco, \"Quantidade\" = @Quantidade"+
                                " WHERE \"Id\"= @Id RETURNING \"Id\"";

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
