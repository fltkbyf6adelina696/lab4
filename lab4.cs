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
Console.WriteLine("������� n");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for(int i = 0;i<n;i++)
{
Console.WriteLine("������� {0}-� �������", i + 1);
a[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("�� ����������: ");
foreach (int i in a)
Console.Write("\t{0}", i);

Array.Sort(a);

Console.WriteLine("\n����� ����������:");
foreach (int i in a)
Console.Write("\t{0}", i);
Console.ReadKey();

}
}
}