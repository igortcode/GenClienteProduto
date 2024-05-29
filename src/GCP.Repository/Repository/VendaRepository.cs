using Dapper;
using GCP.App.DTO.Venda;
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

        public IEnumerable<ObterVendaDTO> GetAllWithRelations()
        {
            var sql = @"SELECT 
                            V.""Id"", 
                            V.""ValorTotal"", 
                            V.""TipoPagamento"",
                            C.""Id"" ""ClienteId"",
                            C.""Nome"" ""NomeCliente"",
                            P.""Id"" ""ProdutoId"",
                            P.""Nome"",
                            PV.""Codigo"",
                            PV.""Quantidade"",
                            Pv.""Preco"",
                        FROM ""Venda"" AS V 
                        INNER JOIN ""Cliente"" AS C ON C.""Id"" = V.""ClienteId"" 
                        INNER JOIN ""ProdutoXVenda"" AS PV ON PV.""VendaId"" = V.""Id"" 
                        INNER JOIN ""Produto"" AS P ON PV.""ProdutoId"" = P.""Id""
                        ORDER BY V.""DataInclusao"" DESC";

            try
            {
                OpenConnection();

                return DbConnection.Query<ObterVendaDTO, ProdutoXVendaDTO, ObterVendaDTO>(sql, (venda, produtos) => 
                { venda.Produtos.Add(produtos); 
                  return venda;
                }, splitOn: "ProdutoId");
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
