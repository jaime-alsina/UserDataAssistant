using DisruptionWorks.Email.Service;
using DisruptionWorks.Model.Request;
using DisruptionWorks.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DisruptionWorks.AssistantRelay.Controllers
{
    [Route("/")]
    //[Route("api/[controller]")]
    [ApiController]
    public class AssistantController : ControllerBase
    {
        private readonly IEmailService _mailService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AssistantController> _logger;

        public AssistantController(IEmailService mailService, ILogger<AssistantController> logger, IConfiguration configuration)
        {
            _mailService = mailService;
            _logger = logger;
            _configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInformation("AssistantController Get was called");

            return new[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public async Task<HttpResponseMessage> Post(AssistantRequest request)
        {
            var ret = new HttpResponseMessage(HttpStatusCode.OK);
            try
            {
                _logger.LogInformation("About to send email");
                await _mailService.SendEmail(request.QueryResult.QueryText);

                var resp = new SimpleResponse()
                {
                    Source = request.OriginalDetectIntentRequest.Source,
                    FulfillmentText = _configuration["App:FulfillmentText"]
                };

                var json = JsonConvert.SerializeObject(resp, Formatting.None);
                ret.Content = new StringContent(json, Encoding.UTF8);

            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }
            return ret;
        }

    }
}
