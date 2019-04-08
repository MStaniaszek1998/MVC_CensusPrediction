using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class Helper
    {
        public static string CnnVal(string name)
        {//Retrives the connectionstring from the App.config of the WinFormsPL 
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
