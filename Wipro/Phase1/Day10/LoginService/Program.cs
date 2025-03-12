using System;
using System.Collections.Generic;
using NLog;

namespace LoginService
{
    public class AuthenticationService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private Dictionary<string, string> users = new Dictionary<string, string>()
        {
            { "Sata", "1234" },
            { "Sat", "123" }
        };

        public bool LogIn(string username, string password)
        {
            logger.Info($"Login attempt is made: {username}");

            if (!users.TryGetValue(username, out string storedPassword))
            {
                logger.Warn($"Login failed: Username '{username}' not found.");
                Console.WriteLine($"Login failed: Username '{username}' not found.");
                return false;
            }

            if (storedPassword != password)
            {
                logger.Warn($"Login failed: Incorrect password for user '{username}'.");
                Console.WriteLine($"Login failed: Incorrect password.");
                return false;
            }

            logger.Info($"Login successful: {username}");
            Console.WriteLine("Login successful");
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("LogFile")
            {
                FileName = "LogFile.txt",
                Layout = "${longdate} | ${level:uppercase=true} | ${message}"
            };

            var logconsole = new NLog.Targets.ConsoleTarget("LogConsole");

            config.AddTarget(logfile);
            config.AddTarget(logconsole);

            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfile);

            LogManager.Configuration = config;
            LogManager.ReconfigExistingLoggers();  // Ensures config is applied

            AuthenticationService authenticationService = new AuthenticationService();
            authenticationService.LogIn("Sata", "1234");   // Should succeed
            authenticationService.LogIn("Sata", "12345");  // Should fail (wrong password)
            authenticationService.LogIn("Sataaa", "12333"); // Should fail (wrong username)
        }

    }
}
