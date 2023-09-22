using System;

Console.WriteLine("Welcome to the Console Application!");

// Ask the user for their Citzenship status
Console.Write("Are you a natrual born citzen (true/false): ");
string? citzenStatus = Console.ReadLine();
bool citzenStatusBool;

bool.TryParse(citzenStatus, out citzenStatusBool);

Console.WriteLine(citzenStatusBool);

Console.Write("What is your birth year: ");
string? age = Console.ReadLine();
int ageInt = int.Parse(age);

Console.WriteLine(ageInt);

Console.Write("How many years have you resided in the US: ");
string? yearsUS = Console.ReadLine();
int yearsUSInt = int.Parse(yearsUS);

Console.WriteLine(yearsUSInt);

Console.Write("How many terms have you served: ");
string? terms = Console.ReadLine();
int termsInt = int.Parse(terms);

Console.WriteLine(termsInt);

Console.Write("Have you rebelled against the US (true/false): ");
string? rebelled = Console.ReadLine();
bool rebellStatusBool;

bool.TryParse(rebelled, out rebellStatusBool);

Console.WriteLine(rebellStatusBool);

if (citzenStatusBool & ageInt < 1989 & termsInt < 2 & !rebellStatusBool & yearsUSInt > 13)
{
    Console.WriteLine("You are eligible to run for El Presedante!");
}
else
{
    Console.WriteLine("You are not eligible to run for El Presedante!");
}

