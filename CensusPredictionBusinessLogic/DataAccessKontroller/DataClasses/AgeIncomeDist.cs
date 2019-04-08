using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class AgeIncomeDist
    {
        //Class responsible for ORM mapping from the database using dapper
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
