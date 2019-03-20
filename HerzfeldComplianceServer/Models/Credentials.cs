using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HerzfeldComplianceServer.Models
{
    public class Credentials
    {
        public string username { get; set; }
        public string password { get; set; }

        public bool verify()
        {
            return true;
        }
    }
}