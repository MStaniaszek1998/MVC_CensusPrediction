using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CensusPredictionBusinessLogic
{
   public abstract class BaseDatabase
    {
        protected async Task<T> WithConnection<T>(Func<IDbConnection, Task<T>> getData)
        {
            try
            {//Creating a connection to the database for query executing
                using (var connection = new SqlConnection(Helper.CnnVal("MSProjekt")))
                {
                    await connection.OpenAsync();
                    return await getData(connection);
                }
        }
            catch (SqlException ex)
            {

                
                throw new Exception(string.Format("WithConnection() error SQL exeption MESSAGE: {0}", ex.Message), ex);
               
            }
}
     
    }
}
