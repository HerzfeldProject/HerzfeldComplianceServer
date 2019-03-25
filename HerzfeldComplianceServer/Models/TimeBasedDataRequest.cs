using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class TimeBasedDataRequest
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<string> departmentsList { get; set; }
        public List<int> patientsList { get; set; }
        public stage stage;

        // add object for score + list of data instances for later drill down

        public void getData()
        {
            //TODO
            //post request to mediator and calculate final score and return.
            //score should be returned for each action in stage and also final score for whole stage

            //create scores object and for each property calculate-
            //getData from mediator for all the patients together for each action in the given stage
            //Get back list of dataInstance - create a model like in the mediator
            //for each data instance calculate score based on time span and get average of all together using weights.
        }
    }
}