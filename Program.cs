// See https://aka.ms/new-console-template for more information
/* Console.Write("give me the fucking numbers ");


int[] v  = { 7, -5, -8, 23, 11 };

for (int i = 0; i < v.GetLength(0); i++)
    Console.Write(v[i] + " ");*/



/*int[] v = { 7, -5, -8, 23, 11 };

foreach (int e in v)
{
    Console.Write(e + " ");
}
*/

/* int[] tallista = new int[5];
for (int i = 0; i < tallista.Length; i++)
{
    Console.Write("Ange tal " + (i + 1) + ": ");
    tallista[i] = int.Parse(Console.ReadLine());
}
int summa = 0;
foreach (int e in tallista)
{
    summa += e;
}
Console.WriteLine("talens summa: " + summa); */

int[] tal = [5];
for (int i = 0; i < tal.Length; i++)
{
    Console.Write("Ange tal " + (i + 1) + ": ");
    tal[i] = int.Parse(Console.ReadLine());
}
