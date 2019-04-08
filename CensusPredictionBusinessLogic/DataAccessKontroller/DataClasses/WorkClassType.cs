using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
   public  class WorkClassType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idWorkClass;
     
        private string workClass;

        public string WorkClass
        {
            get { return workClass; }
            set { workClass = value; }
        }


        public  int IdWorkClass
        {
            get { return idWorkClass; }
            set { idWorkClass = value; }
        }

    }
}
