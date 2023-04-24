// Missão 2

using System.Data;

Console.WriteLine("Participantes do amigo secreto:");

string[] listaNomes = new string[8];
for (int i = 0; i < listaNomes.Length; i++)
{
    listaNomes[i] = Console.ReadLine();
}

Console.WriteLine("Resultado do amigo secreto:");
for (int i = 0; i < 1; i++)
{
    Console.WriteLine(listaNomes[0] + " -> " + listaNomes[5]);
    Console.WriteLine(listaNomes[1] + " -> " + listaNomes[4]);
    Console.WriteLine(listaNomes[2] + " -> " + listaNomes[7]);
    Console.WriteLine(listaNomes[3] + " -> " + listaNomes[6]);
}





