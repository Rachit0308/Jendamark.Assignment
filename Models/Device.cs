namespace Jendamark.Assignment.Models
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
        public int? LaserIntensity { get; set; } // Only for LaserCutter
        public bool? SafetyCheckRequired { get; set; } // Only for LaserCutter
        public string ValidationCode { get; set; } // Only for QualityAssuranceScanner
        public string OutcomeStatus { get; set; } // Only for QualityAssuranceScanner
    }
}
