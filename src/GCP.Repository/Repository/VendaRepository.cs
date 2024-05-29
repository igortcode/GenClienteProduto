using Dapper;
using GCP.App.DTO.Venda;
using GCP.App.Helpers;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;
using Microsoft.Extensions.Options;
using System.Data;

namespace GCP.Repository.Repository
{
    public class VendaRepository : AbstractRepository, IVendaRepository
    {
        public VendaRepository(DbSettings options) : base(options)
        {
        }

        public int Add(Venda entity, IDbTransaction transaction = null)
        {
            var sql = @"INSERT INTO ""Venda"" AS V (""ClienteId"", ""ValorTotal"", ""TipoPagamento"", ""DataInclusao"" ) 
                        VALUES(@ClienteId, @ValorTotal, @TipoPagamento, @DataInclusao) RETURNING V.""Id""";

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

        public IEnumerable<ObterVendaDTO> GetAllWithClienteRelations()
        {
            var sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            V.""DataInclusao"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente""
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId"" 
                        ORDER BY V.""DataInclusao"" DESC";

            try
            {
                OpenConnection();

                return DbConnection.Query<ObterVendaDTO>(sql);
            }
            finally
            {
                DbConnection?.Close();
            }
        }

        public Venda GetById(int id)
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

        public ObterVendaDTO GetByIdWithClienteRelations(int idVenda)
        {
            var sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            V.""DataInclusao"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente""
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId"" 
                        ORDER BY V.""DataInclusao"" DESC";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<ObterVendaDTO>(sql, new { VendaId = idVenda });
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

        public IList<ObterVendaDTO> SearchWithClienteRelations(string search)
        {

            var tipoPagamento = GetEnums.GetTipoPagamento(search);
            object parameters;
            string sql;

            if (tipoPagamento != null)
            {
                sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            V.""DataInclusao"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente""
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId""
                        WHERE V.""TipoPagamento"" = @pesquisa
                        ORDER BY V.""DataInclusao"" DESC";

                parameters = new { pesquisa = tipoPagamento };
            }
            else if(double.TryParse(search, out var val))
            {
                sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            V.""DataInclusao"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente""
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId""
                        WHERE V.""ValorTotal"" = @pesquisa
                        ORDER BY V.""DataInclusao"" DESC";

                parameters = new { pesquisa = val };
            }
            else
            {
                sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            V.""DataInclusao"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente""
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId""
                        WHERE C.""Nome"" LIKE @pesquisa
                        ORDER BY V.""DataInclusao"" DESC";

                parameters = new { pesquisa = $"%{search}%" };
            }

            try
            {
                OpenConnection();

                return DbConnection.Query<ObterVendaDTO>(sql, parameters).AsList();
            }
            finally
            {
                DbConnection?.Close();
            }
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
