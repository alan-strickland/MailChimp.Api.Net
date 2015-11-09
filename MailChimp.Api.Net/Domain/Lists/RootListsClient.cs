﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net.Domain.Lists
{
    class RootListsClient
    {
        public List<MCClient> clients { get; set; }
        public string list_id { get; set; }
        public int total_items { get; set; }
        public List<Link> _links { get; set; }
    }
}
