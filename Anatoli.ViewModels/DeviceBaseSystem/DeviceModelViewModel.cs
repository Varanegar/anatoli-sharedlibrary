using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoli.ViewModels.DeviceBaseSystem
{
    public class DeviceModelViewModel : BaseViewModel
    {
        public string deviceCode { get; set; }
        public string deviceName { get; set; }

        public Guid brandId { get; set; }
        public string brandName { get; set; }
    }
}
