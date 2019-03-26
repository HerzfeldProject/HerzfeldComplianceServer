using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class StageScores
    {
        public double totalStageScores { get; set; }
        public StageScores initByStage(stage stage);
    }
}