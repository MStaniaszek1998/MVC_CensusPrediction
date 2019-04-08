using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller.DataClasses
{
   public  class PersonToPredict
    {
        //Stores the information (from user input) to predict by the database
        public int Age { get; set; }
        public string modelName { get; set; }
        public int educationNo { get; set; }
        public int Capitalgain { get; set; }
        public int hourPerweek { get; set; }
        public int idworkclass { get; set; }

        public int ideducation { get; set; }
        public int idMartialStatus { get; set; }
        public int idOccupation { get; set; }
        public int idrelationship { get; set; }
        public int idrace { get; set; }
        public int idcountry { get; set; }
        public int ifWoman { get; set; }


    }
}
