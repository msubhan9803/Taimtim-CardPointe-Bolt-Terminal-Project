using System;
using RestSharp;
using System.Net;
using CardPointe_Bolt_Terminal_Library.Contracts;
using CardPointe_Bolt_Terminal_Library.Dtos;
using System.Text.Json;
using Newtonsoft.Json;

namespace CardPointe_Bolt_Terminal_Library.Implementations
{
    public class BoltTerminalGateway : IBoltTerminalGateway
    {
        public IRestResponse PingRequest(PingRequestDto request)
        {
            try
            {
                var client = new RestClient("https://bolt-uat.cardpointe.com/api/v1/ping");
                client.Timeout = -1;
                var requestObj = new RestRequest();
                requestObj.Method = Method.POST;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", request.pingHeaders.Authorization);
                requestObj.AddJsonBody(request.pingBody);

                IRestResponse response = client.Execute(requestObj);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IRestResponse ConnectRequest(ConnectRequestDto request)
        {
            try
            {
                var client = new RestClient("https://bolt-uat.cardpointe.com/api/v2/connect");
                client.Timeout = -1;
                var requestObj = new RestRequest();
                requestObj.Method = Method.POST;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", request.connectHeaders.Authorization);
                requestObj.AddJsonBody(request.connectBody);

                IRestResponse response = client.Execute(requestObj);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IRestResponse DisconnectRequest(DisconnectRequestDto request)
        {
            try
            {
                var client = new RestClient("https://bolt-uat.cardpointe.com/api/v2/disconnect");
                client.Timeout = -1;
                var requestObj = new RestRequest();
                requestObj.Method = Method.POST;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", request.disconnectHeaders.Authorization);
                requestObj.AddJsonBody(request.disconnectBody);

                IRestResponse response = client.Execute(requestObj);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IRestResponse AuthCardRequest(AuthCardRequestDto request)
        {
            try
            {
                var client = new RestClient("https://bolt-uat.cardpointe.com/api/v3/authCard");
                client.Timeout = -1;
                var requestObj = new RestRequest();
                requestObj.Method = Method.POST;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", request.authCardHeaders.Authorization);
                requestObj.AddJsonBody(request.authCardBody);

                IRestResponse response = client.Execute(requestObj);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
