using Jendamark.Assignment.Models;

namespace Jendamark.Assignment.Services.Interfaces
{
    public interface IOperationService
    {
        List<Operation> GetOperations();
        void AddOperation(Operation operation);
        void RemoveOperation(int operationId);
    }
}
