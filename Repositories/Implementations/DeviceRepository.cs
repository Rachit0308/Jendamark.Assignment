using Jendamark.Assignment.Models;
using Jendamark.Assignment.Repositories.Contracts;

namespace Jendamark.Assignment.Repositories.Implementations
{
    public class DeviceRepository: IDeviceRepository
    {
        private readonly List<Device> devices;

        public DeviceRepository()
        {
            // You can initialize with some dummy data or fetch from a database, API, etc.
            devices = new List<Device>();
        }

        public List<Device> GetAllDevices() => devices;
        public void AddDevice(Device device) {
            devices.Add(device);
        }
        public void DeleteDevice(int deviceId) =>
           devices.RemoveAll(d => d.DeviceID == deviceId);

        public void UpdateDevice(Device device)
        {
            var index = devices.FindIndex(d => d.DeviceID == device.DeviceID);
            if (index >= 0)
            {
                devices[index] = device;
            }
        }
    }
}
