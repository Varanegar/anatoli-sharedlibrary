using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anatoli.ViewModels.CustomerModels;

namespace Anatoli.ViewModels.RequestModel
{
    public class CustomerHistoryRequestModel : BaseRequestModel
    {
        public CustomerNonMonetaryHistoryViewModel customerNonMonetaryHistoryData { get; set; }
        public CustomerMonetaryHistoryViewModel customerMonetaryHistoryData { get; set; }

        public CustomerTransactionHistoryViewModel customerTransactionHistoryData { get; set; }
    }
}
