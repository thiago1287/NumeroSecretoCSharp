Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine()!);

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns!!!! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else if (chute > numeroSecreto)
    {
        Console.WriteLine("O número secreto é menor.");
    }
}
while (true);