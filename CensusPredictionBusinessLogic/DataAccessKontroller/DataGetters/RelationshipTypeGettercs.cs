using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class RelationshipTypeGettercs
    {
        //Class for getting data of RelationshipTypes from the database
        string sql = "exec SendRelationShipType";
        DataAccess myAccess;
        public RelationshipTypeGettercs(DataAccess data)
        {
            myAccess = data;
        }
        public  List<RelationshipType> GetRelationshipTypes()
        {
            List<RelationshipType> works =  myAccess.GetData<RelationshipType>(sql).ToList();
            return works;
        }
    }
}
