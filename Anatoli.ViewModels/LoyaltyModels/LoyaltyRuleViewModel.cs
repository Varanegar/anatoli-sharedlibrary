using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleViewModel : BaseViewModel
    {
        public string LoyaltyRuleCode { get; set; }
        public string LoyaltyRuleName { get; set; }
        public string Description{ get; set; }
        public bool HasCondition { get; set; }
        public Guid LoyaltyRuleGroupId { get; set; }
        public Guid LoyaltyRuleTypeId { get; set; }
        public List<LoyaltyRuleTriggerViewModel> LoyaltyRuleTriggers { get; set; }
        public List<LoyaltyRuleActionViewModel> LoyaltyRuleActions { get; set; }


    }
}
