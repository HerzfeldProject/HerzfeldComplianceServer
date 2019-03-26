using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class AdmissionScores : StageScores
    {
        public double albumin { get; set; } //אלבומין
        public double nutrition { get; set; } //תזונה
        public double pain { get; set; } //אמדן כאב
        public double norton { get; set; } //אמדן נורטון
        public double skin { get; set; } //אמדן עור

        public void calculateTotalStageScore()
        {
            totalStageScores = albumin * PatternConsts.ADMISSION_ALBUMIN_WEIGHT +
                               nutrition * PatternConsts.ADMISSION_NUTRITION_WEIGHT +
                               pain * PatternConsts.ADMISSION_PAIN_WEIGHT +
                               norton * PatternConsts.ADMISSION_NORTON_WEIGHT +
                               skin * PatternConsts.ADMISSION_SKIN_WEIGHT; 
        }
    }
}