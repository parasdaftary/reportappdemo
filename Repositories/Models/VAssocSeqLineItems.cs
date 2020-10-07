using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class VAssocSeqLineItems
    {
        public string OrderNumber { get; set; }
        public byte LineNumber { get; set; }
        public string Model { get; set; }
    }
}
