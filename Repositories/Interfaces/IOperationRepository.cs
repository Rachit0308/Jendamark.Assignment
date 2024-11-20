using Jendamark.Assignment.Models;

namespace Jendamark.Assignment.Repositories.Contracts
{
    public interface IOperationRepository
    {
        List<Operation> GetOperations();
        void AddOperation(Operation operation);
        void RemoveOperation(int operationId);
        Operation GetOperationById(int operationId);
        void UpdateOperation(Operation operation);
    }
}
