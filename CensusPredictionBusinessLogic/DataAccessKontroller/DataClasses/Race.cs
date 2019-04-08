using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class Races
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idRace;
        private string race;

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public int IdRace
        {
            get { return idRace; }
            set { idRace = value; }
        }

    }
}
