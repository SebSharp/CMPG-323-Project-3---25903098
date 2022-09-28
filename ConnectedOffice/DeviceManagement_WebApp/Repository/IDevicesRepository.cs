using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        bool DeviceExists(Guid id);
        void UpdateDevice(Device device);
        Device GetDeviceContext();

    }
}
