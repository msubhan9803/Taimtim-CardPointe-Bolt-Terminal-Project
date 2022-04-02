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
                var requestObj = new RestRequest();
                requestObj.Method = Method.PUT;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", "Basic " + request.authorizationHeaders.Authorization);
                requestObj.AddJsonBody(request.authorizationBody);

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
                var requestObj = new RestRequest();
                requestObj.Method = Method.PUT;
                requestObj.AddHeader("Content-Type", "application/json");
                requestObj.AddHeader("Authorization", "Basic " + request.refundHeaders.Authorization);
                requestObj.AddJsonBody(request.refundBody);

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
