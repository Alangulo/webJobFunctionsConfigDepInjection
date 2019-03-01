using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace injectiontest3
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.

       
        public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        {
           // executionContext.GetSection("testing");
            var test = Program.Configuration;
            log.WriteLine("test");
         
            // logger.LogInformation($"{message}\n{executionContext.InvocationId}");
        }



    }
}
