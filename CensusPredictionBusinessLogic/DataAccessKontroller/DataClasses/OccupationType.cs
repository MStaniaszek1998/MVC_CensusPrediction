using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
   public  class OccupationType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idOccupation;
        private string occupation;

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public int IdOccupation
        {
            get { return idOccupation; }
            set { idOccupation = value; }
        }

    }
}
