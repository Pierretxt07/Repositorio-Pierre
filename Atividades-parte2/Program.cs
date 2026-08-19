using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Desafio();
    }
    private static void ParaEnquantoQuestão1()
    {
        for (int i = 1; i <= 10; i++ )
        {
            Console.Write($"{i} ");
        }
    }
    private static void ParaEnquantoQuestão2()
    {
        int num; 
        Console.WriteLine("Digite um número");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"\n{num} * {i} = {num * i}");
        }
    }
    private static void ParaEnquantoQuestão3()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
    private static void ParaEnquantoQuestão4()
    {
        int num, soma = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());
            soma = soma + num;
        }
        Console.WriteLine($"Média: {soma / 5}");
    }
    private static void ParaEnquantoQuestão5()
    {
        for (int i = 10; i <= 10 & i >= 0; i--)
        {
            Console.WriteLine($"{i} ");
        }
        Console.WriteLine("Lançamento!!!");
    }
    private static void ParaEnquantoQuestão6()
    {
        int num;
        Console.WriteLine("Digite um número");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= num; i++)
        {
            Console.Write($"{i} ");
        }
    }
    private static void ParaEnquantoQuestão7()
    {
        int num, maior = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite um número ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > maior)
            {
                maior = num;
            }
        }
        Console.WriteLine($"Maior número: {maior}");
    }
    private static void ParaEnquantoQuestão8()
    {
        int soma = 0;
        for (int i = 0; i <= 100; i++)
        {
            soma += i;
        }
        Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
    }
    private static void ParaEnquantoQuestão9()
    {
        string algo, senha = "1705";
        do
        {
         Console.WriteLine("Digite a senha");
         algo = Console.ReadLine();   
        } while (algo != senha);
    }
    private static void ParaEnquantoQuestão10()
    {
        int num, soma = 0;
        do
        {
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());
            soma += num;
        } while (num != 0);
        Console.WriteLine($"Resultado da soma: {soma}");
    }
    private static void Desafio()
    {
        int num1, num2, teste;
        char sn;
        do
        {
            Console.WriteLine("Informe a operação desejada:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nInforme aqui: ");
            teste = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (teste == 1)
            {
                Console.WriteLine($"\nResultado da soma: {num1 + num2}");
            }
            else if (teste == 2)
            {
                Console.WriteLine($"\nResultado da subtração: {num1 - num2}");
            }
            else if (teste == 3)
            {
                Console.WriteLine($"\nResultado da multiplicação: {num1 * num2}");
            }
            else
            {
                Console.WriteLine($"\nResultado da divisão: {num1 / num2}");
            }
            Console.WriteLine("\nDeseja realizar outra operação? \nInforme com s ou n: ");
            sn = Convert.ToChar(Console.ReadLine());
        } while (sn != 'n');
    }
}