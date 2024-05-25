using Dapper;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;
using Microsoft.Extensions.Options;

namespace GCP.Repository.Repository
{
    public class ProdutoXVendaRepository : AbstractRepository, IProdutosXVendaRepository
    {
        public ProdutoXVendaRepository(DbSettings options) : base(options){}

        public int Add(ProdutosXVenda produtosXVenda)
        {
            var sql = "INSERT INTO ProdutoXVenda VALUES(@ProdutoId, @VendaId, @PrecoProduto, @QuantidadeProduto, @DataInclusao) RETURNING Id";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, produtosXVenda);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public IEnumerable<ProdutosXVenda> GetAll(int idVenda)
        {
            var sql = "SELECT * FROM ProdutoXVenda WHERE VendaId = @IdVenda";

            try
            {
                OpenConnection();

                return DbConnection.Query<ProdutosXVenda>(sql, new {IdVenda = idVenda});
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public ProdutosXVenda? GetById(int id)
        {
            var sql = "SELECT * FROM ProdutosXVenda WHERE Id = @Id";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<ProdutosXVenda>(sql, new { Id = id });
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public int Remove(int idProduto, int idVenda)
        {
            var sql = "DELETE FROM Venda WHERE ProdutoId = @IdProduto AND VendaId = @IdVenda";

            try
            {
                OpenConnection();

                return DbConnection.Execute(sql, new { IdProduto = idProduto, IdVenda = idVenda });
            }
            finally
            {
                DbConnection?.Close();
            }
        }
    }
}
