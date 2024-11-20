using Jendamark.Assignment.Data.Models;
using Jendamark.Assignment.Data.Repositories.Interfaces;
using Jendamark.Assignment.Services.Interfaces;

namespace Jendamark.Assignment.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Device> devices = new();
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
            devices = _deviceRepository.GetAllDevices(); // Fetch devices from repository
        }

        public List<Device> GetDevices() => devices;

        public void AddDevice(Device device)
        {
            _deviceRepository.AddDevice(device);
        }

        public void UpdateDevice(Device device) => _deviceRepository.UpdateDevice(device);

        public void RemoveDevice(int deviceId) =>
            _deviceRepository.DeleteDevice(deviceId);

        public Device GetDeviceById(int deviceId) =>
            devices.FirstOrDefault(d => d.DeviceID == deviceId);

        public List<LaserDevice> GetLaserDevices() =>
            devices.OfType<LaserDevice>().ToList();

        public List<QualityAssuranceScannerDevice> GetQualityAssuranceScannerDevices() =>
            devices.OfType<QualityAssuranceScannerDevice>().ToList();
    }
}
