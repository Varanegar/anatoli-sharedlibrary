using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.DeviceBaseSystem
{
    public class CompanyDeviceViewModel : BaseViewModel
    {
        public Guid CompanyId { get; set; }
        public Guid DeviceModelId { get; set; }
        public string DeviceModelName { get; set; }
        public string IMEI { get; set; }
        public string Description { get; set; }

    }
}
