using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.VnGisModels
{
    public class FinanceReportForPrintViewModel
    {
        public Guid UniqueId { get; set; }
        public string Lable { get; set; }
        public string Title { get; set; }
        public int OpenFactorCount { get; set; }
        public decimal OpenFactorAmount { get; set; }
        public int OpenFactorDay { get; set; }
        public int RejectChequeCount { get; set; }
        public decimal RejectChequeAmount { get; set; }
        public int InprocessChequeCount { get; set; }
        public decimal InprocessChequeAmount { get; set; }
        public decimal FirstCredit { get; set; }
        public decimal RemainedCredit { get; set; }
        public decimal FirstDebitCredit { get; set; }
        public decimal RemainedDebitCredit { get; set; }

    }
}
