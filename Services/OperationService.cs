using Jendamark.Assignment.Models;
using Jendamark.Assignment.Services.Interfaces;

namespace Jendamark.Assignment.Services
{
    public class OperationService : IOperationService
    {
        private readonly List<Operation> operations = new();

        public List<Operation> GetOperations() => operations;

        public void AddOperation(Operation operation) => operations.Add(operation);

        public void RemoveOperation(int operationId) =>
            operations.RemoveAll(op => op.OperationID == operationId);

        public Operation GetOperationById(int operationId) => operations.Where(a=>a.OperationID == operationId).FirstOrDefault();

        public void UpdateOperation(Operation operation)
        {
            var existingOperation = operations.FirstOrDefault(o => o.OperationID == operation.OperationID);

            if (existingOperation != null)
            {
                existingOperation.Name = operation.Name;
                existingOperation.Device = operation.Device;
                existingOperation.Order = operation.Order;
            }
            else
            {
                throw new ArgumentException("Operation not found.");
            }
        }
    }
}
