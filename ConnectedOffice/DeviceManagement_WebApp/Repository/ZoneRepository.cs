using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZonesRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

    }
}
