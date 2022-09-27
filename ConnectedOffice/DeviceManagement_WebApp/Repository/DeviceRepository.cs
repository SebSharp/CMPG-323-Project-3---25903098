using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDevicesRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

    }
}
