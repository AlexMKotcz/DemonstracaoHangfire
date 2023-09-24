using Hangfire;
using Hangfire.PostgreSql;

namespace Demonstracao.API;

public static class HangfireConfiguration
{
	public static IServiceCollection AddHangfireService(this IServiceCollection services, IConfiguration config)
	{
		services.AddHangfire(configuration => configuration
	   .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
	   .UseSimpleAssemblyNameTypeSerializer()
	   .UseRecommendedSerializerSettings()
	   .UsePostgreSqlStorage(config.GetConnectionString("HangfireDatabase")));

		services.AddHangfireServer(options =>
		{
			options.Queues = new[]
			{
				"filademorada",
				"filadeerros",
				"filacomdificuldades"
			};
		});

		return services;
	}

	public static IApplicationBuilder AddHangfireServer(this IApplicationBuilder app)
	{
		app.UseHangfireDashboard();

		return app;
	}
}