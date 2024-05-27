using Dapper;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;
using Microsoft.Extensions.Options;

namespace GCP.Repository.Repository
{
    public class VendaRepository : AbstractRepository, IVendaRepository
    {
        public VendaRepository(DbSettings options) : base(options)
        {
        }

        public int Add(Venda entity)
        {
            var sql = @"INSERT INTO ""Venda"" (""ClienteId"", ""ValorTotal"", ""TipoPagamento"", ""DataInclusao"" ) 
                        VALUES(@ClienteId, @ValorTotal, @TipoPagamento, @DataInclusao) RETURNING ""Id""";

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

        public IEnumerable<Venda> GetAll()
        {
            var sql = @"SELECT * FROM ""Venda"" ORDER BY ""DataInclusao"" DESC" ;

            try
            {
                OpenConnection();

                return DbConnection.Query<Venda>(sql);
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public Venda? GetById(int id)
        {
            var sql = @"SELECT * FROM ""Venda"" WHERE ""Id"" = @Id";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<Venda>(sql, new { Id = id });
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public int Remove(int id)
        {
            var sql = @"DELETE FROM ""Venda"" WHERE ""Id"" = @Id";

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

        public IEnumerable<Venda> Search(string search)
        {
            throw new NotImplementedException();
        }

        public int Update(Venda entity)
        {
            var sql = @"UPDATE Venda 
                                SET ""ClienteId"" = @ClienteId, 
                                    ""ValorTotal"" = @ValorTotal, 
                                    ""TipoPagamento"" = @TipoPagamento) 
                                WHERE ""Id"" = @Id RETURNING ""Id""";

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
