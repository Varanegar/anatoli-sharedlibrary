using System;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleConditionProductGroupViewModel : BaseViewModel
    {
        public Guid LoyaltyRuleConditionId { get; set; }

        public Guid ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }

    }
}
