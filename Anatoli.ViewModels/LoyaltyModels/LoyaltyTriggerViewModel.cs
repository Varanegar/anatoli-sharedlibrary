using System;

namespace Anatoli.ViewModels.LoyaltyModels
{
    //Historical, PerTransaction
    public class LoyaltyTriggerViewModel : BaseViewModel
    {
        public string LoyaltyTriggerCode { get; set; }
        public string LoyaltyTriggerName { get; set; }

        public Guid LoyaltyTriggerTypeId { get; set; }

       // public List<LoyaltyRule> LoyaltyRules { get; set; }
    }
}
