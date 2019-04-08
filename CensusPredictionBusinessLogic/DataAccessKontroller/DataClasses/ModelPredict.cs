using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class ModelPredict
    {
        //Class responsible for ORM mapping from the database using dapper
        private string modelName;

        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }
        private double score;

        public double Score
        {
            get { return score; }
            set { score = value; }
        }
        public string NameAndScore { get { return $"{modelName}: {string.Format("{0:0.00}%",score)}"; } }
    }
}
