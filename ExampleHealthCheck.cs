using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AspNetCoreAppHealthCheck
{
    public class ExampleHealthCheck : IHealthCheck
    {
        public ExampleHealthCheck()
        {
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken ct = default)
        {
            var healthCheckResultHealthy = true;

            return healthCheckResultHealthy
                ? Task.FromResult(HealthCheckResult.Healthy("The check indicates a healthy result."))
                : Task.FromResult(HealthCheckResult.Unhealthy("The check indicates an unhealthy result."));
        }
    }
}