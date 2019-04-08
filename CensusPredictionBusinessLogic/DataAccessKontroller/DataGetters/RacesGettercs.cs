using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class RacesGettercs
    {
        //Class for getting data of Races from the database
        string sql = "exec SendRace";
        DataAccess myAccess;
        public RacesGettercs(DataAccess data)
        {
            myAccess = data;
        }
        public  List<Races> GetRaces()
        {
            List<Races> works =  myAccess.GetData<Races>(sql).ToList();
            return works;
        }
    }
}

