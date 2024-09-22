namespace LR3.Services
{
    public class CalcService : ICalcService
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed!");
            }
            return (double)a / b;
        }
    }
}
