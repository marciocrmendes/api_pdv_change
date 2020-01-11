using Infra.Config;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InfraTests
{
    public static class TestHelper
    {
        public static void Init()
        {
            AppConfigurationMannager.Init();
        }
    }
}
