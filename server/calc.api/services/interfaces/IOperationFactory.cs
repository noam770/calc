using System.Collections.Generic;

namespace calc.services
{
    public interface IOperationFactory
    {
        IDictionary<string, IOperation> GetOperations();

    }

}