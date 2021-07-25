using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using calc.domain;
using calc.services;

namespace calc.api.Controllers
{
    public class CalcController : Controller
    {
        private readonly IOperationHandler _operationHandler;

        public CalcController(IOperationHandler operationHandler)
        {
            _operationHandler = operationHandler;    
        }
        // 
        // GET: /Calc/

        //[HttpGet()]
        public string Get()
        {
            return "This is my default action...";
        }

        [HttpPut()]
        public double Add([FromBody] BinaryOperation operation)
        {
            System.Diagnostics.Debug.WriteLine($"in {nameof(Add)}. with operation: {operation}");
            //return "This is my default action...";
            return _operationHandler.GetOperation(operation.Action).Calc(operation);
        }

        
    }
}