using System;
using RestSharp;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using CardPointe_Bolt_Terminal_Library.Contracts;
using CardPointe_Bolt_Terminal_Library.Dtos;

namespace CardPointe_Bolt_Terminal_Library.Implementations
{
    public class CardPointeGateway : ICardPointeGateway
    {
        public IRestResponse AuthorizationRequest(AuthorizationRequestDto request)
        {
            try
            {
                var client = new RestClient("https://fts-uat.cardconnect.com/cardconnect/rest/auth");
                client.Timeout = -1;
                var requestObj = new RestRequest(Method.PUT);
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", "Basic " + request.authorizationHeaders.Authorization);
                var body = request.authorizationBody;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
                requestObj.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(requestObj);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IRestResponse RefundRequest(RefundRequestDto request)
        {
            try
            {
                var client = new RestClient("https://fts-uat.cardconnect.com/cardconnect/rest/refund");
                client.Timeout = -1;
                var requestObj = new RestRequest(Method.PUT);
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", request.refundHeaders.Authorization);
                var body = request.refundBody;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
                requestObj.AddParameter("application/json", body, ParameterType.RequestBody);
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
