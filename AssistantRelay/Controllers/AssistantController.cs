using Email.Service;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AssistantRelay.Controllers
{
    [Route("/")]
    //[Route("api/[controller]")]
    [ApiController]
    public class AssistantController : ControllerBase
    {

        private readonly IEmailService _mailService;
        private readonly ILogger<AssistantController> _logger;

        public AssistantController(IEmailService mailService, ILogger<AssistantController> logger)
        {
            _mailService = mailService;
            _logger = logger;
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
        public async Task<ResponseBasic> Post(AssistantRequest request)
        {
            var response = new ResponseBasic
            {
                source = request.OriginalDetectIntentRequest.Source,
                fulfillmentText = request.QueryResult.FulfillmentText
            };

            try
            {
                _logger.LogInformation("About to send email");
                await _mailService.SendEmail(request.QueryResult.QueryText);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }

            return response;


        }

    }
}
