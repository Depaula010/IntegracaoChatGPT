using Microsoft.AspNetCore.Builder;
using Serilog;

namespace chatgpt_aspnet_integracao.Extensions
{
    public static class SerilogExtensao
    {
        public static WebApplicationBuilder AddSerilog(this WebApplicationBuilder builder, IConfiguration configuration, string appName)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(Log.Logger, true); 

            return builder; 
        }
    }
}
