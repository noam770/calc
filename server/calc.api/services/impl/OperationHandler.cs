using System.Collections.Generic;
using System.Linq;

namespace calc.services 
{
    class OperationHandler : IOperationHandler
    {
        IDictionary<string, IOperation> _operations;

        public OperationHandler(IOperationFactory operationFactory)
        {
            _operations = operationFactory.GetOperations();
            if(_operations == null || !_operations.Any())
                throw new System.Exception($"error in {nameof(OperationHandler)}. operations list is null or empty.");
        }

        public IOperation GetOperation(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new System.Exception($"invalid 'name' parameter in {nameof(GetOperation)}.");

            name = name.ToLower();
            
            if(!_operations.Keys.Contains(name))
                throw new System.Exception($"error in {nameof(GetOperation)}. operations list does not contain '{name}'.");

            return _operations[name];
        }
         

    }
}