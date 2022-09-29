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
            return _context.Zone.Any(e => e.ZoneId == id); //25903098 We use this to set the conext for any one zone to see if it exists
        }

        public async Task<Zone> AssignZone(Guid? id)
        {
            var zone = await _context.Zone.FirstOrDefaultAsync(m => m.ZoneId == id); //25903098 We use this to set the context asynchronously via a Task 
            return zone; 

        }
        public void UpdateZone(Zone zone)
        {
            _context.Update(zone);  //25903098 Custom Update method for Zones only
        }

    }
}
