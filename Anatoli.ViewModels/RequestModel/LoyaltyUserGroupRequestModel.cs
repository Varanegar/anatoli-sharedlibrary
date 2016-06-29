using Anatoli.ViewModels.LoyaltyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anatoli.ViewModels.User;

namespace Anatoli.ViewModels.RequestModel
{
    public class LoyaltyUserGroupRequestModel : BaseRequestModel
    {

        public LoyaltyUserGroupViewModel  userGroupData { get; set; }
        public List<UserViewModel> users { get; set; }

        //public Guid userId { get; set; }

    }
}
