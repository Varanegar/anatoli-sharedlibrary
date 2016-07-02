using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anatoli.ViewModels.LoyaltyModels;

namespace Anatoli.ViewModels.RequestModel
{
    public class LoyaltyRuleGroupRequestModel : BaseRequestModel
    {
        public LoyaltyRuleGroupViewModel ruleGroupData { get; set; }
    }
}
