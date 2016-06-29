using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anatoli.ViewModels.VnGisModels;

namespace Anatoli.ViewModels.RequestModel
{
    public class FinanceReportRequestModel
    {
        public Guid ClientId { set; get; }
        public int DefaultField { set; get; }
        public bool ChangeFilter { set; get; }
        public List<Guid> AreaIds { set; get; }
        public int Type { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
        public string SaleOffice { set; get; }
        public string Header { set; get; }
        public string Seller { set; get; }
        public string CustomerClass { set; get; }
        public string CustomerActivity { set; get; }
        public string CustomerDegree { set; get; }
        public string GoodGroup { set; get; }
        public string DynamicGroup { set; get; }
        public string Good { set; get; }
        public string CommercialName { set; get; }
        public string UnSoldGoodGroup { set; get; }
        public string UnSoldGood { set; get; }
        public int? DayCount { set; get; }     
        
        public bool OpenFactorCount { set; get; }
        public bool OpenFactorAmount { set; get; }
        public bool OpenFactorDay { set; get; }
        public bool RejectChequeCount { set; get; }
        public bool RejectChequeAmount { set; get; }
        public bool InprocessChequeCount { set; get; }
        public bool InprocessChequeAmount { set; get; }
        public bool FirstCredit { set; get; }
        public bool RemainedCredit { set; get; }
        public bool FirstDebitCredit { set; get; }
        public bool RemainedDebitCredit { set; get; }

        //value
        public List<RegionAreaPointViewModel> CustomPoint { set; get; }

        public int? FromOpenFactorCount { set; get; }
        public int? ToOpenFactorCount { set; get; }
        public decimal? FromOpenFactorAmount { set; get; }
        public decimal? ToOpenFactorAmount { set; get; }
        public int? FromOpenFactorDay { set; get; }
        public int? ToOpenFactorDay { set; get; }
        public int? FromRejectChequeCount { set; get; }
        public int? ToRejectChequeCount { set; get; }
        public decimal? FromRejectChequeAmount { set; get; }
        public decimal? ToRejectChequeAmount { set; get; }
        public int? FromImprocessChequeCount { set; get; }
        public int? ToImprocessChequeCount { set; get; }
        public decimal? FromImprocessChequeAmount { set; get; }
        public decimal? ToImprocessChequeAmount { set; get; }
        public decimal? FromFirstCredit { set; get; }
        public decimal? ToFirstCredit { set; get; }
        public decimal? FromRemainedCredit { set; get; }
        public decimal? ToRemainedCredit { set; get; }

        public decimal? FromFirstDebitCredit { set; get; }
        public decimal? ToFirstDebitCredit { set; get; }

        public decimal? FromRemainedDebitCredit { set; get; }
        public decimal? ToRemainedDebitCredit { set; get; }

    }
}
