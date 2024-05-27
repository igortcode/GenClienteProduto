using Dapper;
using GCP.App.Interfaces.Repository;
using GCP.App.Settings;
using GCP.Core.Entities;

namespace GCP.Repository.Repository
{
    public class ClienteRepository : AbstractRepository, IClienteRepository
    {
        public ClienteRepository(DbSettings options) : base(options)
        {
        }

        public int Add(Cliente entity)
        {
            var sql = @"INSERT INTO ""Cliente"" (""Nome"", ""Cpf"", ""Cep"", ""Logradouro"", ""Bairro"", ""Cidade"", ""Estado"", ""Numero"", ""Complemento"", ""Telefone"", ""Email"", ""DataInclusao"")
                        VALUES( @Nome, @Cpf, @Cep, @Logradouro, @Bairro, @Cidade, @Estado, @Numero, @Complemento, @Telefone, @Email, @DataInclusao) RETURNING ""Id"" ";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, new
                {
                    entity.Nome,
                    entity.Cpf,
                    entity.Endereco?.Cep,
                    entity.Endereco?.Logradouro,
                    entity.Endereco?.Bairro,
                    entity.Endereco?.Cidade,
                    entity.Endereco?.Estado,
                    entity.Endereco?.Numero,
                    entity.Endereco?.Complemento,
                    entity.Telefone,
                    entity.Email,
                    entity.DataInclusao
                });
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool ExistePorCpf(string cpf)
        {
            var sql = @"SELECT COUNT(1) FROM ""Cliente"" WHERE ""Cpf"" = @Cpf";

            try
            {
                OpenConnection();

                return DbConnection.ExecuteScalar<int>(sql, new { Cpf = cpf }) > 0;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            var sql = @"SELECT * FROM ""Cliente"" ORDER BY ""DataInclusao"" DESC";

            try
            {
                OpenConnection();

                return DbConnection.Query<Cliente>(sql);
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Cliente? GetById(int id)
        {
            var sql = @"SELECT * FROM ""Cliente"" WHERE ""Id"" = @Id";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<Cliente>(sql, new {Id = id});
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Cliente? GetByCpf(string cpf)
        {
            var sql = @"SELECT * FROM ""Cliente"" WHERE ""Cpf"" = @Cpf";

            try
            {
                OpenConnection();

                return DbConnection.QueryFirstOrDefault<Cliente>(sql, new { Cpf = cpf });
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public int Remove(int id)
        {
            var sql = @"DELETE FROM ""Cliente"" WHERE ""Id"" = @Id";

            try
            {
                OpenConnection();

                return DbConnection.Execute(sql, new { Id = id });
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public IEnumerable<Cliente> Search(string search)
        {
            var sql = @"SELECT * FROM ""Cliente"" 
                WHERE 
                ""Nome"" LIKE @pesquisa OR
                ""Cpf"" LIKE @pesquisa OR
                ""Email"" LIKE @pesquisa OR
                ""Telefone"" LIKE @pesquisa OR
                ""Cep"" LIKE @pesquisa OR
                ""Logradouro"" LIKE @pesquisa OR
                ""Bairro"" LIKE @pesquisa OR
                ""Cidade"" LIKE @pesquisa OR
                ""Estado"" LIKE @pesquisa OR
                ""Numero"" LIKE @pesquisa OR
                ""Complemento"" LIKE @pesquisa
                 ORDER BY ""DataInclusao"" DESC";

            try
            {
                OpenConnection();

                return DbConnection.Query<Cliente>(sql, new {pesquisa = $"%{search}%"});
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public int Update(Cliente entity)
        {
            var sql = @"UPDATE ""Cliente"" SET
                                    ""Nome"" = @Nome, 
                                    ""Cpf"" = @Cpf, 
                                    ""Cep"" = @Cep, 
                                    ""Logradouro"" = @Logradouro, 
                                    ""Bairro"" = @Bairro, 
                                    ""Cidade"" = @Cidade, 
                                    ""Estado"" = @Estado, 
                                    ""Numero"" = @Numero, 
                                    ""Complemento"" = @Complemento, 
                                    ""Telefone"" = @Telefone, 
                                    ""Email"" = @Email WHERE ""Id"" = @Id
                                        RETURNING ""Id""";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, new
                {
                    entity.Nome,
                    entity.Cpf,
                    entity.Endereco?.Cep,
                    entity.Endereco?.Logradouro,
                    entity.Endereco?.Bairro,
                    entity.Endereco?.Cidade,
                    entity.Endereco?.Estado,
                    entity.Endereco?.Numero,
                    entity.Endereco?.Complemento,
                    entity.Telefone,
                    entity.Email,
                    entity.Id
                });
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
