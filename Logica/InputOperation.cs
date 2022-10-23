using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class InputOperation
    {
        InputNumbers inputNumbers = new();
        int userOperationChoice;
        List<int> operationChoices = Enumerable.Range(1, 4).ToList();
        public string InputOperationFromUser()
        {

            Console.WriteLine("Qual a operação do seu cálculo matemático?");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            while (operationChoices.Contains(userOperationChoice) is false)
            {
                userOperationChoice = (int) inputNumbers.InputNumberFromUser("Digite o número da operação");

                switch (userOperationChoice)
                {
                    case 1:
                        return "Soma";
                    case 2:
                        return "Subtração";
                    case 3:
                        return "Multiplicação";
                    case 4:
                        return "Divisão";
                }
                
                if (operationChoices.Contains(userOperationChoice) is false)
                {
                    Console.WriteLine("Ups, esse número não corresponde a nehuma operação...");
                    Console.WriteLine("Tenta de novo?");
                    Console.WriteLine("");
                }
            }
            return "";
        }
    }
}
