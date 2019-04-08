using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class SexType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idSex;
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int IdSex
        {
            get { return idSex; }
            set { idSex = value; }
        }

    }
}
