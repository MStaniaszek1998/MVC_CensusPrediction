using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
    public class CountryGettercs
    {
        //Class for getting data of Countries from the database
        string sql = "exec SendCountry";
        DataAccess myAccess;
        public CountryGettercs(DataAccess data)
        {
            myAccess = data;
        }
        public  List<States> GetCountries()
        {
            List<States> works =  myAccess.GetData<States>(sql).ToList();
            return works;
        }
    }
}
