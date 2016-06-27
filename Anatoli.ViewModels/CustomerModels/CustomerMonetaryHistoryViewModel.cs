using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.CustomerModels
{
    public class CustomerMonetaryHistoryViewModel : BaseViewModel
    {
        public Guid CustomerId { get; set; }

        public string UserId { get; set; }

        public DateTime TransactionDate { get; set; }
        public string TransactionPDate { get; set; }

        public string TransactionDesc { get; set; }

        public decimal Amount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal Discount { get; set; }

        public string PlaceDesc { get; set; }

        public string TerminalDesc { get; set; }

        public string Description { get; set; }
    }
}
