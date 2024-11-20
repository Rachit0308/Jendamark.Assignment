using Jendamark.Assignment.Data.Models;
using Jendamark.Assignment.Data.Repositories.Interfaces;
using Jendamark.Assignment.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Jendamark.Assignment.Data.Repositories.Implementations
{
    public class OperationRepository : IOperationRepository
    {
        private readonly List<Operation> operations = new();

        public List<Operation> GetOperations() => operations;

        public void AddOperation(Operation operation)
        {
            operations.Add(operation);
        }

        public void RemoveOperation(int operationId)
        {
            operations.RemoveAll(op => op.OperationID == operationId);
        }

        public Operation GetOperationById(int operationId)
        {
            return operations.FirstOrDefault(a => a.OperationID == operationId);
        }

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
