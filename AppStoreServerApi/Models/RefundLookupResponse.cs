using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    //https://developer.apple.com/documentation/appstoreserverapi/refundlookupresponse
    public class RefundLookupResponse
    {
        public List<string> SignedTransactions { get; set; } = new();
    }
}
