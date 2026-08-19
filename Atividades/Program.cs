
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Atv4questão9();
    }
    private static void Atv1questão1()
    {
     string nome;
        Console.WriteLine("Informe o seu nome ");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! Seja bem-vindo ao DotNet");
    }
    private static void Atv1questão2()
    {
        int idade;
        Console.WriteLine("Informe a sua idade ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Você tem {idade} anos");
    }
    private static void Atv1questão3()
    {
        string cidade;
        Console.WriteLine("Informe a cidade em que você mora ");
        cidade = Console.ReadLine();
        Console.WriteLine($"Você mora em {cidade}");
    }
    private static void Atv1questão4()
    {
        decimal altura;
        Console.WriteLine("Informe a sua altura ");
        altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"A sua altura é {altura} metros");
    }
    private static void Atv1questão5()
    {
        decimal peso;
        Console.WriteLine("Informe o seu peso ");
        peso = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Você pesa {peso}Kg");
    }
    private static void Atv1questão6()
    {
        string nomec;
        Console.WriteLine("Informe o seu nome completo ");
        nomec = Console.ReadLine();
        Console.WriteLine($"Nome cadastrado: {nomec}");
    }
    private static void Atv1questão7()
    {
        int serie;
        Console.WriteLine("Informe o seu ano escolar ");
        serie = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Você está no {serie}º ano escolar");
    }
    private static void Atv1questão8()
    {
        decimal nota;
        Console.WriteLine("Informe a sua nota ");
        nota = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Nota registrada: {nota}");
    }
    private static void Atv1questão9()
    {
        char letra;
        Console.WriteLine("Digite uma letra do alfabeto ");
        letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Sua letra favorita é: {letra}");
    }
    private static void Atv1questão10()
    {
        char fm;
        Console.WriteLine("Informe o seu sexo com M ou F ");
        fm = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Sexo registrado: {fm}");
    }
    private static void Atv1questão11()
    {
        string time;
        Console.WriteLine("Informe o time que você torce ");
        time = Console.ReadLine();
        Console.WriteLine($"O time que você torce é o {time}");
    }
    private static void Atv1questão12()
    {
        string filme;
        Console.WriteLine("Informe o seu filme favorito ");
        filme = Console.ReadLine();
        Console.WriteLine($"Seu filme favorito é: {filme}");
    }
    private static void Atv1questão13()
    {
        int cel;
        Console.WriteLine("Informe o seu número de telefone ");
        cel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Telefone cadastrado: {cel}");
}
private static void Atv1questão14()
    {
        int dia, mes, ano;
        Console.WriteLine("\nInforme somente o dia que você nasceu ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\ninforme somente o mês que você nasceu ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme somente o ano que você nasceu ");
        ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nData de nascimento: {dia}/{mes}/{ano}");
    }
    private static void Atv1questão15()
    {
        string nome, cidade;
        int idade;
        Console.WriteLine("\nInforme o seu nome ");
        nome = Console.ReadLine();
        Console.WriteLine("\nInforme a sua idade ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme a sua cidade ");
        cidade = Console.ReadLine();
        Console.WriteLine($"\nFICHA CADASTRAL\n\nNome: {nome}\nIdade: {idade}\nCidade: {cidade}");
    }
    private static void Atv1questão16()
    {
        string nome, posicao;
        int num;
        Console.WriteLine("\nInforme o nome do jogador ");
        nome = Console.ReadLine();
        Console.WriteLine("\nInforme o número da camisa ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme a posição ");
        posicao = Console.ReadLine();
        Console.WriteLine($"\nNome do jogador: {nome}\nNúmero da camisa: {num}\nPosição: {posicao}");
    }
    private static void Atv1questão17()
    {
        string nome, cidade;
        int idade;
        Console.WriteLine("\nInforme o seu nome de usuário ");
        nome = Console.ReadLine();
        Console.WriteLine("\nInforme a sua cidade ");
        cidade = Console.ReadLine();
        Console.WriteLine("\nInforme a sua idade ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nRESUMO DO PERFIL\n\nNome de usuário: {nome}\nCidade: {cidade}\nIdade: {idade}");
    }
    private static void Atv1questão18()
    {
        string nome, curso, cidade;
        int idade;
        Console.WriteLine("\nInforme o seu nome ");
        nome = Console.ReadLine();
        Console.WriteLine("\nInforme a sua idade ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme o curso desejado ");
        curso = Console.ReadLine();
        Console.WriteLine("\nInforme a sua cidade ");
        cidade = Console.ReadLine();
        Console.WriteLine($"\n\nNome: {nome}\n\nIdade: {idade}\n\nCurso desejado: {curso}\n\nCidade: {cidade}");
    }
    private static void Atv1questão19()
    {
        string nome, cidade, materia;
        int idade, serie;
        decimal altura;
        Console.WriteLine("\nInfirme o seu nome ");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a sua altura ");
        altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a sua série escolar ");
        serie = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a sua cidade ");
        cidade = Console.ReadLine();
        Console.WriteLine("Informe a sua matéria favorita ");
        materia = Console.ReadLine();
        Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nAltura: {altura}\nSérie: {serie}º ano\nCidade: {cidade}\nMatéria favorita: {materia}");
    }
    private static void Atv2questão1()
    {
      int num1, num2, num3, num4, num5;
      Console.WriteLine("Informe o primeirop número ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o segundo número ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o terceiro número ");
      num3 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o quarto número ");
      num4 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o quinto número ");
      num5 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"O resultado da soma dos 5 números é: {num1 + num2 + num3 + num4 + num5}");
    }
     private static void Atv2questão2()
    {
        int num1, num2;
        Console.WriteLine("\nInforme o primeiro número ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
    }
     private static void Atv2questão3()
    {
        int num;
        Console.WriteLine("\nInforme um número ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nO dobro do número é: {num * 2}");
    }
     private static void Atv2questão4()
    {
        decimal nota1, nota2, nota3;
        Console.WriteLine("\nInforme a primeira nota ");
        nota1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota ");
        nota2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota ");
        nota3 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"\nMédia: {(nota1 + nota2 + nota3) / (3)} ");
    }
     private static void Atv2questão5()
    {
        int num1, num2;
        Console.WriteLine("\nInforme o primeiro número ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("informe o segundo número ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"resultado da multiplicação: {num1 * num2}");
    }
     private static void Atv2questão6()
    {
        int num;
        Console.WriteLine("\nDigite um número ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A metade do número é: {num / 2}");
    }
     private static void Atv2questão7()
    {
        decimal prod, desc;
        Console.WriteLine("Informe o valor do produto ");
        prod = Convert.ToDecimal(Console.ReadLine());
        desc = prod * 0.1M;
        Console.WriteLine($"Valor final: {prod - desc}");
    }
    private static void Atv3questão1()
    {
        int num;
        Console.WriteLine("\nDigite um número ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 20) {
            Console.WriteLine("O número digitade é maior que 20");
        }
        else {
            Console.WriteLine("O número digitado não é maior que 20");
        }
    }
      private static void Atv3questão2()
    {
        int num1, num2, ad;
        Console.WriteLine("\nDigite o primeiro número ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número ");
        num2 = Convert.ToInt32(Console.ReadLine());
        ad = num1 + num2;
        if (ad > 10) {
            Console.WriteLine($"\nResultado da adição: {ad}\nO resultado é maior que 10");
        }
        else {
            Console.WriteLine($"\nResultado da adição: {ad}\nO resultado é menor que 10");
        }
    }
      private static void Atv4questão1()
    {
        decimal kwv;
        Console.WriteLine("\nInforme a quantidade de kWv consumidos");
        kwv = Convert.ToDecimal(Console.ReadLine());
        if (kwv > 100){
            Console.WriteLine($"Quantidade consumida: {kwv}\nValor total a pagar: {0.90m * kwv}");
        }
        else {
            Console.WriteLine($"Quantidade consumida: {kwv}\nValor total a pagar: {0.75m * kwv}");
        }
    }
      private static void Atv3questão29()
    {
        int dia;
        Console.WriteLine("\nDigite um número entre 1 e 7");
        dia = Convert.ToInt32(Console.ReadLine());
        if (dia == 1) {
        Console.WriteLine("Dia da semana correspondente: Domingo");
        }
        else if (dia == 2) {
        Console.WriteLine("Dia da semana correspondente: Segunda-feira");
        }
        else if (dia == 3) {
        Console.WriteLine("Dia da semana correspondente: Terça-feira");
        }
        else if (dia == 4) {
        Console.WriteLine("Dia da semana correspondente: Quarta-feira");
        }
        else if (dia == 5) {
        Console.WriteLine("Dia da semana correspondente: Quinta-feira");
        }
        else if (dia == 6) {
        Console.WriteLine("Dia da semana correspondente: Sexta-feira");
        }
        else if (dia == 7) {
        Console.WriteLine("Dia da semana correspondente: Sábado");
        }
        else {
        Console.WriteLine("Não existe dia da semana com esse número");
        }
    }
    private static void Atv3questão24()
    {
        int a, b, c;
        Console.WriteLine("\nInforme o primeiro número");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme o segundo número");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInforme o terceiro número");
        c = Convert.ToInt32(Console.ReadLine());
        if (a + b > c && a + c > b && b + c > a) {
            Console.WriteLine("Os valores podem ser lados de um triângulo");
        }
        else {
            Console.WriteLine("os valores não podem ser lados de um triãngulo");
        }
    }
     private static void Atv4questão9()
    {
        int num1, num2, op;
        Console.WriteLine("\ninforme o primeiro número ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o segundo número ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha a opção desejada\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nInforme aqui:");
        op = Convert.ToInt32(Console.ReadLine());
            if (op == 1){
                Console.WriteLine($"O resultado da soma é: {num1 + num2}");
            }
            else if (op == 2){
                Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
            }
            else if (op == 3){
                Console.WriteLine($"O resultado da Multiplicação é: {num1 * num2}");
            }
            else if (op == 4 && num2 != 0){
                Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
            }
            else if (op == 4 && num2 == 0) {
                Console.WriteLine("Não é possivel fazer divisão por 0!");
            }
            else {
                Console.WriteLine("Opção não disponovel!!");
            }
        }
    }
