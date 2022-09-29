using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        bool DeviceExists(Guid id); //25903098 References the method to see if a device exists in the Device Repository
        void UpdateDevice(Device device); //25903098 References the custom method to update a device in the Device Repository
        IEnumerable<Device> GetDeviceContext();  //25903098 References the custom method to set context for a device in the Device Repository
        Task<Device> GetDevice(Guid? id); //25903098 References the method to get a Device based on an ID
        SelectList ViewCatDev(); //25903098 References the custom method to return a SelectList for a View
        SelectList ViewZoneDev(); //25903098 References the custom method to return a SelectList for a View

    }
}
