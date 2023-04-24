// Missão 4

using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Ler a altura da pessoa
        Console.Write("Digite a altura da pessoa (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        // Ler o sexo da pessoa
        Console.Write("Digite o sexo da pessoa (M para masculino e F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcular o peso ideal da pessoa de acordo com o sexo
        double pesoIdeal;
        if (sexo == 'M') // 1) aqui estava assim "char.ToLower(sexo)"
        {
            pesoIdeal = (72.7 * altura) - 58; // 2) no lugar de * estava +
        }
        else if (sexo == 'F') // 3) aqui estava assim "char.ToLower(sexo)"
        {
            pesoIdeal = (62.1 * altura) - 44.7; // 4) estava faltando multiplicar o 62.1 pela altura
        }
        else
        {
            Console.WriteLine("Sexo inválido.");
            return;
        }
        // Escrever o peso ideal da pessoa
        Console.WriteLine("O peso ideal da pessoa é " + pesoIdeal.ToString("F2") + " kg."); // 5) aqui faltou um ; e eu também adicionei o To String para limitar 2 casas decimais
    }
} // 6) aqui havia faltado um }
