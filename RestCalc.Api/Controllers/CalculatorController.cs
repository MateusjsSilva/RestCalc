using Microsoft.AspNetCore.Mvc;
using RestCalc.Api.Models;
using RestCalc.Api.Services;

namespace RestCalc.Api.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        /// <summary>
        /// Adds two numbers and returns the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Sum of the two numbers</returns>
        [HttpGet("add")]
        public ActionResult<CalculationResult> Add(double a, double b)
        {
            var result = _calculatorService.Add(a, b);
            return new CalculationResult
            {
                Result = result,
                Operation = "Addition",
                FirstOperand = a,
                SecondOperand = b
            };
        }

        /// <summary>
        /// Subtracts the second number from the first and returns the result
        /// </summary>
        /// <param name="a">Number to subtract from</param>
        /// <param name="b">Number to subtract</param>
        /// <returns>Result of the subtraction</returns>
        [HttpGet("subtract")]
        public ActionResult<CalculationResult> Subtract(double a, double b)
        {
            var result = _calculatorService.Subtract(a, b);
            return new CalculationResult
            {
                Result = result,
                Operation = "Subtraction",
                FirstOperand = a,
                SecondOperand = b
            };
        }

        /// <summary>
        /// Multiplies two numbers and returns the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Product of the two numbers</returns>
        [HttpGet("multiply")]
        public ActionResult<CalculationResult> Multiply(double a, double b)
        {
            var result = _calculatorService.Multiply(a, b);
            return new CalculationResult
            {
                Result = result,
                Operation = "Multiplication",
                FirstOperand = a,
                SecondOperand = b
            };
        }

        /// <summary>
        /// Divides the first number by the second and returns the result
        /// </summary>
        /// <param name="a">Dividend (number to be divided)</param>
        /// <param name="b">Divisor (number to divide by)</param>
        /// <returns>Result of the division</returns>
        /// <response code="400">Returned when trying to divide by zero</response>
        [HttpGet("divide")]
        public ActionResult<CalculationResult> Divide(double a, double b)
        {
            try
            {
                var result = _calculatorService.Divide(a, b);
                return new CalculationResult
                {
                    Result = result,
                    Operation = "Division",
                    FirstOperand = a,
                    SecondOperand = b
                };
            }
            catch (DivideByZeroException)
            {
                return BadRequest("Cannot divide by zero");
            }
        }
    }
}