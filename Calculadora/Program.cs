using Logica;
using System.Linq.Expressions;

public class Calculadora
{
    static void Main(string[] args)
    {
        InputNumbers inputNumbers = new();
        InputOperation inputOperation = new();
        Operacoes operacoes = new();
        float num1;
        float num2;
        string userOperationChoice;

        userOperationChoice = inputOperation.InputOperationFromUser();
        num1 = inputNumbers.InputNumberFromUser("Digite o primeiro número");
        num2 = inputNumbers.InputNumberFromUser("Digite o segundo número");

        switch (userOperationChoice)
        {
            case "Soma":
                Console.WriteLine($">>> {operacoes.Soma(num1, num2)}");
                break;
            case "Subtração":
                Console.WriteLine($">>> {operacoes.Subtrai(num1, num2)}");
                break;
            case "Multiplicação":
                Console.WriteLine($">>> {operacoes.Multiplica(num1, num2)}");
                break;
            case "Divisão":
                Console.WriteLine($">>> {operacoes.Divide(num1, num2)}");
                break;
        }
    }

}
