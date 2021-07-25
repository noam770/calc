using calc.domain;

namespace calc.services 
{
    public class AddOperation : IOperation 
    {
        public AddOperation()
        {
            
        }

        public float Calc(BinaryOperation operation)
        {
            if(operation == null)
                throw new System.Exception($"invalid operation parameter in {nameof(AddOperation)}. operation cannot be null.");
            
            return operation.Num1 + operation.Num2;
        }

    }
}