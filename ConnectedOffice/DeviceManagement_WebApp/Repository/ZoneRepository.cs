using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZonesRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        public bool ZoneExists(Guid id)
        {
            return _context.Zone.Any(e => e.ZoneId == id);
        }
        public Zone AssignZone(Guid? id)
        {
            var zone = _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id);
            return zone;

        }
        public void UpdateZone(Zone zone)
        {
            _context.Update(zone);
        }

    }
}
