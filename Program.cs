using System;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("---------------Sistema de estoque (Armazenamento de produtos)----------------");
            Console.WriteLine("----------------------------------------------------------"); 
            Console.ResetColor();

            //Variáveis globais
            string escolha = "";
            int i = 0;
            string respPromo = "";
            string[] nomes = new string[10];
            float[] preco = new float[10];
            bool promocao;
            float[] valorPromo = new float[10];

            do{
            Console.WriteLine("Menu inicial");
            MostrarMenu(escolha);

            switch(escolha)
            {
                case "1":
                    //Cadastrar Passagens
                    string resposta;
                    do
                    {
                        if(i < 10)
                        {
                            System.Console.WriteLine($"Nome do {i+1}° produto: ");
                            nomes[i] = Console.ReadLine();
                            System.Console.WriteLine($"Preço do {i+1}° produto: ");
                            preco[i] = float.Parse(Console.ReadLine());
                            System.Console.WriteLine($"Existe promoção para o {i+1}° produto? s/n");
                            respPromo = Console.ReadLine();
                            if(respPromo == "s"){
                                promocao = true;
                                System.Console.WriteLine($"Qual o valor da promoção?");
                                valorPromo[i] = float.Parse(Console.ReadLine());
                            }
                            i++;
                        } else {
                            System.Console.WriteLine("Limite de produtos excedidos!");
                        }

                        System.Console.WriteLine("Gostaria de cadastrar outro produto? s/n");
                        resposta = Console.ReadLine();

                    } while(resposta == "sim" || resposta == "Sim" || resposta == "s");
                break;

                case "2":
                    //Listar Produtos4

                    for( var cont = 0 ; cont < nomes.Length ; cont++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                            System.Console.WriteLine($"Produto {cont}: {nomes[cont]}");
                            System.Console.WriteLine($"Preço do {nomes[cont]}: {preco[cont]}");
                            System.Console.WriteLine($"Está em promoção? {respPromo}");
                            System.Console.WriteLine($"Valor com desconto: {Desconto(preco[cont] , valorPromo[cont])}");
                        Console.ResetColor();
                    };
                break;

                case "3":
                    //Mostrar menu
                    Console.Clear();
                    MostrarMenu(escolha);
                break;

                case "4":
                    Console.Clear();
                break;

                default:

                break;
            }

        } while (escolha != "4");
        

        //Funções
            double Desconto(float valor , float desconto){
                float descProduto = valor - desconto;
                return descProduto;
            }

            void MostrarMenu(string Menu){
                Console.WriteLine("Selecione uma das opções");
                System.Console.WriteLine("[1] - Cadastrar Produtos");
                System.Console.WriteLine("[2] - Listar Produtos");
                System.Console.WriteLine("[3] - Mostrar Menu");
                System.Console.WriteLine("[4] - Sair");
                escolha = Console.ReadLine();
            }
        }
    }
}
