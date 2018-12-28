using Email.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public async Task<HttpResponseMessage> Post(AssistantRequest request)
        {
            try
            {
                _logger.LogInformation("About to send email");
                await _mailService.SendEmail(request.QueryResult.QueryText);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }



            var resp = new SimpleResponse()
            {
                Source = request.OriginalDetectIntentRequest.Source,
                FulfillmentText = request.QueryResult.QueryText
            };

 

            var json = JsonConvert.SerializeObject(resp, Formatting.None);

            var ret = new HttpResponseMessage(HttpStatusCode.OK);
            ret.Content = new StringContent(json, Encoding.UTF8);
       

            //ConversationToken = request.OriginalDetectIntentRequest.Payload.Conversation.ConversationToken,
            //ExpectedInputs = new List<ExpectedInput>
            //{
            //    new ExpectedInput()
            //    {
            //        InputPrompt = new InputPrompt()
            //        {
            //            RichInitialPrompt = new RichInitialPrompt()
            //            {
            //                Items = new List<Item>()
            //                {
            //                    new Item()
            //                    {
            //                        SimpleResponse = new SimpleResponse()
            //                        {
            //                            TextToSpeech = request.QueryResult.FulfillmentText,
            //                            DisplayText = request.QueryResult.FulfillmentText
            //                        }
            //                    }
            //                },
            //                Suggestions = new List<object>()
            //            }
            //        },
            //        PossibleIntents = new List<PossibleIntent>(){ new PossibleIntent() { Intent = "actions.intent.TEXT" } }
            //    }
            //}

            // };

            return ret;
        }

    }
}
