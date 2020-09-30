using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace massiv
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for(int i = 0;i<n;i++)
{
Console.WriteLine("Введите {0}-й элемент", i + 1);
a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("До сортировки: ");
foreach (int i in a)
Console.Write("\t{0}", i);

Array.Sort(a);

Console.WriteLine("\nПосле сортировки:");
foreach (int i in a)
Console.Write("\t{0}", i);
Console.ReadKey();

}
}
}