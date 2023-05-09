using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class TimerTriggerFunction
    {
        [FunctionName("TimerTriggerFunction")]
        public void Run(
            [TimerTrigger("0/15 * * * * *")] //entra a cada 15seg
            TimerInfo myTimer, 
            ILogger log
            ) 

        {
            log.LogInformation($"Function lanzada por el TIMER TRIGGER --> {DateTime.Now}");
        }
    }
}
