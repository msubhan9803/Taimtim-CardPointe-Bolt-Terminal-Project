using System;
using System.Configuration;
using System.Web.Http;
using CardPointe_Bolt_Terminal_Library.Implementations;
using CardPointe_Bolt_Terminal_Library.Dtos;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class BoltTerminalGatewayController : ApiController
    {
        private BoltTerminalGateway _boltTerminalGateway;

        public BoltTerminalGatewayController()
        {
            _boltTerminalGateway = new BoltTerminalGateway();
        }

        [HttpPost]
        public IHttpActionResult Ping()
        {
            string sessionKey = ConfigurationManager.AppSettings.GetValues("X-CardConnect-SessionKey")[0];
            string authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization")[0];
            string merchantId = ConfigurationManager.AppSettings.GetValues("merchantId")[0];
            string hsn = ConfigurationManager.AppSettings.GetValues("hsn")[0];

            var obj = new PingRequestDto
            {
                pingHeaders =
                {
                    Authorization = authorization,
                    XCardConnectSessionKey = sessionKey
                },
                pingBody =
                {
                    merchantId = merchantId,
                    hsn = hsn
                }
            };

            var result = _boltTerminalGateway.PingRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }

        [HttpPost]
        public IHttpActionResult Connect()
        {
            string authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization")[0];
            string merchantId = ConfigurationManager.AppSettings.GetValues("merchantId")[0];
            string hsn = ConfigurationManager.AppSettings.GetValues("hsn")[0];

            var obj = new ConnectRequestDto
            {
                connectHeaders =
                {
                    Authorization = authorization
                },
                connectBody =
                {
                    merchantId = merchantId,
                    hsn = hsn,
                    force = "true"
                }
            };

            var result = _boltTerminalGateway.ConnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }

        [HttpPost]
        public IHttpActionResult Disconnect()
        {
            string sessionKey = ConfigurationManager.AppSettings.GetValues("X-CardConnect-SessionKey")[0];
            string authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization")[0];
            string merchantId = ConfigurationManager.AppSettings.GetValues("merchantId")[0];
            string hsn = ConfigurationManager.AppSettings.GetValues("hsn")[0];

            var obj = new DisconnectRequestDto
            {
                disconnectHeaders =
                {
                    Authorization = authorization,
                    XCardConnectSessionKey = sessionKey
                },
                disconnectBody =
                {
                    merchantId = merchantId,
                    hsn = hsn
                }
            };

            var result = _boltTerminalGateway.DisconnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }

        [HttpPost]
        public IHttpActionResult AuthCard()
        {
            string sessionKey = ConfigurationManager.AppSettings.GetValues("X-CardConnect-SessionKey")[0];
            string authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization")[0];
            string merchantId = ConfigurationManager.AppSettings.GetValues("merchantId")[0];
            string hsn = ConfigurationManager.AppSettings.GetValues("hsn")[0];

            var obj = new AuthCardRequestDto
            {
                authCardHeaders =
                {
                    Authorization = authorization,
                    XCardConnectSessionKey = sessionKey
                },
                authCardBody =
                {
                    merchantId = merchantId,
                    hsn = hsn,
                    amount = "100",
                    includeSignature = "false",
                    includeAmountDisplay = "true",
                    beep = "true",
                    aid = "credit",
                    includeAVS = "true",
                    capture = "true",
                    orderId = "NCC1701D",
                    userFields = {
                        UDF1 = "Jean-Luc Picard",
                        UDF2 = "47AT"
                    },
                    clearDisplayDelay = "500"
                }
            };

            var result = _boltTerminalGateway.AuthCardRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(JsonConvert.DeserializeObject(result.Content));
        }
    }
}
