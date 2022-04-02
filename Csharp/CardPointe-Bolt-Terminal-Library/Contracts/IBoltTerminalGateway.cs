using System;
using CardPointe_Bolt_Terminal_Library.Dtos;
using RestSharp;

namespace CardPointe_Bolt_Terminal_Library.Contracts
{
    interface IBoltTerminalGateway
    {
        IRestResponse PingRequest(PingRequestDto request);
        IRestResponse ConnectRequest(ConnectRequestDto request);
        IRestResponse AuthCardRequest(AuthCardRequestDto request);
        IRestResponse DisconnectRequest(DisconnectRequestDto request);
    }
}