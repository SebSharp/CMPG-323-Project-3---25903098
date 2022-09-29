using DeviceManagement_WebApp.Models;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        bool ZoneExists(Guid id); //25903098 References the method created if a category exists in the Zone repository
        Task<Zone> AssignZone(Guid? id); //25903098 References the method created assign a zone in the Zone repository
        void UpdateZone(Zone zone); //25903098 References the custom update method in the Zone repository
    }
}
