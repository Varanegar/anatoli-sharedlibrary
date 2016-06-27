using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anatoli.ViewModels.CustomerModels
{
    public class CustomerNonMonetaryHistoryViewModel : BaseViewModel
    {
        public Guid CustomerId { get; set; }

        public string UserId { get; set; }
 
        public DateTime ActivityDate { get; set; }
        public string ActivityPDate { get; set; }

        public string ActivityDesc { get; set; }

        public string PlaceDesc { get; set; }

        public string TerminalDesc { get; set; }

        public string Description { get; set; }


    }
}
