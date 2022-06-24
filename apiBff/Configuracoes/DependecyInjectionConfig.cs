using apiBff.Interfaces;
using apiBff.Notificacoes;
using apiBff.Services;

namespace apiBff.Configuracoes
{
    public static class DependecyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICadastroService, CadastroService>();
            services.AddScoped<IOperacionalService, OperacionalService>();
            services.AddScoped<IFrontAgendamentoService, FrontAgendamentoService>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}