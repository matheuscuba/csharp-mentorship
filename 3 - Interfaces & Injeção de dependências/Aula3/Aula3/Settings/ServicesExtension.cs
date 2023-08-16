using Aula3.Implementations;
using Aula3.Interfaces;

namespace Aula3.Settings
{
    public static class ServicesExtension
    {
        public static void ConfigurarInjecaoDependencia(this IServiceCollection services)
        {
            services.AddSingleton<IBancoDados, BancoDadosAzure>();
        }
    }
}
