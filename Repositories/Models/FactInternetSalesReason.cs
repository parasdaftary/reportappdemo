using System;
using System.Collections.Generic;

namespace Repositories.Models
{
    public partial class FactInternetSalesReason
    {
        public string SalesOrderNumber { get; set; }
        public byte SalesOrderLineNumber { get; set; }
        public int SalesReasonKey { get; set; }

        public virtual FactInternetSales SalesOrder { get; set; }
        public virtual DimSalesReason SalesReasonKeyNavigation { get; set; }
    }
}
