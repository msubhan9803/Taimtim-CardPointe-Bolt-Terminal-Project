using System;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class AuthCardRequestDto
    {
        public AuthCardHeaders authCardHeaders { get; set; } = new AuthCardHeaders();
        public AuthCardBody authCardBody { get; set; } = new AuthCardBody();
    }

    public class AuthCardHeaders
    {
        public string Authorization { get; set; }
        public string XCardConnectSessionKey { get; set; }
    }

    public class AuthCardBody
    {
        public string merchantId { get; set; }
        public string hsn { get; set; }
        public string amount { get; set; }
        public string aid { get; set; }
        public string authCode { get; set; }
        public string authMerchantId { get; set; }
        public string bin { get; set; }
        public string beep { get; set; }
        public string capture { get; set; }
        public string clearDisplayDelay { get; set; }
        public string confirmAmount { get; set; }
        public string createProfile { get; set; }
        public string gzipSignature { get; set; }
        public string includeAmountDisplay { get; set; }
        public string includeAVS { get; set; }
        public string includePIN { get; set; }
        public string includeSignature { get; set; }
        public string invoiceId { get; set; }
        public string orderId { get; set; }
        public string printDelay { get; set; }
        public string printExtraReceipt { get; set; }
        public string printReceipt { get; set; }
        public string signatureDimensions { get; set; }
        public string signatureFormat { get; set; }
        public string signatureImageType { get; set; }
        public string termId { get; set; }
        public UserFields userFields { get; set; } = new UserFields();
    }

    public class UserFields
    {
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
    }
}
