using System;

class GeradordeNumeroAleatorio
{
    static void Main()
    {
        // Cria uma instância da classe Random para gerar números aleatórios
        Random aleatorio = new Random();

        // Gera um número aleatório entre 1 e 100
        int numeroSecreto = aleatorio.Next(1, 101);

        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100:");

        // Inicia um loop que continua até que o número seja acertado
        do
        {
            Console.Write("Digite um número entre 1 e 100: ");

            // Lê a entrada do usuário
            string? entrada = Console.ReadLine();

            // Verifica se a entrada não é nula e tenta fazer o parse para inteiro
            if (int.TryParse(entrada, out int chute))
            {
                // Verifica se o palpite do usuário está correto
                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou o número.");
                    break; // Sai do loop se o número foi acertado
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é maior."); 
                }
                else
                {
                    Console.WriteLine("O número é menor."); 
                }
            }
            else
            {
                // Mensagem de erro para entradas inválidas
                Console.WriteLine("Por favor, digite um número válido.");
            }

        } while (true); // O loop continua indefinidamente até que o número seja acertado

        Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
    }
}
