using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Infra.Config
{
    public static class AppConfigurationMannager
    {
        public static IConfiguration Configuration { get; private set; }

        public static void Init()
        {
            string pathToContentRoot = Directory.GetCurrentDirectory();
            string json = Path.Combine(pathToContentRoot, "appsettings.json");

            if (!File.Exists(json))
            {
                string pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                pathToContentRoot = Path.GetDirectoryName(pathToExe);
            }

            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(pathToContentRoot)
                .AddJsonFile("appsettings.json");

            Configuration = configurationBuilder.Build();
        }

        public static string GetConnectionString(string key)
        {
            return Configuration.GetConnectionString(key);
        }
    }
}
