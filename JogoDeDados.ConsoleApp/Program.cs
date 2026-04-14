using System.Security.Cryptography;

const int limiteLinhaChegada = 30;
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

    if (posicaoJogador >= limiteLinhaChegada)
    {
        Console.WriteLine($"Você alcancou a linhda de chegada! ");
        Console.WriteLine("-------------------------------------");
        Console.Write("Precione ENTER para continuar...");
        Console.ReadLine();
    }

    Console.WriteLine("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine()?.ToUpper();

    if (opcaoContinuar != "S")
        break;



}