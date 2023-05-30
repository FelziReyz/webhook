using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TBMS_WebHook.Handler
{
    public class Handler : WebHookHandler
    {

        public Handler()
        {
            this.Receiver = "genericjson";// CustomWebHookReceiver.ReceiverName; //"custom";
        }

    

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            // Get data from WebHook
            CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();
            JObject data1 = context.GetDataOrDefault<JObject>();
            // Get data from each notification in this WebHook
            foreach (IDictionary<string, object> notification in data.Notifications)
            {
                // Process data
            }

            return Task.FromResult(data1);
        }
    }
}