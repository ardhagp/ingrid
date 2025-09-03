using Microsoft.Extensions.Configuration;
using Serilog;

namespace Bridge.Security
{
    public class Getkey
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Salt()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["SALT"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }

        public string Syncfusion()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["SYNCFUSION"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }

        public string Betterstack_log()        
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var V_KEY = config.GetSection("KEYS")["BETTERSTACK_LOG"];

            if (V_KEY != null)
            {
                return V_KEY;
            }
            else
            {
                return "";
            }
        }
    }
    
    public class Writelog
    {

        public enum LogType
        {
            Information,
            Error
        }

        public static async Task Sendlog(string Messages, LogType TypeOfLog)
        {
            try
            {
                await Writelogs(Messages, TypeOfLog);
            }
            catch (Exception ex)
            {
                await Writelogs(ex.Message,LogType.Error);
            }
        }
        private static async Task Writelogs(string Messages, LogType TypeOfLog)
        {
            await Task.Delay(0);

            Bridge.Security.Getkey KEYLOG = new Bridge.Security.Getkey();

            Serilog.Log.Logger = new LoggerConfiguration()
                .WriteTo.BetterStack(sourceToken: KEYLOG.Betterstack_log())
                .MinimumLevel.Information()
                .CreateLogger();

            TimeZoneInfo localZone = TimeZoneInfo.Local;
            // Replace obsolete TimeZone usage with TimeZoneInfo
            DateTime currentDate = DateTime.Now;

            DateTime currentUTC = TimeZoneInfo.ConvertTimeToUtc(currentDate, localZone);
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);

            string OccuredAt = string.Format(Environment.NewLine + "--- Occured at: ---" + Environment.NewLine + "UTC: {0}" + Environment.NewLine + "Offset: {1}" + Environment.NewLine + "Device DateTime: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), currentUTC.ToString("yyyy-MM-dd HH:mm:ss"), currentOffset);

            Messages += OccuredAt;

            if (TypeOfLog == LogType.Information)
            {
                Serilog.Log.Information(Messages);
            }
            else
            {
                Serilog.Log.Error(Messages);
            }

            Serilog.Log.CloseAndFlush();
        }
    }
}

