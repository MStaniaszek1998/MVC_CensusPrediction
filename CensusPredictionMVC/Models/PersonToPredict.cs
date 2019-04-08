using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionMVC.Models
{
   public  class PersonToPredictModel
    {
        //Stores the information (from user input) to predict by the database
        [Required ]
        [Range(0, Double.PositiveInfinity, ErrorMessage ="Age can not be below 0")]
        public int Age { get; set; }//by userinput
        [Required]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "Years of education can not be below 0")]
        public int educationNo { get; set; }//by userinput
        [Required]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "Capital Gain can not be below 0")]
        public int Capitalgain { get; set; }//by userinput
        [Required]
        [Range(0, Double.PositiveInfinity, ErrorMessage = "Work hours can not be below 0")]
        public int hourPerweek { get; set; }//by userinput

        
        public int idworkclass { get; set; }
        public string modelName { get; set; }
        public int ideducation { get; set; }
        public int idMartialStatus { get; set; }
        public int idOccupation { get; set; }
        public int idrelationship { get; set; }
        public int idrace { get; set; }
        public int idcountry { get; set; }
        public int ifWoman { get; set; }
        double above50k = 0;
        double below50k = 0;
        [DisplayFormat(DataFormatString = "{0:0.00}%", ApplyFormatInEditMode = true)]
        public double Above50kProp { get { return above50k; } set { above50k = value; } }
        [DisplayFormat(DataFormatString = "{0:0.00}%", ApplyFormatInEditMode = true)]
        public double Below50kProp { get { return below50k; } set { below50k = value; } }

    }
}
