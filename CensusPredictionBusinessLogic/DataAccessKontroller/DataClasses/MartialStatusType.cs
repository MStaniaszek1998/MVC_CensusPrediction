using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class MartialStatusType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idMartialStatus;

        public int IdMartialStatus
        {
            get { return idMartialStatus; }
            set { idMartialStatus = value; }
        }
        private string martialStatus;

        public string MartialStatus
        {
            get { return martialStatus; }
            set { martialStatus = value; }
        }

    }
}
