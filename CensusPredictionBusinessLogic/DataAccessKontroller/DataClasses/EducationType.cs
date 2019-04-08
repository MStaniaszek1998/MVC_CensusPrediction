using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class EducationType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idEducation;
        private string education;

        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        public int IdEducation
        {
            get { return idEducation; }
            set { idEducation = value; }
        }

    }
}
