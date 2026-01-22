using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{


    public class Calculator
    {
        // This attribute will generate a compiler warning
        [Obsolete("Use the Add(int, int) method instead.")]
        public int OldAdd(int a, int b)
        {
            return a + b;
        }

     
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class ExampleForAttribute
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            int sum1 = calculator.OldAdd(3, 4); // This will generate a warning
            int sum2 = calculator.Add(3, 4);    // Preferred method
            Console.WriteLine($"Sum using OldAdd: {sum1}");
            Console.WriteLine($"Sum using Add: {sum2}");
        }

    }
}
