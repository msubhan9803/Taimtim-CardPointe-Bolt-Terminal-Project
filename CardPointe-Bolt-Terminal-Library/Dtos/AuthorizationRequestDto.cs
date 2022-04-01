using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class AuthorizationRequestDto
    {
        public AuthorizationHeaders authorizationHeaders { get; set; }
        public AuthorizationBody authorizationBody { get; set; }
    }

    public class AuthorizationHeaders
    {
        public string Authorization { get; set; }
    }

    public class AuthorizationBody
    {
        public string merchid { get; set; }
        public string amount { get; set; }
        public string expiry { get; set; }
        public string account { get; set; }
        public string postal { get; set; }
        public string cvv2 { get; set; }
        public string ecomind { get; set; }
        public string cof { get; set; }
        public string cofpermission { get; set; }
        public string cofscheduled { get; set; }
        public string currency { get; set; }
        public string bankaba { get; set; }
        public string track { get; set; }
        public string receipt { get; set; }
        public string bin { get; set; }
        public string profile { get; set; }
        public string auoptout { get; set; }
        public string capture { get; set; }
        public string tokenize { get; set; }
        public string signature { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string orderid { get; set; }
        public string authcode { get; set; }
        public string taxexempt { get; set; }
        public string taxamnt { get; set; }
        public string termid { get; set; }
        public string accttype { get; set; }
    }
}
