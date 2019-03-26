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

        public void calculateTotalStageScore()
        {
            totalStageScores = skin * PatternConsts.PREVENTION_SKIN_WEIGHT +
                               pain * PatternConsts.PREVENTION_PAIN_WEIGHT +
                               skinInstruction * PatternConsts.PREVENTION_SKIN_INSTRUCTION_WEIGHT +
                               guidance * PatternConsts.PREVENTION_GUIDANCE_WEIGHT +
                               norton * PatternConsts.PREVENTION_NORTON_WEIGHT +
                               changePosition * PatternConsts.PREVENTION_CHANGE_POSITION_WEIGHT +
                               angle * PatternConsts.PREVENTION_ANGLE_WEIGHT +
                               pressureDiffusion * PatternConsts.PREVENTION_PRESSURE_DIFFUSION_WEIGHT +
                               dietConsultation * PatternConsts.PREVENTION_DIET_CONSULTATION_WEIGHT +
                               oilTreatment * PatternConsts.PREVENTION_OIL_TREATMENT_WEIGHT;
                               
        }
    }
}