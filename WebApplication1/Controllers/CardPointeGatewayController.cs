using System;
using System.Web.Http;
using CardPointe_Bolt_Terminal_Library.Implementations;
using CardPointe_Bolt_Terminal_Library.Dtos;

namespace WebApplication1.Controllers
{
    public class CardPointeGatewayController : ApiController
    {
        private CardPointeGateway _cardPointeBoltTerminal;
        private AuthorizationRequestDto _authorizationRequestDto;
        private RefundRequestDto _refundRequestDto;

        public CardPointeGatewayController(CardPointeGateway cardPointeGateway,
            AuthorizationRequestDto authorizationRequestDto,
            RefundRequestDto refundRequestDto)
        {
            _cardPointeBoltTerminal = cardPointeGateway;
            _authorizationRequestDto = authorizationRequestDto;
            _refundRequestDto = refundRequestDto;
        }

        [HttpPost]
        public IHttpActionResult Authorization()
        {
            var obj = _authorizationRequestDto;
            obj.authorizationBody.account = "0012";

            var result = _cardPointeBoltTerminal.AuthorizationRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Refund()
        {
            var obj = _refundRequestDto;
            obj.refundHeaders.Authorization = "fdsafj2l3jl42j34";

            var result = _cardPointeBoltTerminal.RefundRequest(obj);
            Console.WriteLine("response: ", arg0: result);
            if (result == null)
            {
                return BadRequest("Oops something went wrongQ");
            }
            return Ok(result);
        }
    }
}
