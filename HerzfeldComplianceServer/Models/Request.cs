using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class Request
    {
       
        public List<DataInstance> getDataFromMediator(List<string> patientsList, string patternId)
        {
            throw new NotImplementedException();
        }

        public List<List<DataInstance>> getAdmissionData(List<string> patientsList, DateTime startDate, DateTime endDate)
        {
            List<List<DataInstance>> dataInstancesLists = new List<List<DataInstance>>();
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.ADMISSION_ALBUMIN_PATTERN_ID)));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.ADMISSION_NUTRITION_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.ADMISSION_PAIN_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.ADMISSION_NORTON_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.ADMISSION_SKIN_PATTERN_ID));
            filterByTimeSpan(dataInstancesLists, startDate, endDate);
            return dataInstancesLists;
        }

        public List<List<DataInstance>> getPreventionData(List<string> patientsList, DateTime startDate, DateTime endDate)
        {
            List<List<DataInstance>> dataInstancesLists = new List<List<DataInstance>>();
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_SKIN_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_PAIN_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_SKIN_INSTRUCTION_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_GUIDANCE_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_NORTON_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_CHANGE_POSITION_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_ANGLE_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_PRESSURE_DIFFUSION_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_DIET_CONSULTATION_PATTERN_ID));
            dataInstancesLists.Add(getDataFromMediator(patientsList, PatternConsts.PREVENTION_OIL_TREATMENT_PATTERN_ID));
            filterByTimeSpan(dataInstancesLists, startDate, endDate);
            return dataInstancesLists;
        }

        public void filterByTimeSpan(List<List<DataInstance>> dataInstancesLists, DateTime startDate, DateTime endDate)
        {
            foreach (List<DataInstance> dataInstancesList in dataInstancesLists)
            {
                foreach (DataInstance dataInstance in dataInstancesList)
                {
                    if (!(dataInstance.StartTime >= startDate && dataInstance.EndTime <= endDate))
                    {
                        dataInstancesList.Remove(dataInstance);
                    }
                }
            }
        }
    }
}