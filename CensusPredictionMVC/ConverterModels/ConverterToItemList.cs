using CensusPredictionBusinessLogic;
using CensusPredictionBusinessLogic.DataAccessKontroller;
using CensusPredictionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CensusPredictionMVC.ConverterModels
{
    public static  class ConverterToItemList
    {
        static List<EducationType> eduList;
        static List<States> states;
        static List<MartialStatusType> martialStatuses;
        static  List<ModelPredict> modelPredicts;
        static List<OccupationType> occupationTypes;
        static List<Races> races;
        static List<RelationshipType> relationshipTypes;
        static List<SexType> sexTypes;
        static List<WorkClassType> workClassTypes;
        private  static DataAccess access = new DataAccess();
        public static double above50k;
        public static double below50k;
        public static List<SelectListItem> workClassTypesDownload()
        {

            List<SelectListItem> items = workClassTypes.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.WorkClass,
                    Value = item.IdWorkClass.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public static void PredictScore(PersonToPredictModel userPredict)
        {
            CensusPredictionBusinessLogic.DataAccessKontroller.DataClasses.PersonToPredict toPredict = new CensusPredictionBusinessLogic.DataAccessKontroller.DataClasses.PersonToPredict()
            {
                Age = userPredict.Age,
                Capitalgain = userPredict.Capitalgain,
                educationNo = userPredict.educationNo,
                hourPerweek = userPredict.hourPerweek,
                idcountry = userPredict.idcountry,
                ideducation = userPredict.ideducation,
                idMartialStatus = userPredict.idMartialStatus,
                idOccupation = userPredict.idOccupation,
                idrace = userPredict.idrace,
                idrelationship = userPredict.idrelationship,
                idworkclass = userPredict.idworkclass,
                ifWoman = userPredict.ifWoman,
                modelName = userPredict.modelName
            };
            CensusPredictionBusinessLogic.DataAccessKontroller.PredictGetter getter = new PredictGetter(access, toPredict);
            List<PredictedScore> result = getter.GetPredictions();
            above50k = result[0].IncomeAbove50;
            below50k = result[0].IncomeBelow50;

        }
        public static List<SelectListItem> sexTypesTypesDownload()
        {

            List<SelectListItem> items = sexTypes.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.Sex,
                    Value = item.IdSex.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public static List<SelectListItem> relationshipTypesDownload()
        {

            List<SelectListItem> items = relationshipTypes.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.Relationship,
                    Value = item.IdRelationship.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public static List<SelectListItem> racesDownload()
        {

            List<SelectListItem> items = races.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.Race,
                    Value = item.IdRace.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public static List<SelectListItem> occupationTypesDownload()
        {

            List<SelectListItem> items = occupationTypes.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.Occupation,
                    Value = item.IdOccupation.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public static List<SelectListItem> modelPredictsDownload()
        {

            List<SelectListItem> items = modelPredicts.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.NameAndScore,
                    Value = item.ModelName,
                    Selected = false
                };
            });
            return items;
        }
        public static List<SelectListItem> martialStatusesDownload()
        {

            List<SelectListItem> items = martialStatuses.ConvertAll(item =>
            {
                return new SelectListItem()
                {
                    Text = item.MartialStatus,
                    Value = item.IdMartialStatus.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public  static List<SelectListItem> EduListDownload()
        {
            
            List<SelectListItem> items = eduList.ConvertAll(Edu =>
            {
                return new SelectListItem()
                {
                    Text = Edu.Education,
                    Value = Edu.IdEducation.ToString(),
                    Selected = false
            };
            });
            return items;
        }
        public static List<SelectListItem> StatesListDownload()
        {

            List<SelectListItem> items = states.ConvertAll(Country =>
            {
                return new SelectListItem()
                {
                    Text = Country.Country,
                    Value = Country.IdCountry.ToString(),
                    Selected = false
                };
            });
            return items;
        }
        public   static void  DownloadType()
        {
            EducationTypeGetter getter = new EducationTypeGetter(access);
            eduList =  getter.GetEducationTypes();
            CountryGettercs countryGettercs = new CountryGettercs(access);
            states =  countryGettercs.GetCountries();
            MartialStatusTypeGetter martialStatusTypeGetter = new MartialStatusTypeGetter(access);
             martialStatuses =  martialStatusTypeGetter.GetMartialStatusType();
            ModelTypesGetter modelTypesGetter = new ModelTypesGetter(access);
             modelPredicts =  modelTypesGetter.GetModelTypes();
            OccupationTypesGetter occupationTypesGetter = new OccupationTypesGetter(access);
            occupationTypes =  occupationTypesGetter.GetOccupationTypes();
            RacesGettercs racesGettercs = new RacesGettercs(access);
             races =  racesGettercs.GetRaces();
            RelationshipTypeGettercs relationshipTypeGettercs = new RelationshipTypeGettercs(access);
            relationshipTypes =  relationshipTypeGettercs.GetRelationshipTypes();
            SexGetter sexGetter = new SexGetter(access);
            sexTypes =  sexGetter.GetSexs();
            WorkClassTypeGetter workClassTypeGetter = new WorkClassTypeGetter(access);
            workClassTypes =  workClassTypeGetter.GetWorkClassTypes();

        }
    }
}