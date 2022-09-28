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
            return _context.Device.Any(e => e.CategoryId == id);
        }

        public void UpdateDevice(Device device)
        {
            _context.Update(device);
        }

        public Device GetDeviceContext()
        {
            var connectedOfficeContext = _context.Device.Include(d => d.Category).Include(d => d.Zone);
            return connectedOfficeContext;
        }


    }
}
