using Microsoft.Extensions.Configuration;
using Serilog;

namespace Bridge
{
    /// <summary>
    /// Provides methods to retrieve secret keys from user secrets.
    /// </summary>
    public class Getkey
    {
        /// <summary>
        /// Get Salt Key from User Secrets
        /// </summary>
        /// <summary>
        /// Retrieves the 'SALT' secret from user secrets under the "KEYS" section.
        /// </summary>
        /// <returns>The value of KEYS:SALT if present; otherwise an empty string.</returns>
        public static string Salt()
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
        /// <summary>
        /// Retrieves the Syncfusion key from user secrets (KEYS:SYNCFUSION).
        /// </summary>
        /// <returns>The Syncfusion key if found; otherwise an empty string.</returns>
        public static string Syncfusion()
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
        /// <summary>
        /// Retrieve the BetterStack source token from user secrets (KEYS:BETTERSTACK_LOG) or return an empty string if not configured.
        /// </summary>
        /// <returns>The BetterStack source token when present; otherwise an empty string.</returns>
        public static string Betterstack_log()        
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

        /// <summary>
        /// Get Betterstack Heartbeats Key from User Secrets
        /// </summary>
        /// <returns></returns>
        public static string Betterstack_heartbeats()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY = config.GetSection("KEYS")["BETTERSTACK_HEARTBEATS"];

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
        /// Get Cloud Storage Url from User Secrets
        /// </summary>
        /// <returns>The Cloud Storage Url if found; otherwise an empty string.</returns>
        public static string CloudStorageUrl()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY = config.GetSection("KEYS")["CLOUDSTORAGE"];

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
        /// Get Repo Page Url from User Secrets
        /// </summary>
        /// <returns>The Repo Page Url if found; otherwise an empty string.</returns>
        public static string RepoPageUrl()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Getkey>()
                .Build();

            var varKEY = config.GetSection("KEYS")["REPOPAGE"];

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
    public static class Writelog
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
        /// <summary>
        /// Writes the provided message to BetterStack and, if writing fails, retries by logging the caught exception's message.
        /// </summary>
        /// <param name="Messages">The log message payload; will be wrapped into the JSON-like payload sent to the sink.</param>
        /// <param name="TypeOfLog">The severity level to emit (e.g., "Warning", "Information", "Debug", "Fatal", "Error").</param>
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
        /// <summary>
        /// Sends the provided message to BetterStack using the Betterstack token from user secrets and records a timestamped log entry with the specified severity.
        /// </summary>
        /// <param name="Messages">The log payload body; it will be wrapped into a JSON-like object and augmented with a UTC timestamp, local device timestamp, and offset.</param>
        /// <param name="TypeOfLog">The log level to emit; allowed values are "Warning", "Information", "Debug", "Fatal", and "Error".</param>
        private static async Task Writelogs(string Messages, string TypeOfLog)
        {
            await Task.Delay(0);

            Log.Logger = new LoggerConfiguration()
                .WriteTo.BetterStack(sourceToken: Getkey.Betterstack_log())
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
