namespace Api.Configs
{
    public static class CorsConfigs
    {
        public static readonly string Cors = "CORSPOLICY";

        public static IServiceCollection AddCors(this IServiceCollection services, string origins) 
        {
            return services.AddCors(opt =>
            {
                //opt.AddPolicy(Cors, builder => builder.WithOrigins(origins.Split(";"))
                //.AllowAnyMethod()
                //.AllowCredentials()
                //.AllowAnyHeader());
                opt.AddDefaultPolicy(builder =>
                    builder.AllowAnyMethod()
                           .AllowAnyOrigin()
                           .AllowAnyHeader());
            });
        }
        public static IApplicationBuilder UseCorsConfig(this IApplicationBuilder app)
        {
            //return app.UseCors(Cors);
            return app.UseCors(builder =>
                    builder.AllowAnyMethod()
                           .AllowAnyOrigin()
                           .AllowAnyHeader());
        }
    }
}
