using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyRuleConditionViewModel : BaseViewModel
    {
        public Guid LoyaltyRuleId { get; set; }
        public Guid LoyaltyValueTypeAttributeId { get; set; }

        public virtual ICollection<LoyaltyRuleConditionProductGroupViewModel> LoyaltyRuleConditionProductGroups { get; set; }
        public virtual ICollection<LoyaltyRuleConditionProductViewModel> LoyaltyRuleConditionProducts { get; set; }
        public virtual ICollection<LoyaltyRuleConditionValueViewModel> LoyaltyRuleConditionValues { get; set; }



    }
}
