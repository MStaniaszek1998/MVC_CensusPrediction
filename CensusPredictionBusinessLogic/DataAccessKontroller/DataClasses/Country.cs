using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class States
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idCountry;
        private string country;

        public string Country
        {
            get { return country; }
            set {  country = value;  }
        }

        public int IdCountry
        {
            get { return idCountry; }
            set { idCountry = value; }
        }

    }
}
