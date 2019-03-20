using HerzfeldComplianceServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HerzfeldComplianceServer.Controllers
{
    public class AuthenticationController : ApiController
    {
        // POST api/authentication
        public IHttpActionResult Post([FromBody]Credentials credentials)
        {
            if (credentials.verify())
            {
                return Ok("Credentials verified");
            } else
            {
                return Unauthorized();
            }
        }
    }
}
