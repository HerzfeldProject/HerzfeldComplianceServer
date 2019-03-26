using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class PatternConsts
    {
        /// <summary>
        /// ADMISSION PATTERN IDS
        /// </summary>
        public const string ADMISSION_ALBUMIN_PATTERN_ID = ""; 
        public const string ADMISSION_NUTRITION_PATTERN_ID = ""; 
        public const string ADMISSION_PAIN_PATTERN_ID = ""; 
        public const string ADMISSION_NORTON_PATTERN_ID = ""; 
        public const string ADMISSION_SKIN_PATTERN_ID = ""; 

        /// <summary>
        /// ADMISSION WEIGHTS
        /// TODO: GET UPDATED WEIGHTS! THIS SUMS TO 90.
        /// </summary>
        public const double ADMISSION_ALBUMIN_WEIGHT = 0.12;
        public const double ADMISSION_NUTRITION_WEIGHT = 0.22;
        public const double ADMISSION_PAIN_WEIGHT = 0.12;
        public const double ADMISSION_NORTON_WEIGHT = 0.27;
        public const double ADMISSION_SKIN_WEIGHT = 0.27;

        /// <summary>
        /// PREVENTION PATTERN IDS
        /// </summary>
        public const string PREVENTION_SKIN_PATTERN_ID = "";
        public const string PREVENTION_PAIN_PATTERN_ID = "";
        public const string PREVENTION_SKIN_INSTRUCTION_PATTERN_ID = "";
        public const string PREVENTION_GUIDANCE_PATTERN_ID = "";
        public const string PREVENTION_NORTON_PATTERN_ID = "";
        public const string PREVENTION_CHANGE_POSITION_PATTERN_ID = "";
        public const string PREVENTION_ANGLE_PATTERN_ID = "";
        public const string PREVENTION_PRESSURE_DIFFUSION_PATTERN_ID = "";
        public const string PREVENTION_DIET_CONSULTATION_PATTERN_ID = "";
        public const string PREVENTION_OIL_TREATMENT_PATTERN_ID = "";
        
        /// <summary>
        /// PREVENTION WEIGHTS
        /// </summary>
        public const double PREVENTION_SKIN_WEIGHT = 0.1;
        public const double PREVENTION_PAIN_WEIGHT = 0; ///???????
        public const double PREVENTION_SKIN_INSTRUCTION_WEIGHT = 0.1;
        public const double PREVENTION_GUIDANCE_WEIGHT = 0.05;
        public const double PREVENTION_NORTON_WEIGHT = 0.1;
        public const double PREVENTION_CHANGE_POSITION_WEIGHT = 0.2;
        public const double PREVENTION_ANGLE_WEIGHT = 0.15;
        public const double PREVENTION_PRESSURE_DIFFUSION_WEIGHT = 0.1;
        public const double PREVENTION_DIET_CONSULTATION_WEIGHT =0.1;
        public const double PREVENTION_OIL_TREATMENT_WEIGHT = 0.1;

    }
}