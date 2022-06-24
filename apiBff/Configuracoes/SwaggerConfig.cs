namespace apiBff.Configuracoes
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Exemplo API Bff - BackEnd for FrontEnd",
                    Version = "v1"

                });
            });
            
            return services;
        }
    }
}