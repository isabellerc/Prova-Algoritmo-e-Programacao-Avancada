// Missão 1

using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Ler a hora de início do jogo
        Console.Write("Digite a hora de início do jogo (hora:minuto): ");
        string[] inicioJogo = Console.ReadLine().Split(':'); //inicio passou a ser inicioJogo
        int horaInicial = int.Parse(inicioJogo[0]); //hi passou a ser horaInicial
        int minutoInicial = int.Parse(inicioJogo[1]); //mi passou a ser minutoInicial

        // Ler a hora de término do jogo
        Console.Write("Digite a hora de término do jogo (hora:minuto): ");
        string[] fimJogo = Console.ReadLine().Split(':'); //fim passou a ser fimJogo
        int horaFinal = int.Parse(fimJogo[0]); //hf passou a ser horaFinal
        int minutoFinal = int.Parse(fimJogo[1]); //mf passou a ser minutoFinal

        // Calcular a duração do jogo em minutos
        int duracaoJogoMinutos = (horaFinal * 60 + minutoFinal) - (horaInicial * 60 + minutoInicial); //dm passou a ser duracaoJogoMinutos

        // Tratar caso o jogo tenha ultrapassado 24 horas
        if (duracaoJogoMinutos < 0)
        {
            duracaoJogoMinutos += 1440;
        }
        // Calcular a duração do jogo em horas e minutos
        int duracaoJogoHoras = duracaoJogoMinutos / 60; //dh duracaoJogoHoras
        duracaoJogoMinutos = duracaoJogoMinutos % 60;

        // Escrever a duração do jogo
        Console.WriteLine("A duração do jogo foi de " + duracaoJogoHoras + " horas e " + duracaoJogoMinutos + " minutos.");
    }
}

