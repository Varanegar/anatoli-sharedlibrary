using Anatoli.ViewModels.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.CustomerModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public string CustomerCode { get; set; }
        public string CustomerName
        {
            get
            {
                return FirstName + " " + LastName ;
            }
            set { }
        }
        public double Longitude { set; get; }
        public double Latitude { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string MainStreet { get; set; }
        public string OtherStreet { get; set; }
        public string PostalCode { get; set; }
        public string NationalCode { get; set; }
        public Nullable<Guid> RegionInfoId { get; set; }
        public Nullable<Guid> RegionLevel1Id { get; set; }
        public Nullable<Guid> RegionLevel2Id { get; set; }
        public Nullable<Guid> RegionLevel3Id { get; set; }
        public Nullable<Guid> RegionLevel4Id { get; set; }
        public Nullable<Guid> DefauleStoreId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public string PBirthDay { get; set; }
        public Nullable<DateTime> MarriageDate { get; set; }
        public string PMarriageDate { get; set; }

        public Nullable<DateTime> GraduateDate { get; set; }
        public string PGraduateDate { get; set; }

        public Nullable<Guid> ReagentId { get; set; }

        public bool GetNews { get; set; }
        public bool GetMessage { get; set; }

        public List<CustomerShipAddressViewModel> CustomerShipAddress { get; set; }
        public int Status { get; set; }
    }
}
