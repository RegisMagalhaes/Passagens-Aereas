using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string senha;
            bool senhaValida;
            int escolha;
            string resposta;
            int contador = 0;

            //Dados da Passagem

            string[] nomes = new string[2];
            string[] origem = new string[2];
            string[] destino = new string[2];
            string[] data = new string[2];




            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-Sistema de Passagens Aéreas-");
            Console.WriteLine("-----------------------------");

            //Loguin
            do
            {
                Console.WriteLine("Digite a senha para acessar o sistema: ");
                senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
                
            } while (!senhaValida);
            
            //Menu

            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo:");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Listar passagem");
                Console.WriteLine("[0] - Sair");

                escolha = int.Parse(Console.ReadLine());

                 switch (escolha)
            {
                case 1:
                    Console.WriteLine("Cadastro de Passageiro ");
                    do
                    {
                        if (contador<5)
                        {
                            Console.WriteLine($"Digite o nome do {contador+1} º passageiro: ");
                            nomes[contador]=Console.ReadLine();
                            Console.WriteLine("Digite o destino passageiro: ");
                            destino[contador]=Console.ReadLine();
                            Console.WriteLine("Digite a data do vôo: ");
                            data[contador]=Console.ReadLine();
                            Console.WriteLine("Digite a origem do passageiro: ");
                            origem[contador]=Console.ReadLine();
                            contador++;
                            
                        }else{
                            Console.WriteLine("Limite excedido!");
                        }
                        
                        Console.WriteLine("Você gostaria de cadastrar um novo passageiro? S-Sim/N-Não");
                        resposta = Console.ReadLine();
                    } while (resposta.ToUpper() == "S");
                    break;
                case 2:
                    Console.WriteLine("Listar Passagem");
                    for (var i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Passageiro:{nomes[i]} data do vôo: {data[i]} origem: {origem[i]} destino: {destino[i]}");
                    }
                    break;
                case 0:
                    Console.WriteLine("Obrigado por viajar na Tsukamoto Airlines!");
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
            } while (escolha!= 0);


            //Processamento
            bool EfetuarLogin(string senha){
                if (senha == "123456")
                {
                    Console.WriteLine("Senha válida");
                    return true;
                }else{
                    Console.WriteLine("Senha inválida, Tente novamente!");
                    return false;
                }
            }
        }
    }
}
