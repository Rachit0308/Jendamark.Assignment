using System.ComponentModel.DataAnnotations;

namespace Jendamark.Assignment.Data.Models
{
    public class Operation
    {
        public int OperationID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }
        public int Order { get; set; } = 1; // Sequence order of the operation
        public Device Device { get; set; }
    }
}
