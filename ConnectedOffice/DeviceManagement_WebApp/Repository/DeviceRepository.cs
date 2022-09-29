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
    public class DeviceRepository : GenericRepository<Device>, IDevicesRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        public bool DeviceExists(Guid id)
        {
            return _context.Device.Any(e => e.CategoryId == id); //25903098 We use this to set the conext for any one device to see if it exists
        }

        public void UpdateDevice(Device device)
        {
            _context.Update(device); //25903098 Custom Update method for Devices only
        }

        public IEnumerable<Device> GetDeviceContext()
        {
            var connectedOfficeContext = _context.Device.Include(d => d.Category).Include(d => d.Zone).ToList();  //25903098 We return a type of IEnumerable because this is what will be displayed in the View
            return connectedOfficeContext;
        }
        public async Task<Device> GetDevice(Guid? id)
        {
            var device = await _context.Device.Include(d => d.Category).Include(d => d.Zone).FirstOrDefaultAsync(m => m.DeviceId == id); //25903098 We use this to set the context asynchronously via a Task 
            return device;
        }

        public SelectList ViewCatDev()
        {
            return new SelectList(_context.Category, "CategoryId", "CategoryName"); //2593098 custom method to get a context of Category for devices returns a SelectList
        }

        public SelectList ViewZoneDev()
        {
            return new SelectList(_context.Zone, "ZoneId", "ZoneName"); //2593098 custom method to get a context of Zone for devices returns a SelectList
        }


    }
}
