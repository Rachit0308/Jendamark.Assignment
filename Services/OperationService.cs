using Jendamark.Assignment.Models;
using Jendamark.Assignment.Repositories.Contracts;
using Jendamark.Assignment.Services.Interfaces;

namespace Jendamark.Assignment.Services
{
    public class OperationService : IOperationService
    {
        private readonly IOperationRepository _operationRepository;

        // Inject the repository into the service
        public OperationService(IOperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
        }

        public List<Operation> GetOperations() => _operationRepository.GetOperations();

        public void AddOperation(Operation operation) => _operationRepository.AddOperation(operation);

        public void RemoveOperation(int operationId) => _operationRepository.RemoveOperation(operationId);

        public Operation GetOperationById(int operationId) => _operationRepository.GetOperationById(operationId);

        public void UpdateOperation(Operation operation) => _operationRepository.UpdateOperation(operation);
    }
}
