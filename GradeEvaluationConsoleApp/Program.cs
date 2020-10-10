using System;

namespace GradeEvaluationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a nota do aluno:");
            float nota = float.Parse(Console.ReadLine());

            if (nota == 0)
                Console.WriteLine("que vergonha!");
            else if (nota < 5)
                Console.WriteLine("Precisa estudar muito mais");
            else if (nota >= 5 && nota < 8)
                Console.WriteLine("Precisa estudar mais");
            else if (nota >= 8 && nota < 10)
                Console.WriteLine("Falta Pouco");
            else if (nota == 10)
                Console.WriteLine("Parabéns!");
            else
                Console.WriteLine("Nota invalida!");
        }
    }
}
