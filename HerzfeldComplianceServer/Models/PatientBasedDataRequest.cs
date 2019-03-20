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
        }
    }
}