namespace Jendamark.Assignment.Models
{
    public class Operation
    {
        public int OperationID { get; set; }
        public string Name { get; set; }
        public int Order { get; set; } // Sequence order of the operation
        public Device Device { get; set; }
    }
}
