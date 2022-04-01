using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class DisconnectRequestDto
    {
        public DisconnectHeaders disconnectHeaders { get; set; }
        public DisconnectBody disconnectBody { get; set; }
    }

    public class DisconnectHeaders
    {
        public string Authorization { get; set; }
        public string XCardConnectSessionKey { get; set; }
    }

    public class DisconnectBody
    {
        public string merchantId { get; set; }
        public string hsn { get; set; }
    }
}
