using Microsoft.Extensions.Configuration;
using Serilog;

namespace Bridge.Security
{
    public class Getkey
    {
        /// <summary>
        /// Get Salt Key from User Secrets
        /// </summary>
        /// <returns></returns>
        public string Salt()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY = config.GetSection("KEYS")["SALT"];

            if (varKEY != null)
            {
                return varKEY;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Get Syncfusion Key from User Secrets
        /// </summary>
        /// <returns></returns>
        public string Syncfusion()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY = config.GetSection("KEYS")["SYNCFUSION"];

            if (varKEY != null)
            {
                return varKEY;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Get Betterstack Log Key from User Secrets
        /// </summary>
        /// <returns></returns>
        public string Betterstack_log()        
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY =  config.GetSection("KEYS")["BETTERSTACK_LOG"];

            if (varKEY != null)
            {
                return varKEY;
            }
            else
            {
                return "";
            }
        }
    }

    
    /// <summary>
    /// Logging class to send logs to Betterstack
    /// </summary>
    public class Writelog
    {
        /// <summary>
        /// Sends a log entry to BetterStack. If the initial write fails,
        /// the exception message is logged instead.
        /// </summary>
        /// <param name="Messages">
        /// The log message to send.
        /// </param>
        /// <param name="TypeOfLog">
        /// The category or severity of the log entry. Fields like "Warning", "Information", "Debug", "Fatal", or "Error".
        /// </param>
        /// <returns>
        /// An asynchronous task representing the log operation.
        /// </returns>
        public static async Task Sendlog(string Messages, string TypeOfLog)
        {
            try
            {
                await Writelogs(Messages, TypeOfLog);
            }
            catch (Exception ex)
            {
                await Writelogs(ex.Message, TypeOfLog);
            }
        }

        /// <summary>
        /// Write logs to Betterstack
        /// </summary>
        /// <param name="Messages"></param>
        /// <param name="TypeOfLog"></param>
        /// <returns></returns>
        private static async Task Writelogs(string Messages, string TypeOfLog)
        {
            await Task.Delay(0);

            Getkey KEYLOG = new Getkey();

            Log.Logger = new LoggerConfiguration()
                .WriteTo.BetterStack(sourceToken: KEYLOG.Betterstack_log())
                .MinimumLevel.Information()
                .CreateLogger();

            TimeZoneInfo localZone = TimeZoneInfo.Local;
            DateTime currentDate = DateTime.Now;

            DateTime currentUTC = TimeZoneInfo.ConvertTimeToUtc(currentDate, localZone);
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);

            string Timestamp = string.Format(Environment.NewLine  + "\"utc\": \"{0}\"," + Environment.NewLine + "\"device\" : \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\"," + Environment.NewLine + "\"offset\" : \"{1}\"", currentUTC.ToString("yyyy-MM-dd HH:mm:ss"), currentOffset);

            Messages = "{"+Messages;
            Messages += Timestamp;
            Messages += "}";

            switch (TypeOfLog)
            {
                case "Warning":
                    Log.Warning(Messages);
                    break;

                case "Information":
                    Log.Information(Messages);
                    break;

                case "Debug":
                    Log.Debug(Messages);
                    break;

                case "Fatal":
                    Log.Fatal(Messages);
                    break;

                case "Error":
                    Log.Error(Messages);    
                    break;
            }

            await Log.CloseAndFlushAsync();
        }
    }
}

