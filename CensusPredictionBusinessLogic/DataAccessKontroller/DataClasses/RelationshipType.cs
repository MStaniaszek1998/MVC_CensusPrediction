using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic
{
    public class RelationshipType
    {
        //Class responsible for ORM mapping from the database using dapper
        private int idRelationship;
        private string relationship;

        public string Relationship
        {
            get { return relationship; }
            set { relationship = value; }
        }


        public int IdRelationship
        {
            get { return idRelationship; }
            set { idRelationship = value; }
        }

    }
}
