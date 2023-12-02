string str = "Our lesson is CSharp, Welcome!";
string str2 = "Emir";

// Length
Console.WriteLine(str.Length);

// ToUpper, ToLower
Console.WriteLine(str.ToUpper());
Console.WriteLine(str.ToLower());

// Concat
Console.WriteLine(string.Concat(str, " ", str2));

// Compare, CompareTo
Console.WriteLine(str.CompareTo(str2));
Console.WriteLine(String.Compare(str, str2, true));
Console.WriteLine(String.Compare(str, str2, false));

// Contains
Console.WriteLine(str.Contains("CSharp"));
Console.WriteLine(str.StartsWith("Our"));
Console.WriteLine(str.EndsWith("Welcome Buddy!"));

// IndexOf
Console.WriteLine(str.IndexOf("CSharp"));
Console.WriteLine(str.IndexOf("Emir"));
Console.WriteLine(str.LastIndexOf("e"));

// Insert
Console.WriteLine(str.Insert(0, "Hello! "));

// PadLeft, PadRight
Console.WriteLine(str + str2.PadLeft(30));
Console.WriteLine(str + str2.PadLeft(30, '*'));
Console.WriteLine(str.PadRight(50) + str2.PadLeft(30, '-'));
Console.WriteLine(str.PadRight(50, '-') + str2.PadLeft(30, '#'));

// Remove
Console.WriteLine(str.Remove(15));
Console.WriteLine(str.Remove(5, 3));
Console.WriteLine(str.Remove(0, 1));

// Replace
Console.WriteLine(str.Replace("CSharp", "C#"));
Console.WriteLine(str.Replace(" ", "*"));

// Split
Console.WriteLine(str.Split(' ')[3]);

// Substring
Console.WriteLine(str.Substring(1));
Console.WriteLine(str.Substring(1, 6));