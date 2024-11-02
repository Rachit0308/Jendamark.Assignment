using Jendamark.Assignment.Models;
using Jendamark.Assignment.Services.Interfaces;

namespace Jendamark.Assignment.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Device> devices = new();

        public List<Device> GetDevices() => devices;

        public void AddDevice(Device device) => devices.Add(device);

        public void UpdateDevice(Device device)
        {
            var index = devices.FindIndex(d => d.DeviceID == device.DeviceID);
            if (index >= 0)
                devices[index] = device;
        }
    }
}
