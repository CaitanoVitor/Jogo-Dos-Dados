using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        const int limiteLinhaChegada = 30;
        const int bonusDeAvancoExtra = 3;
        const int recuoDePosicao = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            while (true)
            {

                posicaoJogador = ExecutorRodadaJogador(posicaoJogador, limiteLinhaChegada, bonusDeAvancoExtra, recuoDePosicao);

                ApresentarMensagemDoJogador(posicaoJogador, limiteLinhaChegada);
                if (posicaoJogador >= limiteLinhaChegada)
                    break;

                posicaoComputador = ExecutorRodadaComputador(posicaoComputador, limiteLinhaChegada, bonusDeAvancoExtra, recuoDePosicao);

                ApresentarMensagemDoComputador(posicaoComputador, limiteLinhaChegada);
                if (posicaoComputador >= limiteLinhaChegada)
                    break;


            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;



        }


    }

    static int ExecutorRodadaJogador
           (
           int posicaoJogador,
           int limiteLinhaChegada,
           int bonusDeAvancoExtra,
           int recuoDePosicao
           )
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
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20 || posicaoJogador == 28)
        {
            Console.WriteLine($"\nEvento: recuo de {recuoDePosicao} casas");

            posicaoJogador -= recuoDePosicao;

            Console.WriteLine($"\nVocê esta na posição: {posicaoJogador} de {limiteLinhaChegada}");
        }

        return posicaoJogador;
    }

    static void ApresentarMensagemDoJogador(int posicaoJogador, int limiteLinhaChegada)
    {
        if (posicaoJogador >= limiteLinhaChegada)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Você alcancou a linhda de chegada! ");
            Console.WriteLine("-------------------------------------");
            Console.Write("Precione ENTER para continuar...");
           
            Console.ReadLine();

        }
        else
        {

            Console.WriteLine("-------------------------------------");
            Console.Write("Precione ENTER para continuar...");
           
            Console.ReadLine();

        }

    }

    static int ExecutorRodadaComputador(
        int posicaoComputador,
        int limiteLinhaChegada,
        int bonusDeAvancoExtra,
        int recuoDePosicao)
    {
        Console.Clear();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("JOGO DOS DADOS");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Rodada do Computador");
        Console.WriteLine("-------------------------------------");

        Console.Write("Precione ENTER para o computador lançar o DADO...");
        Console.ReadLine();

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoComputador += resultadoComputador;


        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O numero do resultado do computador foi: " + resultadoComputador);
        Console.WriteLine("-------------------------------------");

        Console.WriteLine($"O computador esta na posição: {posicaoComputador} de {limiteLinhaChegada}");

        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
        {
            Console.WriteLine($"\nBônus: Avanço de {bonusDeAvancoExtra} casas");

            posicaoComputador += bonusDeAvancoExtra;

            Console.WriteLine($"\nO computador esta na posição: {posicaoComputador} de {limiteLinhaChegada}");
        }
        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20 || posicaoComputador == 28)
        {
            Console.WriteLine($"\nEvento: recuo de {recuoDePosicao} casas");

            posicaoComputador -= recuoDePosicao;

            Console.WriteLine($"\nO computador esta na posição: {posicaoComputador} de {limiteLinhaChegada}");
        }
        return posicaoComputador;
    }

    static void ApresentarMensagemDoComputador(int posicaoComputador, int limiteLinhaChegada)
    {
        if (posicaoComputador >= limiteLinhaChegada)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Computador alcancou a linhda de chegada! ");
            Console.WriteLine("-------------------------------------");
            Console.Write("Precione ENTER para continuar...");
           
            Console.ReadLine();

        }
        else
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("Precione ENTER para continuar...");
            
            Console.ReadLine();
        }

    }

}

