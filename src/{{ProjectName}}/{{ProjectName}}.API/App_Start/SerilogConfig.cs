using Serilog;
using System.Web.Hosting;

namespace __ProjectName__.API.App_Start
{
    public static class SerilogConfig
    {
        public static void Configure()
        {
            var logPath = HostingEnvironment.MapPath("~/Logs/log-.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(
                    path: logPath,
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Serilog configured. Log path: {LogPath}", logPath);
        }
    }
}