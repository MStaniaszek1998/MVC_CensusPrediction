using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class PredictedScore
    {
        //Class responsible for ORM mapping from the database using dapper
        private double incomeAbove50;

        public double IncomeAbove50
        {
            get { return incomeAbove50; }
            set { incomeAbove50 = value; }
        }
        private double incomeBelow50;

        public double IncomeBelow50
        {
            get { return incomeBelow50; }
            set { incomeBelow50 = value; }
        }

    }
}
