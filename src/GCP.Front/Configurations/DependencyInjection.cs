using GCP.App.Interfaces.Repository;
using GCP.App.Interfaces.Services;
using GCP.App.Profiles;
using GCP.App.Services;
using GCP.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GCP.Front.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependency(this IServiceCollection services)
        {
            #region Repository
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IProdutosXVendaRepository, ProdutoXVendaRepository>();
            #endregion

            #region Service
            services.AddScoped<IProdutoServices, ProdutoServices>();
            #endregion


            services.AddAutoMapper(typeof(MapProfile));

            return services;
        }
    }
}
