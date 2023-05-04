// Missão 2

using System.Data;

Console.WriteLine("Participantes do amigo secreto:");

string[] listaNomes = new string[8];
for (int i = 0; i < listaNomes.Length; i++)
{
    listaNomes[i] = Console.ReadLine();
}


Random rnd = new Random();

List<int> indicesAleatorios = Enumerable.Range(0, listaNomes.Length).OrderBy(x => rnd.Next()).ToList();

Console.WriteLine("Resultado do amigo secreto:");

for (int i = 0; i < listaNomes.Length; i++)
{
    int amigoSecretoIndex = (i + 1) % listaNomes.Length;
    if (amigoSecretoIndex == i) amigoSecretoIndex = (i + 2) % listaNomes.Length;

  
    Console.WriteLine(listaNomes[i] + " -> " + listaNomes[indicesAleatorios[amigoSecretoIndex]]);
}






