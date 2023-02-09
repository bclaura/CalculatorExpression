using System;
using Microsoft.JScript.Vsa;
using Microsoft.JScript;

namespace CalculatorExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator" + "\n");
            Console.WriteLine("Calculate your problem here: ");
            while (true)
            {
                var userInput = Console.ReadLine();
                var engine = VsaEngine.CreateEngine();
                var result = Eval.JScriptEvaluate(userInput, engine);

                Console.WriteLine("The result is: " + result + "\n");
                Console.WriteLine("Enter another one: ");
            }
        }
    }
}


