using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Transactions;
namespace AppStoreServerApi.Models
{
    //https://developer.apple.com/documentation/appstoreserverapi/refundhistoryresponse
    public class RefundHistoryResponse
    {
        public bool HasMore { get; set; }
        public string Revision { get; set; } = null!;

        public List<string> SignedTransactions { get; set; } = new();
    }
}
