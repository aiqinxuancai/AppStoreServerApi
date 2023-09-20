using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    public class TransactionInfoResponse
    {

        public List<string> SignedTransactionInfo { get; set; } = new();
        
    }
}
