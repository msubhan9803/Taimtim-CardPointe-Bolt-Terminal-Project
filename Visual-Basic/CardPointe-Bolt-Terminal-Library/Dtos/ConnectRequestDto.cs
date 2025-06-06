﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPointe_Bolt_Terminal_Library.Dtos
{
    public class ConnectRequestDto
    {
        public ConnectHeaders connectHeaders { get; set; } = new ConnectHeaders();
        public ConnectBody connectBody { get; set; } = new ConnectBody();
    }

    public class ConnectHeaders
    {
        public string Authorization { get; set; }
    }

    public class ConnectBody
    {
        public string merchantId { get; set; }
        public string hsn { get; set; }
        public string force { get; set; }
    }
}
