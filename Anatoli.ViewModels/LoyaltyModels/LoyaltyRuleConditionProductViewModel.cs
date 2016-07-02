using System;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleConditionProductViewModel : BaseViewModel
    {
        public Guid LoyaltyRuleConditionId { get; set; }

        public Guid ProductId { get; set; }
        public String ProductName { get; set; }

    }
}
