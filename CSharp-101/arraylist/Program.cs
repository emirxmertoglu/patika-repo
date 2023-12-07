using System.Collections;

ArrayList list = new() { 1, 2, 3, 4, 5, };

foreach (var item in list)
{
    Console.WriteLine(item);
}

// AddRange
Console.WriteLine("**** AddRange ****");
string[] strArr = { "emir", "halil", "mehmet" };
list.AddRange(strArr);

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Add
Console.WriteLine("**** Add ****");
list.Add('a');
list.Add(5.44);
list.Add(false);

foreach (var item in list)
{
    Console.WriteLine(item);
}

// Sort
ArrayList intList = new() { 55, 44, 33, 22, 11 };

foreach (var item in intList)
{
    Console.WriteLine(item);
}

Console.WriteLine("**** Sort ****");

intList.Sort();
foreach (var item in intList)
{
    Console.WriteLine(item);
}

// Reverse
Console.WriteLine("**** Reverse ****");
intList.Reverse();
foreach (var item in intList)
{
    Console.WriteLine(item);
}

// BinarySearch
Console.WriteLine("**** BinarySearch ****");
int index = intList.BinarySearch(33);
Console.WriteLine(index);

// Clear
Console.WriteLine("**** Clear ****");
intList.Clear();
foreach (var item in intList)
{
    Console.WriteLine(item);
}