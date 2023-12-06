using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AzureOps_SampleApp
{
    public class SampleHealthCheck : IHealthCheck
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<SampleHealthCheck> _logger;

        public SampleHealthCheck(IConfiguration configuration, ILogger<SampleHealthCheck> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            // 正常性を表すフラグ
            var isHealthy = true;

            // SQL Server接続の正常性を確認する
            using (var connection = new SqlConnection(_configuration.GetConnectionString("AzureOps_SampleAppContext")))
            {
                _logger.LogInformation("SQL Serverに接続します");
                try
                {
                    await connection.OpenAsync(cancellationToken);
                    _logger.LogInformation("SQL Serverに正常に接続できています");
                }
                catch (Exception)
                {
                    _logger.LogError("SQL Serverに接続できませんでした");
                    isHealthy = false;
                }
            }

            if (isHealthy)
            {
                return HealthCheckResult.Healthy("A healthy result.");
            }

            return HealthCheckResult.Unhealthy("An unhealthy result.");
        }

    }
}
