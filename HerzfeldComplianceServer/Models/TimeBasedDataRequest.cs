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
        public stage stage;

        public void getData()
        {
            //TODO
            //post request to mediator and calculate final score and return.
            //score should be returned for each action in stage and also final score for whole stage
        }
    }
}