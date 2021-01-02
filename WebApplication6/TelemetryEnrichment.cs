using Microsoft.ApplicationInsights.AspNetCore.TelemetryInitializers;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Http;

namespace WebApplication6
{
    public class TelemetryEnrichment : TelemetryInitializerBase
    {
        public TelemetryEnrichment(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }

        protected override void OnInitializeTelemetry(HttpContext platformContext, RequestTelemetry requestTelemetry, ITelemetry telemetry)
        {
            telemetry.Context.User.AuthenticatedUserId = "AuthId";
            telemetry.Context.User.AccountId = "AccountId";
            telemetry.Context.User.Id = "id-123";
            telemetry.Context.Properties["Tenant"] = "RSI";
        }
    }
}