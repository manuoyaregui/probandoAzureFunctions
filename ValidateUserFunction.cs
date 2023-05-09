using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp1
{
    public static class ValidateUserFunction
    {
        [FunctionName("ValidateUserFunction")]
        public static async Task<IActionResult> Run
        (
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] 
            HttpRequest req, ILogger log
        )

        {
            log.LogInformation("Request called to validate user");
            
            
            string defUser = "Manuel";
            string defPass = "pass";



            //Leo los parametros del body
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            string userName = data?.user;
            string userPass = data?.pass;



            bool isValid = userName == defUser && userPass == defPass;

            string responseMessage = isValid
                ? $"The user {userName} is Valid"
                : $"The validation went wrong, check name and pass. \n Data --> {userName} - {userPass}";

            return new OkObjectResult(responseMessage);
        }
    }
}
