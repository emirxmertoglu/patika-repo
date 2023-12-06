List<int> numberList = new();
numberList.Add(11);
numberList.Add(23);
numberList.Add(34);
numberList.Add(45);
numberList.Add(56);

List<string> colorList = new();
colorList.Add("Red");
colorList.Add("Blue");
colorList.Add("Green");
colorList.Add("Yellow");   
colorList.Add("White");

// Count
Console.WriteLine($"Number of elements in numberList: {numberList.Count}");
Console.WriteLine($"Number of elements in colorList: {colorList.Count}");
Console.WriteLine("###########");

// ForEach
numberList.ForEach(number => Console.WriteLine(number));
Console.WriteLine("###########");
colorList.ForEach(color => Console.WriteLine(color));

// Remove
numberList.Remove(23);
colorList.Remove("Blue");

// RemoveAt
numberList.RemoveAt(0);
colorList.RemoveAt(0);

Console.WriteLine("###########");
numberList.ForEach(number => Console.WriteLine(number));
Console.WriteLine("###########");
colorList.ForEach(color => Console.WriteLine(color));
Console.WriteLine("###########");

// Contains
Console.WriteLine($"Is 11 in numberList: {numberList.Contains(11)}");

// BinarySearch
Console.WriteLine("###########");
Console.WriteLine($"Index of 45 in numberList: {numberList.BinarySearch(45)}");
Console.WriteLine("###########");

// Array to List
string[] animals = {"Cat", "Dog", "Bird", "Fish"};
List<string> animalList = new(animals);
animalList.ForEach(animal => Console.WriteLine(animal));

// Clear
Console.WriteLine("###########");
animalList.Clear();
animalList.ForEach(animal => Console.WriteLine(animal));

List<Person> personList = new()
{
    new Person { Name = "John", Age = 25 },
    new Person { Name = "Jane", Age = 30 },
    new Person { Name = "Jack", Age = 35 }
};

foreach (Person person in personList)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}