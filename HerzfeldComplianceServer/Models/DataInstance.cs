using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class DataInstance
    {
        public int EntityId { get; set; }//patient

        public string ConceptName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Value { get; set; } //score
    }
}