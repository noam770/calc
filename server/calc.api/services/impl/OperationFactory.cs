using System.Collections.Generic;

namespace calc.services 
{
    public class OperationFactory : IOperationFactory
    {
        public OperationFactory()
        {
            
        }
        public IDictionary<string, IOperation> GetOperations()
        {
            var list = new Dictionary<string, IOperation>();
            list.Add("add", new AddOperation());

            return list;
        }

    }
}