using Dapper;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;
using System.Data;

namespace GCP.Repository.Repository
{
    public class ProdutoXVendaRepository : AbstractRepository, IProdutosXVendaRepository
    {
        public ProdutoXVendaRepository(DbSettings options) : base(options){}

        public int Add(ProdutosXVenda produtosXVenda, IDbTransaction transaction)
        {
            var sql = @"INSERT INTO ""ProdutosXVenda"" (""ProdutoId"", ""VendaId"", ""PrecoProduto"", ""QuantidadeProduto"", ""DataInclusao"") 
                            VALUES(@ProdutoId, @VendaId, @PrecoProduto, @QuantidadeProduto, @DataInclusao) RETURNING ""Id""";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, produtosXVenda, transaction);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void AddRange(IEnumerable<ProdutosXVenda> produtosXVenda, IDbTransaction transaction = null)
        {
            var sql = @"INSERT INTO ""ProdutosXVenda"" (""ProdutoId"", ""VendaId"", ""PrecoProduto"", ""QuantidadeProduto"", ""DataInclusao"") 
                            VALUES(@ProdutoId, @VendaId, @PrecoProduto, @QuantidadeProduto, @DataInclusao)";

            try
            {
                OpenConnection();
                DbConnection.Execute(sql, produtosXVenda, transaction);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void DesabilitarRestricoes()
        {
            var sql = @"ALTER TABLE ""ProdutosXVenda"" ALTER CONSTRAINT ""FK_VendaId_Venda"" DEFERRABLE INITIALLY DEFERRED;";

            try
            {
                OpenConnection();

                DbConnection.Execute(sql);
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public IEnumerable<ProdutosXVenda> GetAll(int idVenda)
        {
            var sql = @"SELECT * FROM ""ProdutosXVenda"" WHERE ""VendaId"" = @IdVenda";

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
            var sql = @"SELECT * FROM ""ProdutosXVenda"" WHERE ""Id"" = @Id";

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
            var sql = @"DELETE FROM ""ProdutosXVenda"" WHERE ""ProdutoId"" = @IdProduto AND ""VendaId"" = @IdVenda";

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
