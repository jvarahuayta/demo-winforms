using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinjo.Base.Utils
{
    public class ConfigurationUtil
    {
        public static string GetConnectionString(string connectionName)
        {
            try
            {
                return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            }
            catch
            {
                return null;
            }
        }
    }
}
