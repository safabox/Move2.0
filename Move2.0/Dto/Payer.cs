using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Move2._0.Dto
{
    public class Payer
    {
        public string email { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public IdentificactionDto identification { get; set; }

    }
}