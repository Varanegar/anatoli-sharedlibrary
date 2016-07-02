using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleRequestModel
    {
        public Guid? uniqueId { get; set; }
        public LoyaltyRuleViewModel ruleData { get; set; }
        public LoyaltyRuleActionViewModel ruleActionData { get; set; }
    }
}
