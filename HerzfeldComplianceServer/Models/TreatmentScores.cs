using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class TreatmentScores
    {
        public double pain { get; set; } //אמדן כאב
        public double ulcer { get; set; } //אמדן פצע
        public double skinInstruction { get; set; } //הוראה לאמדן עור
        public double skin { get; set; } // אמדן עור
        public double nurseOrDoctor { get; set; } // ביקור עם רופא ואחות
        public double diagnosisDocumentation { get; set; } // רישום אבחנה
        public double reportToDoctor { get; set; } // דיווח לרופא
    }
}