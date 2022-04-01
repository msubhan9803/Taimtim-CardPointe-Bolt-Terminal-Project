using System;
using System.Configuration;
using System.Web.Http;
using CardPointe_Bolt_Terminal_Library.Implementations;
using CardPointe_Bolt_Terminal_Library.Dtos;

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
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Connect()
        {
            var obj = new ConnectRequestDto();
            obj.connectBody.merchantId = "0012";

            var result = _boltTerminalGateway.ConnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Disconnect()
        {
            var obj = new DisconnectRequestDto();
            obj.disconnectBody.merchantId = "0012";

            var result = _boltTerminalGateway.DisconnectRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AuthCard()
        {
            var obj = new AuthCardRequestDto();
            obj.authCardBody.merchantId = "0012";

            var result = _boltTerminalGateway.AuthCardRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }
    }
}
