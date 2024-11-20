using Jendamark.Assignment.Models;
using System.Collections.Generic;

namespace Jendamark.Assignment.Services.Interfaces
{
    public interface IDeviceService
    {
        List<Device> GetDevices();
        void AddDevice(Device device);
        void UpdateDevice(Device device);
        void RemoveDevice(int deviceId);
        Device GetDeviceById(int deviceId);
        List<LaserDevice> GetLaserDevices();
        List<QualityAssuranceScannerDevice> GetQualityAssuranceScannerDevices();
    }
}
