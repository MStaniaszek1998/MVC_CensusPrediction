using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
    public class AgeDistGettercs
    {
        ////Class for getting samples data of Age(basing on the type of income from the database
        string sql;
        DataAccess myAccess;
        public AgeDistGettercs(DataAccess data, int id)
        {
            myAccess = data;
            sql = $"exec GetSampleIncomeAge @IdIncome={id}";
        }
        public  List<AgeIncomeDist> GetAgeDist()
        {
            List<AgeIncomeDist> works =  myAccess.GetData<AgeIncomeDist>(sql).ToList();
            return works.ToList();
        }
    }
}
