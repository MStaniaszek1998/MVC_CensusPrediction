using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
    public class EducationTypeGetter
    {
        //Class for getting data of EducationTypes from the database
        string sql = "exec SendEducationType";
        DataAccess myAccess;
        public EducationTypeGetter(DataAccess data)
        {
            myAccess = data;
        }
        public  List<EducationType> GetEducationTypes()
        {
            List<EducationType> works =  myAccess.GetData<EducationType>(sql).ToList();
            return works;
        }
    }
}
