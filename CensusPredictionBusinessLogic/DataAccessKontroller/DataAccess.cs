using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace CensusPredictionBusinessLogic
{
   public  class DataAccess:BaseDatabase
    {

        public  List<T> GetData<T>(string sql)
        {
            using(IDbConnection conn = new SqlConnection(Helper.CnnVal("MSProjekt")))
            {
                var people = conn.Query<T>(sql).ToList();
                return people;
            }
            

        }
     
    }
}
