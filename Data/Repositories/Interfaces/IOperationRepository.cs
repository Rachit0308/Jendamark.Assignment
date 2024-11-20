using Jendamark.Assignment.Data.Models;

namespace Jendamark.Assignment.Data.Repositories.Interfaces
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
