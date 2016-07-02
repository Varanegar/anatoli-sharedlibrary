using System;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleConditionValueViewModel : BaseViewModel
    {
        public Guid LoyaltyRuleConditionId { get; set; }

        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal StepValue { get; set; }

    }
}
