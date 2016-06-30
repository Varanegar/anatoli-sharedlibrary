using System;
using System.Collections.Generic;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyValueTypeAttributeViewModel : BaseViewModel
    {
        public string LoyaltyValueTypeAttributeCode { get; set; }

        public string LoyaltyValueTypeAttributeName { get; set; }

        public Guid LoyaltyValueTypeId { get; set; }
    }
}
