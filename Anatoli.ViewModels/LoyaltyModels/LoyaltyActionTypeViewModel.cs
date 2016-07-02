using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Anatoli.ViewModels.LoyaltyModels
{
    public class LoyaltyActionTypeViewModel : BaseViewModel
    {
        public string LoyaltyActionTypeCode { get; set; }
        public string LoyaltyActionTypeName { get; set; }
    }
}
