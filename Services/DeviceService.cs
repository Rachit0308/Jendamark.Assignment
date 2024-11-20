using Jendamark.Assignment.Models;
using Jendamark.Assignment.Services.Interfaces;

namespace Jendamark.Assignment.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Device> devices = new();

        public List<Device> GetDevices() => devices;

        public void AddDevice(Device device)
        {
            if (device is LaserDevice laserDevice)
            {
                AddLaserDevice(laserDevice);
            }
            else if (device is QualityAssuranceScannerDevice qaDevice)
            {
                AddQualityAssuranceScannerDevice(qaDevice);
            }
            else
            {
                devices.Add(device);
            }
        }

        public void AddLaserDevice(LaserDevice laserDevice)
        {
            devices.Add(laserDevice);
        }

        public void AddQualityAssuranceScannerDevice(QualityAssuranceScannerDevice qaDevice)
        {
            devices.Add(qaDevice);
        }

        public void UpdateDevice(Device device)
        {
            var index = devices.FindIndex(d => d.DeviceID == device.DeviceID);
            if (index >= 0)
            {
                if (device is LaserDevice laserDevice)
                {
                    devices[index] = laserDevice;
                }
                else if (device is QualityAssuranceScannerDevice qaDevice)
                {
                    devices[index] = qaDevice;
                }
                else
                {
                    devices[index] = device;
                }
            }
        }

        public void RemoveDevice(int deviceId) =>
            devices.RemoveAll(d => d.DeviceID == deviceId);

        public Device GetDeviceById(int deviceId) =>
            devices.FirstOrDefault(d => d.DeviceID == deviceId);

        public List<LaserDevice> GetLaserDevices() =>
            devices.OfType<LaserDevice>().ToList();

        public List<QualityAssuranceScannerDevice> GetQualityAssuranceScannerDevices() =>
            devices.OfType<QualityAssuranceScannerDevice>().ToList();
    }
}
