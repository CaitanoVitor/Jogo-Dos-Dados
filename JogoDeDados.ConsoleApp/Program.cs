using System.Security.Cryptography;

const int limiteLinhaChegada = 30;
const int bonusDeAvancoExtra = 3;
const int recuoDePosicao = 2;

while (true)
{
    Console.Clear();
    int posicaoJogador = 0;

    while (true)
    {
        Console.Clear();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("JOGO DOS DADOS");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Rodada do Jogador");
        Console.WriteLine("-------------------------------------");

        Console.Write("Precione ENTER para lançar o DADO...");
        Console.ReadLine();

        int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoJogador += resultadoJogador;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O numero do resultado foi: " + resultadoJogador);
        Console.WriteLine("-------------------------------------");

        Console.WriteLine($"Você esta na posição: {posicaoJogador} de {limiteLinhaChegada}");

        if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
        {
            Console.WriteLine($"\nBônus: Avanço de {bonusDeAvancoExtra} casas");
            posicaoJogador += bonusDeAvancoExtra;
            Console.WriteLine($"\nVocê esta na posição: {posicaoJogador} de {limiteLinhaChegada}");
        }
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {
            Console.WriteLine($"\nEvento: recuo de {recuoDePosicao} casas");
            posicaoJogador -= recuoDePosicao;
            Console.WriteLine($"\nVocê esta na posição: {posicaoJogador} de {limiteLinhaChegada}");
        }

        if (posicaoJogador >= limiteLinhaChegada)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Você alcancou a linhda de chegada! ");
            Console.WriteLine("-------------------------------------");
            Console.Write("Precione ENTER para continuar...");
            Console.ReadLine();

            break;
        }

        Console.WriteLine("-------------------------------------");
        Console.Write("Precione ENTER para continuar...");
        Console.ReadLine();


    }


    Console.WriteLine("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine()?.ToUpper();

    if (opcaoContinuar != "S")
        break;



}
