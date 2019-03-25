using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class PatientBaseDataRequest
    {
        public List<string> patientsList { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<string> departmentsList { get; set; } 
        public stage stage { get; set; }

        public void getData()
        {
            //TODO
            //create object for scores.
            //for each action in stage
            //get data from mediator for all the patients together.
           //loop over the data instances and caluclate average for each patient sepeartely (with weights) and at the end calc average of all patients scores.
           //when looping over the data insatnces remember to filter by start and end date
        }
    }
}