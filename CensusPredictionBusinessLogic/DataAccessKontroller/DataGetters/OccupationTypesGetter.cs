using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
    public class OccupationTypesGetter
    {
        //Class for getting data of OccupationTypes from the database
        string sql = "exec SendOccupationType";
        DataAccess myAccess;
        public OccupationTypesGetter(DataAccess data)
        {
            myAccess = data;
        }
        public  List<OccupationType> GetOccupationTypes()
        {
            List<OccupationType> works =  myAccess.GetData<OccupationType>(sql).ToList();
            return works;
        }
    }
}
