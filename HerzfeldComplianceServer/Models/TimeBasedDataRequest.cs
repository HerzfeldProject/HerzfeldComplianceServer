using System;
using System.Collections.Generic;

namespace HerzfeldComplianceServer.Models
{
    public class TimeBasedDataRequest : Request
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<string> departmentsList { get; set; }
        public List<string> patientsList { get; set; }
        public stage stage;

        // add object for score + list of data instances for later drill down

        public void getData()
        {
            //TODO
            //post request to mediator and calculate final score and return.
            //score should be returned for each action in stage and also final score for whole stage

            //create scores object and for each property calculate
            //getData from mediator for all the patients together for each action in the given stage
            //Get back list of dataInstance - create a model like in the mediator and filter by start and end date
            //for each data instance calculate score based on time span (proportional) and get average of all together using weights.
            switch(stage)
            {
                case stage.Admission:
                    getAdmissionScores();
                    break;
                case stage.Prevention:
                    getPreventionScores();
                    break;

            }
         
        }

        public void getAdmissionScores()
        {
            List<List<DataInstance>> dataInstancesLists = getAdmissionData(patientsList, startDate, endDate);
            AdmissionScores scores = new AdmissionScores();
            scores.albumin = calculateScoreBinary(dataInstancesLists[0]);
            scores.nutrition = calculateScoreBinary(dataInstancesLists[1]);
            scores.pain = calculateScoreBinary(dataInstancesLists[2]);
            scores.norton = calculateScoreBinary(dataInstancesLists[3]);
            scores.skin = calculateScoreBinary(dataInstancesLists[4]);
            scores.calculateTotalStageScore();
        }

        //TODO SPECIAL CALC FOR PERIODIC ACTIONS - BY TIMESPAN TAKE PROPORTIONATE VALUE.
        public void getPreventionScores()
        {
            List<List<DataInstance>> dataInstancesLists = getPreventionData(patientsList, startDate, endDate);
            PreventionScores scores = new PreventionScores();
            scores.skin = calculateScoreBinary(dataInstancesLists[0]);
            scores.pain = calculateScoreBinary(dataInstancesLists[1]);
            scores.skinInstruction = calculateScoreBinary(dataInstancesLists[2]);
            scores.guidance = calculateScoreBinary(dataInstancesLists[3]);
            scores.norton = calculateScoreBinary(dataInstancesLists[4]);
            scores.changePosition = calculateScoreBinary(dataInstancesLists[5]);
            scores.angle = calculateScoreBinary(dataInstancesLists[6]);
            scores.pressureDiffusion = calculateScoreBinary(dataInstancesLists[7]);
            scores.dietConsultation = calculateScoreBinary(dataInstancesLists[8]);
            scores.oilTreatment = calculateScoreBinary(dataInstancesLists[9]);
            scores.calculateTotalStageScore();
        }

        public double calculateScoreBinary(List<DataInstance> dataInstances)
        {
            int sum = 0;
            foreach (DataInstance dataInstance in dataInstances)
            {
                Int32.TryParse(dataInstance.Value, out int val);
                sum += val;
            }
            return sum / dataInstances.Count;
        }
        
    }
}