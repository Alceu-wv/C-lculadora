using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class InputNumbers
    {
        bool isVarParsed = false;
        float num;
        public float InputNumberFromUser(string question)
        {
            while (isVarParsed is false)
            {
                Console.WriteLine(question);
                string? varReaded1 = Console.ReadLine();
                isVarParsed = float.TryParse(varReaded1, out num);

                if (isVarParsed is false)
                {
                    Console.WriteLine("Ups, não entendi seu número...");
                    Console.WriteLine("Tenta de novo?");
                    Console.WriteLine("");
                }
            }
            isVarParsed = false;
            return num;
        }
    }
}
