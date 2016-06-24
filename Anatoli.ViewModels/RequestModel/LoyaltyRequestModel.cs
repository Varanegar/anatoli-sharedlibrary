﻿using System;
using Anatoli.ViewModels.User;
using System.Collections.Generic;
using Anatoli.ViewModels.StockModels;
using Anatoli.ViewModels.ProductModels;
using Anatoli.ViewModels.BaseModels;
using Anatoli.ViewModels.CustomerModels;
using Anatoli.ViewModels.LoyaltyModels;

namespace Anatoli.ViewModels
{
    public class LoyaltyRequestModel : BaseRequestModel
    {
        public Guid loyaltyCardId { get; set; }
        public Guid loyaltyCardSetId { get; set; }
        public List<LoyaltyCardViewModel> loyaltyCardListData { get; set; }
        public List<LoyaltyCardSetViewModel> loyaltyCardSetListData { get; set; }
        public List<LoyaltyTierViewModel> loyaltyTierListData { get; set; }

    }
}
