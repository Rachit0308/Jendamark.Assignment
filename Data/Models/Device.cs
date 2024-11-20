using System.ComponentModel.DataAnnotations;

namespace Jendamark.Assignment.Data.Models
{
    public class Device
    {
        public int DeviceID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Device Type is required")]
        public DeviceType DeviceType { get; set; }

    }
    public class LaserDevice : Device
    {
        public int LaserIntensity { get; set; }
        public bool SafetyCheckRequired { get; set; }
    }
    public class QualityAssuranceScannerDevice : Device
    {
        [StringLength(50, ErrorMessage = "Validation Code cannot exceed 50 characters")]
        [Required(ErrorMessage = "Validation Code is required")]
        public string ValidationCode { get; set; }

        [StringLength(50, ErrorMessage = "Outcome Status cannot exceed 50 characters")]
        [Required(ErrorMessage = "Outcome Status is required")]
        public string OutcomeStatus { get; set; }
    }
}
