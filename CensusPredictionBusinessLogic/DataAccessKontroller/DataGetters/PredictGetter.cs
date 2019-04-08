using CensusPredictionBusinessLogic.DataAccessKontroller.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensusPredictionBusinessLogic.DataAccessKontroller
{
   public  class PredictGetter
    {
        //Class for exectuing prediction with given instance to predict
        string sql = "exec SendSex";
        DataAccess myAccess;
        public PredictGetter(DataAccess data, PersonToPredict predict)
        {
            myAccess = data;
            sql = $"EXEC PredictSingleIncome @model='{predict.modelName}', @Age ={predict.Age}, @EducationNum={predict.educationNo}, @CapitalGain={predict.Capitalgain}, @hoursPerWeek={predict.hourPerweek}, @IdWorkClass={predict.idworkclass}, @IdEducation={predict.ideducation}, @IdMartialStatus={predict.idMartialStatus}, @IdOccupation={predict.idOccupation}, @IdRelationship={predict.idrelationship}, @IdRace={predict.idrace}, @IdCountry={predict.idcountry}, @IFWoman={predict.ifWoman}";
        }
        public  List<PredictedScore> GetPredictions()
        {
            List<PredictedScore> works =  myAccess.GetData<PredictedScore>(sql).ToList();
            return works;
        }
    }
}
