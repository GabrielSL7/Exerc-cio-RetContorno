using System;

class Program
{
    static void Main()
    {
        int largura, altura;

        do
        {
            Console.Write("Largura (1 a 10): ");
            largura = int.Parse(Console.ReadLine());
        } while (largura < 1 || largura > 10);

        do
        {
            Console.Write("Altura (1 a 10): ");
            altura = int.Parse(Console.ReadLine());
        } while (altura < 1 || altura > 10);

        for (int linha = 1; linha <= altura; linha++)
        {
            for (int coluna = 1; coluna <= largura; coluna++)
            {
                if (linha == 1 || linha == altura || coluna == 1 || coluna == largura)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
