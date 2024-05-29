using GCP.App.Settings;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;

namespace GCP.Repository.Repository
{
    public abstract class AbstractRepository
    {
        private readonly DbSettings _dbSetting;
        protected IDbConnection DbConnection;
        protected AbstractRepository(DbSettings options)
        {
            _dbSetting = options;
            DbConnection = GetConnection(_dbSetting.ConnectionString);
            DbConnection.Close();
        }

        private IDbConnection GetConnection(string? connectionString)
        {
            var conn = new NpgsqlDataSourceBuilder(connectionString);

            return conn.Build().OpenConnection();
        }

        protected void OpenConnection()
        {
            if(DbConnection == null)
            {
                DbConnection = GetConnection(_dbSetting.ConnectionString);
                return;
            }

            if(DbConnection.State != ConnectionState.Open)
            {
                DbConnection.Open();
            }
        }

        public IDbTransaction BeginTransaction()
        {
            OpenConnection();

            return DbConnection.BeginTransaction();
        }
    }
}
