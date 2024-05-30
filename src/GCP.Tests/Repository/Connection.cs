using GCP.App.Settings;
using System.Configuration;

namespace GCP.Tests.Repository
{
    public static class Connection
    {
        public static DbSettings GetDbSettings()
        {
            var settings = new DbSettings();

            settings.ConnectionString = "Host=localhost;Username=postgres;Password=123456;Database=GCP";

            return settings;
        }
    }
}
