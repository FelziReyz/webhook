using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TBMS_WebHook.Controller
{
    public class WebHookController : ApiController
    {
        public string Get()
        {
            return "Im On...";
        }
    }
}
