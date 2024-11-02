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
    }
}
