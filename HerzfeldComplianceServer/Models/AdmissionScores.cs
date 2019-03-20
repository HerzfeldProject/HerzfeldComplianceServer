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
        public double ulcerDiagnosis { get; set; } //אבחנת פצע לחץ
    }
}