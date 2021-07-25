namespace calc.services
{
    public interface IOperationHandler
    {
        IOperation GetOperation(string name);
    }
}