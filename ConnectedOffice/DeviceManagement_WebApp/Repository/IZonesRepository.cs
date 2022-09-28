using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        bool ZoneExists(Guid id);
        Zone AssignZone(Guid? id);
        void UpdateZone(Zone zone);
    }
}
