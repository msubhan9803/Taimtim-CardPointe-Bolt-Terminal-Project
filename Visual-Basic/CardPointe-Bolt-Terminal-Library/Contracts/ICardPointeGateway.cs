using CardPointe_Bolt_Terminal_Library.Dtos;
using RestSharp;

namespace CardPointe_Bolt_Terminal_Library.Contracts
{
    interface ICardPointeGateway
    {
        IRestResponse AuthorizationRequest(AuthorizationRequestDto request);
        IRestResponse RefundRequest(RefundRequestDto request);
    }
}
