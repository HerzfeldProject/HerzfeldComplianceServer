using HerzfeldComplianceServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HerzfeldComplianceServer.Controllers
{
    public class PatientBaseDataController : ApiController
    {
        // POST api/patientBaseData
        public string Post([FromBody] PatientBaseDataRequest patientBaseData)
        {
            patientBaseData.getData();
            return "ok";
        }
    }
}
