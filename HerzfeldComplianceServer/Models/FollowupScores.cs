using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class FollowupScores : StageScores
    {
        public double skin { get; set; }
        public double norton { get; set; }
        public double pain { get; set; }
        //add scores for teud, bitzua, horaa according to patterns data file
    }
}