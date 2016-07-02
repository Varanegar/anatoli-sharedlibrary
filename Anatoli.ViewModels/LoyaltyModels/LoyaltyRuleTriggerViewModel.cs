using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleTriggerViewModel : BaseViewModel
    {
        public Guid LoyaltyRuleId { get; set; }

        public Guid LoyaltyTriggerId { get; set; }
        public string LoyaltyTriggerName { get; set; }
    }
}
