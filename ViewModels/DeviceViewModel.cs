using Jendamark.Assignment.Models;

namespace Jendamark.Assignment.ViewModels
{
    public class DeviceViewModel
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
        public string LaserIntensityDisplay { get; set; }
        public string SafetyCheckDisplay { get; set; }
        public string ValidationCodeDisplay { get; set; }
        public string OutcomeStatusDisplay { get; set; }
    }
}
