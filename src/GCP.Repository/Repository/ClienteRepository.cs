using Dapper;
using GCP.Application.Interfaces.Repository;
using GCP.Application.Settings;
using GCP.Core.Entities;
using Microsoft.Extensions.Options;

namespace GCP.Repository.Repository
{
    public class ClienteRepository : AbstractRepository, IClienteRepository
    {
        public ClienteRepository(IOptions<DbSettings> options) : base(options)
        {
        }

        public int Add(Cliente entity)
        {
            var sql = @"INSERT INTO Cliente VALUES(
                                    @Nome, 
                                    @Cpf, 
                                    @Cep, 
                                    @Logradouro, 
                                    @Bairro, 
                                    @Cidade, 
                                    @Estado, 
                                    @Numero, 
                                    @Complemento, 
                                    @Telefone, 
                                    @Email, 
                                    @DataInclusao) 
                                        RETURNING Id";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, new
                {
                    Nome = entity.Nome,
                    Cpf = entity.Cpf,
                    Cep = entity.Endereco?.Cep,
                    Logradouro = entity.Endereco?.Logradouro,
                    Bairro = entity.Endereco?.Bairro,
                    Cidade = entity.Endereco?.Cidade,
                    Estado = entity.Endereco?.Estado,
                    Numero = entity.Endereco?.Numero,
                    Complemento = entity.Endereco?.Complemento,
                    Telefone = entity.Telefone,
                    Email = entity.Email,
                    DataInclusao = entity.DataInclusao
                });
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            var sql = "SELECT * FROM Cliente";

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
            var sql = "SELECT * FROM Cliente WHERE Id = @Id";

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

        public int Remove(int id)
        {
            var sql = "DELETE FROM Cliente WHERE Id = @Id";

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

        public int Update(Cliente entity)
        {
            var sql = @"UPDATE Cliente SET(
                                    Nome=@Nome, 
                                    Cpf=@Cpf, 
                                    Cep=@Cep, 
                                    Logradouro=@Logradouro, 
                                    Bairro=@Bairro, 
                                    Cidade=@Cidade, 
                                    Estado=@Estado, 
                                    Numero=@Numero, 
                                    Complemento=@Complemento, 
                                    Telefone=@Telefone, 
                                    Email=@Email) WHERE Id= @Id
                                        RETURNING Id";

            try
            {
                OpenConnection();
                return DbConnection.ExecuteScalar<int>(sql, new
                {
                    Nome = entity.Nome,
                    Cpf = entity.Cpf,
                    Cep = entity.Endereco?.Cep,
                    Logradouro = entity.Endereco?.Logradouro,
                    Bairro = entity.Endereco?.Bairro,
                    Cidade = entity.Endereco?.Cidade,
                    Estado = entity.Endereco?.Estado,
                    Numero = entity.Endereco?.Numero,
                    Complemento = entity.Endereco?.Complemento,
                    Telefone = entity.Telefone,
                    Email = entity.Email,
                    Id = entity.Id
                });
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
