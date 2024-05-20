namespace Peak.API.Configurations;

public static class CorsConfiguration
{
    public static void AddCorsConfiguration(this IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyHeader(); 
                policy.AllowAnyMethod();
            });
        });
    }
}
