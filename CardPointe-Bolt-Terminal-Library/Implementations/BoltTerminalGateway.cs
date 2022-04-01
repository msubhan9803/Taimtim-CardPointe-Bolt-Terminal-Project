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
                var requestObj = new RestRequest(Method.POST);
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", "Basic " + request.disconnectHeaders.Authorization);
                var body = request.disconnectBody;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
                requestObj.AddParameter("application/json",JsonConvert.SerializeObject(body), ParameterType.RequestBody);
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
                var requestObj = new RestRequest(Method.POST);
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", "Basic " + request.authCardHeaders.Authorization);
                var body = request.authCardBody;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
                requestObj.AddParameter("application/json",JsonConvert.SerializeObject(body), ParameterType.RequestBody);
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
