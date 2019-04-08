using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class SexGetter
    {
        //Class for getting data of Sex from the database
        string sql = "exec SendSex";
        DataAccess myAccess;
        public SexGetter(DataAccess data)
        {
            myAccess = data;
        }
        public  List<SexType> GetSexs()
        {
            List<SexType> works =  myAccess.GetData<SexType>(sql).ToList();
            return works;
        }
    }
}
