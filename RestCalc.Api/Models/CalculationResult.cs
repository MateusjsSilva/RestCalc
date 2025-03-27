namespace RestCalc.Api.Models
{
    public class CalculationResult
    {
        public double Result { get; set; }
        public string Operation { get; set; }
        public double FirstOperand { get; set; }
        public double SecondOperand { get; set; }
    }
}
