using Microsoft.AspNet.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TBMS_WebHook.Handler
{
    public class QueueHandler : WebHookQueueHandler
    {
        public override Task EnqueueAsync(WebHookQueueContext context)
        {

            // Enqueue WebHookQueueContext to your queuing system of choice

            return Task.FromResult(true);
        }
    }
}