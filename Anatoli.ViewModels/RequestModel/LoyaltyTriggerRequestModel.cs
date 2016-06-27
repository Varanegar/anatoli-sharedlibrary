using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anatoli.ViewModels.LoyaltyModels;

namespace Anatoli.ViewModels.RequestModel
{
    public class LoyaltyTriggerRequestModel : BaseRequestModel
    {
        public LoyaltyTriggerViewModel loyaltyTriggerData { get; set; }
        public LoyaltyTriggerTypeViewModel loyaltyTriggerTypeData { get; set; }

    }
}
