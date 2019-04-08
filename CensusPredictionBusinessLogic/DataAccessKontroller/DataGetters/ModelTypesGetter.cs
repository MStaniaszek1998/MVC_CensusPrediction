using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class ModelTypesGetter
    {
        //Class for getting data of predicting Models from the database
        string sql = "exec SendModels";
        DataAccess myAccess;
        public ModelTypesGetter(DataAccess data)
        {
            myAccess = data;
        }
        public  List<ModelPredict> GetModelTypes()
        {
            List<ModelPredict> works =  myAccess.GetData<ModelPredict>(sql).ToList();
            return works;
        }
    }
}
