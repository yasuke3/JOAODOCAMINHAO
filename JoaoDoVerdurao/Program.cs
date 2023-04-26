using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JoaoDoVerdurao
{
    internal class Program
    {
      


    
             private static int cont;
        private static object resp;
        private static int dia;
        int num1 = 0; int num2 = 0;

        private static void Main(string[] args)

        {

            string placaCaminhao;
            string resp;

            do 
            {
                {
                    string senhaCorreta = "joao123";
                    int tentativasRestantes = 3;

                    while (tentativasRestantes > 0)
                    {
                        Console.Write("Digite a senha: ");
                        string senhaDigitada = Console.ReadLine();

                        if (senhaDigitada == senhaCorreta)
                        {
                            Console.WriteLine("Senha correta!");
                            break;
                        }
                        else
                        {
                            tentativasRestantes--;
                            Console.WriteLine($"Senha incorreta. Restam {tentativasRestantes} tentativas.");

                            if (tentativasRestantes == 0)
                            {
                                Console.WriteLine("Você excedeu o número  de tentativas incorretas. Sua conta foi bloqueada!");

                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }
                }





                Console.WriteLine("Ola tudo bem?  Qual Melancia deseja comprar?");
             
                Console.WriteLine(" 1- Melancia Comum   2- Melancia Baby");

                int op = int.Parse(Console.ReadLine());
                double preco; 


                if (op == 1)
                {
                    preco = 5.50;
                    Console.WriteLine(" Melancia Comum " + preco.ToString());
                }
                else if (op == 2)
                {
                    preco = 8.56;
                    Console.WriteLine(" Melancia Baby " + preco.ToString());
                }
                else
                {
                    Console.WriteLine("Não há essa opção!");
                }


                {
                    Console.WriteLine("Escolha um dia da semana para receber as melancias (sendo 2-segunda e 6-sexta)");


                    int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 2:
                            Console.WriteLine(" Segunda com ");
                            break;
                        case 3:
                            Console.WriteLine(" TERÇA VERDE com 15% DE DESCONTO!!");
                            break;
                        case 4:
                            Console.WriteLine(" QUARTA com 20% de desconto!!");
                            break;
                        case 5:
                            Console.WriteLine(" Quinta");
                            break;
                        case 6:
                            Console.WriteLine("Sexta");
                            break;
                        default:
                            Console.WriteLine("Opção");
                            break;
                    }
                }


                Console.WriteLine("Regitre a placa do caminhão aqui:");
                placaCaminhao = Console.ReadLine();

                string tamanho = placaCaminhao.Length.ToString();
                string letras = placaCaminhao.Remove(1, 1);
                Console.WriteLine(letras);

                {
                    Console.WriteLine("O caminhão cadastrado possui a placa :" + placaCaminhao);
                }


                {
                    int numItens = 0;
                    double totalCompra = 0.0;

                    Console.WriteLine("Quantas melancias deseja comprar?:");
                    numItens = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= numItens; i++)
                    {
                        Console.WriteLine("Qual o valor da melancia?: " + i);
                        double valorItem = Convert.ToDouble(Console.ReadLine());
                        totalCompra += valorItem;
                    }

                    Console.WriteLine("O total da compra é: R$ " + totalCompra.ToString("F2"));
                }

                Console.WriteLine("Obrigado por comprar aqui, volte sempre que precisar de melancias!!! ");

                Console.WriteLine("Voce deseja sair ? Sim ou Não");
                resp = Console.ReadLine();
            } while (resp.ToUpper() != "SIM");

            


        }
    }
}

//plk9090