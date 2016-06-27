using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.CustomerModels
{
    public class CustomerTransactionHistoryViewModel : BaseViewModel
    {
        public Guid CustomerId { get; set; }
        public Guid LoyaltyValueTypeId { get; set; }
       
        public DateTime TransactionDate { get; set; }
        [StringLength(10)]
        public string TransactionPDate { get; set; }
  
        [StringLength(500)]
        public string Description { get; set; }
        public decimal IncreaseValue { get; set; }
        public decimal DecreaseValue { get; set; }
        public decimal FirstValue { get; set; }
        public decimal FinalValue { get; set; }
    }
}
