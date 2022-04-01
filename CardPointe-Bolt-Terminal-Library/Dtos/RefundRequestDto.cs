using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class RefundRequestDto
    {
        public RefundHeaders refundHeaders { get; set; }
        public RefundBody refundBody { get; set; }
    }

    public class RefundHeaders
    {
        public string Authorization { get; set; }
    }

    public class RefundBody
    {
        public string merchid { get; set; }
        public string retref { get; set; }
        public string amount { get; set; }
        public string orderid { get; set; }
    }
}
