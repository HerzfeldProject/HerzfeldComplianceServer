using HerzfeldComplianceServer.Models;
using System.Web.Http;


namespace HerzfeldComplianceServer.Controllers
{
    public class TimeBasedController : ApiController
    {
        // POST api/patientBaseData
        public TimeBasedDataRequest Post([FromBody] TimeBasedDataRequest timeBasedData)
        {
            timeBasedData.getData(); //should return an object and then this object should be converted to json and returned.                                  
            return timeBasedData;
        }
    }
}
