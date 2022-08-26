namespace Calculator_Demo
{
    public class Program
    {
        public static void Main()
        {
            Calculator calculatorobj = new Calculator();
            int result = calculatorobj.Addition(2, 2);
            Console.WriteLine(result);
            int result1 = calculatorobj.Subtraction(2, 2);
            Console.WriteLine(result1);
            int result2 = calculatorobj.Multiplication(2, 2);
            Console.WriteLine(result2);
            int result3 = calculatorobj.Division(2, 2);
            Console.WriteLine(result3);
        }
    }
}