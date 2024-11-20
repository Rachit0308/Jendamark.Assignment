using Jendamark.Assignment.Models;

namespace Jendamark.Assignment.Repositories.Contracts
{
    public interface IDeviceRepository
    {
        List<Device> GetAllDevices();
        void AddDevice(Device device);
        void DeleteDevice(int deviceId);
        void UpdateDevice(Device device);
    }
}
