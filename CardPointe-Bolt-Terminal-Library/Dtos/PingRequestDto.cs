using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class PingRequestDto
    {
        public PingHeaders pingHeaders { get; set; } = new PingHeaders();
        public PingBody pingBody { get; set; } = new PingBody();
    }

    public class PingHeaders
    {
        public string Authorization { get; set; }
        public string XCardConnectSessionKey { get; set; }
    }

    public class PingBody
    {
        public string merchantId { get; set; }
        public string hsn { get; set; }
    }
}
