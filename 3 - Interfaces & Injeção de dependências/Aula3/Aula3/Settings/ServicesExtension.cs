using Aula3.Clients;
using Aula3.Implementations;
using Aula3.Interfaces;
using Refit;


namespace Aula3.Settings
{
    public static class ServicesExtension
    {
        public static void ConfigurarInjecaoDependencia(this IServiceCollection services)
        {
            services.AddSingleton<IBancoDados, BancoDadosAzure>();
            services.AddRefitClient<IViaCep>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://viacep.com.br"));
        }
    }
}
