using System;

Console.WriteLine("First Name>");
string firstName = Console.ReadLine();

Console.Write("Last Name>");
string lastName = Console.ReadLine();

string reverse = "";
string fullName = firstName + " " + lastName;
for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}

Console.WriteLine(reverse);

// for (int num = 1; num < 11; ++num)

// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }