using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class WorkClassTypeGetter
    {
        //Class for getting data of WorkClass from the database
        string sql = "exec SendWorkClassType";
        DataAccess myAccess;
        public WorkClassTypeGetter(DataAccess data)
        {
            myAccess = data;
        }
        public List<WorkClassType> GetWorkClassTypes()
        {
            List<WorkClassType> works =  myAccess.GetData<WorkClassType>(sql) as List<WorkClassType>;
            return works;
        }
    }
}
