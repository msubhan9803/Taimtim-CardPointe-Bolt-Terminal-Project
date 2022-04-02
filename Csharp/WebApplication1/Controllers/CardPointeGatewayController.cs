using System;
using System.Configuration;
using System.Web.Http;
using CardPointe_Bolt_Terminal_Library.Implementations;
using CardPointe_Bolt_Terminal_Library.Dtos;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class CardPointeGatewayController : ApiController
    {
        private CardPointeGateway _cardPointeBoltTerminal;

        public CardPointeGatewayController()
        {
            _cardPointeBoltTerminal = new CardPointeGateway();
        }

        [HttpPost]
        public IHttpActionResult Authorization()
        {
            string authorization = ConfigurationManager.AppSettings.GetValues("CardPointe-Authorization")[0];
            string merchid = ConfigurationManager.AppSettings.GetValues("merchantId")[0];

            var obj = new AuthorizationRequestDto
            {
                authorizationHeaders =
                {
                    Authorization = authorization
                },
                authorizationBody =
                {
                    merchid = merchid,
                    account = "",
                    expiry = "{Card expiration nnnn}",
                    amount = "",
                    currency = "USD",
                    name = "CC TEST"
                }
            };

            var result = _cardPointeBoltTerminal.AuthorizationRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }

        [HttpPost]
        public IHttpActionResult Refund()
        {
            string authorization = ConfigurationManager.AppSettings.GetValues("CardPointe-Authorization")[0];
            string merchid = ConfigurationManager.AppSettings.GetValues("merchantId")[0];
            
            var obj = new RefundRequestDto
            {
                refundHeaders =
                {
                    Authorization = authorization
                },
                refundBody =
                {
                    merchid = merchid,
                    retref = "092584130137"
                }
            };

            var result = _cardPointeBoltTerminal.RefundRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }
    }
}
