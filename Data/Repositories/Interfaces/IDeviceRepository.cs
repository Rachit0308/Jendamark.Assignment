using Jendamark.Assignment.Data.Models;

namespace Jendamark.Assignment.Data.Repositories.Interfaces
{
    public interface IDeviceRepository
    {
        List<Device> GetAllDevices();
        void AddDevice(Device device);
        void DeleteDevice(int deviceId);
        void UpdateDevice(Device device);
    }
}
