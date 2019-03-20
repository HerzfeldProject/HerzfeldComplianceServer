using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class PreventionScores : StageScores
    {
        public double skin { get; set; } //אמדן עור
        public double pain { get; set; } //אמדן כאב
        public double skinInstruction { get; set; } //הוראה לאמדן עור
        public double guidance { get; set; } // הדרכה
        public double norton { get; set; } //אמדן נורטון
        public double changePosition { get; set; } // שינוי תנוחה
        public double angle { get; set; } //השכבה בזווית 30 מעלות
        public double pressureDiffusion { get; set; } //שימוש באמצעים לפיזור לחץ
        public double dietConsultation { get; set; } //ייעוץ דיאטנית
        public double oilTreatment { get; set; } //טיפול בשימון
    }
}