using System;
using static System.Console;

    class Progam
    {
        static void Demositch()
        {
            int mes;

            WriteLine("Digite o numero do mês do seu aniversario:");
            mes = int.Parse(ReadLine());

            switch(mes)
            {
                case 1:
                WriteLine("Janeiro");
                break;
                case 2:
                WriteLine("Fevereiro");
                break;
                case 3:
                WriteLine("Março");
                break;
                case 4:
                WriteLine("Abril");
                break;
                case 5:
                WriteLine("Maio");
                break;
                case 6:
                WriteLine("Junho");
                break;
                case 7:
                WriteLine("Julho");
                break;
                case 8:
                WriteLine("Agosto");
                break;
                case 9:
                WriteLine("Setembro");
                break;
                case 10:
                WriteLine("Outubro");
                break;
                case 11:
                WriteLine("Novembro");
                break;
                case 12:
                WriteLine("Dezembro");
                break;
                default:
                WriteLine("Mes invalido");
                break;
            }
        }
        static void Demoif()
        {
            int mes;
            mes = int.Parse(ReadLine());
            if(mes == 1)
            {
                WriteLine("Seu mês de aniversario é: Janeiro");
            }
            else if(mes == 2)
            {
                WriteLine("Seu mês de aniversario é: Fevereiro");
            }
            else if (mes == 3)
            {
                WriteLine("Seu mês de aniversario é: Março");
            }
            else if (mes == 4)
            {
                WriteLine("Seu mês de aniversario é: Abril");
            }
            else if (mes == 5)
            {
                WriteLine("Seu mês de aniversario é: Maio");
            }
            else if (mes == 6)
            {
                WriteLine("Seu mês de aniversario é: Junho");
            }
            else if (mes == 7)
            {
                WriteLine("Seu mês de aniversario é: Julho");
            }
            else if (mes == 8)
            {
                WriteLine("Seu mês de aniversario é: Agosto");   
            }
            else if (mes == 9)
            {
                WriteLine("Seu mês de aniversario é: Setembro");
            }
            else if (mes == 10)
            {
                WriteLine("Seu mês de aniversario é: Outubro");  
            }
            else if (mes == 11)
            {
                WriteLine("Seu mês de aniversario é: Novembro");
            }
            else if(mes == 12)
            {
                WriteLine("Seu mês de aniversario é: Dezembro");
            }
            else
            {
                WriteLine("Mes invalido");
            }
        }
        static void Demo1()
        {
            int valor1;
            int valor2;

            WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(ReadLine());
            WriteLine($"O primeiro valor é {valor1}");
            WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(ReadLine());
            WriteLine($"O segundo valor é {valor2}");

            var somaTotal = valor1 + valor2;

            WriteLine($"A soma dos dois valores sera: {somaTotal}");

        }
        static void Main(string[] args)
        {
            

        }
    }