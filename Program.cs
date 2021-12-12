using System;

namespace ProjetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            string opcao;
            int valor1, valor2, minuendo, subtraendo, multiplicador, multiplicando;
            double resultado = 0, diferença = 0, produto = 0, raiz, indice = 0, radicando;
            double numerador, denominador, quociente, vl1, expoente, potencia;

            while (contador > 0)
            {

                Console.WriteLine("\nOlá usuário escolha umas das opções do menu a seguir:");

                Console.WriteLine("Digite a tecla 1:Para executar uma operação de soma");
                Console.WriteLine("Digite a tecla 2:Para executar uma operação de subtração");
                Console.WriteLine("Digite a tecla 3:Para executar uma operação de multiplicação");
                Console.WriteLine("Digite a tecla 4:Para executar uma operação de divisão");
                Console.WriteLine("Digite a tecla 5:Para executar uma operação de potenciação");
                Console.WriteLine("Digite a tecla 6:Para executar uma operação de radiciação");
                Console.WriteLine("Digite a tecla c:Para saber mais sobre a desenvolvedora do menu");
                Console.WriteLine("Digite 0 para sair");
                Console.Write("Digite aqui sua opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nDigite os valores a serem somados");
                        Console.Write("Digite o primeiro valor.:");
                        valor1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o segundo valor..:");
                        valor2 = Convert.ToInt32(Console.ReadLine());

                        resultado = valor1 + valor2;
                        Console.WriteLine($"{valor1} mais {valor2} é {resultado}");
                        break;

                    case "2":
                        Console.WriteLine("\nDigite os valores a serem subtraído");
                        Console.Write("Digite o minuendo...:");
                        minuendo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o subtraendo.:");
                        subtraendo = Convert.ToInt32(Console.ReadLine());

                        diferença = minuendo - subtraendo;
                        Console.WriteLine($"{minuendo} menos {subtraendo} é {diferença}");
                        break;

                    case "3":
                        Console.WriteLine("\nDigite os valores a serem multiplicados");
                        Console.Write("Digite o multiplicador ..:");
                        multiplicador = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite o multiplicando...:");
                        multiplicando = Convert.ToInt32(Console.ReadLine());

                        produto = multiplicador * multiplicando;
                        Console.WriteLine($"{multiplicador} multiplicado por {multiplicando} è {produto}");
                        break;

                    case "4":
                        Console.WriteLine("\nDigite os valores a serem dividos");
                        Console.Write("Digite o numerador....:");
                        numerador = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o denominador..:");
                        denominador = Convert.ToDouble(Console.ReadLine());

                        quociente = numerador / denominador;
                        Console.WriteLine($"{numerador} dividido por {denominador} é {quociente}");
                        break;

                    case "5":
                        Console.WriteLine("\nDigite os valores");
                        Console.Write("Digite o base.....:");
                        vl1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o expoente.:");
                        expoente = Convert.ToDouble(Console.ReadLine());

                        potencia = Math.Pow(vl1, expoente);
                        Console.WriteLine($"{vl1} elevado a {expoente} potência é {potencia}");
                        break;

                    case "6":
                        Console.WriteLine("\nDigite os valores desejado");
                        Console.Write("Digite o radicando.:");
                        radicando = Convert.ToDouble(Console.ReadLine());

                        raiz = Math.Sqrt(radicando);
                        Console.WriteLine($"a raiz quadrada de {radicando} é igua a {raiz}");
                        break;

                    case "c":
                        Console.WriteLine("Me chamo Ana Paula Veloso");
                        Console.WriteLine("Estudante do Aracy da Silva Freitas");
                        Console.WriteLine("Cursando informática na Etec Adolpho Berezin");
                        Console.WriteLine("Sou a desenvolvedora desse programa");
                        Console.WriteLine("\nLink do Acesso:https://github.com/AnaPaulaVeloso/ProjetoFinal");

                        Console.Write("Pressione Enter para continuar");
                        Console.ReadKey();
                        break;

                    case "0":
                        contador = 0;
                        break;
                    default:
                        Console.Write("Não existe essa opção no menu");
                        break;
                }
            }
        }
    }
}
