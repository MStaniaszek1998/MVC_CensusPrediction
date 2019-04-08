using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class MartialStatusTypeGetter
    {
        //Class for getting data of MartialStatusTypes from the database
        string sql = "exec SendMartialStatusType";
        DataAccess myAccess;
        public MartialStatusTypeGetter(DataAccess data)
        {
            myAccess = data;
        }
        public  List<MartialStatusType> GetMartialStatusType()
        {
            List<MartialStatusType> works =  myAccess.GetData<MartialStatusType>(sql).ToList();
            return works;
        }
    }
}
