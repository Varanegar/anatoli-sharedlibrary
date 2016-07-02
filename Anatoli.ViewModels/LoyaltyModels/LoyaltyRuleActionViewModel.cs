using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleActionViewModel : BaseViewModel
    {
        public decimal ActionValue { get; set; }

        public Guid LoyaltyRuleId { get; set; }
        public string LoyaltyRuleName { get; set; }
        
        public Guid LoyaltyActionTypeId { get; set; }
        public string LoyaltyActionTypeName { get; set; }

        public Guid? LoyaltyValueTypeAttributeId { get; set; }
        public string LoyaltyValueTypeAttributeName { get; set; }

        public Guid? LoyaltyTierId { get; set; }

        public string LoyaltyTierName { get; set; }
        
        public float ActionPercent { get; set; }
        
        public decimal ActionNewValue { get; set; }
        
        public int CreditDay { get; set; }


    }
}
