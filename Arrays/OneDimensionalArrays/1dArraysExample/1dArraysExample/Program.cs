// Declare a single-dimensional array default initialized
int[] numbers = new int[5]; // All values are 0
string[] messages = new string[5]; // All values are null.
var doubleNumbers = new Double[5]; // All values are 0


//Change initial values
messages[0] = "Hello";

//Change initial values
doubleNumbers[0] = 1.1;
doubleNumbers[1] = 2.2;
doubleNumbers[2] = 3.3;
doubleNumbers[3] = 4.4;
doubleNumbers[4] = 5.5;


// Declare a single-dimensional array with initialization.
int[] numbers2 = [1, 2, 3, 4, 5, 6];
string[] programmingLanguages = { "C#", "Java", "PHP", "SQL" }; // Alternative syntax: used before C# 12



// Print all the numbers
foreach (var number in numbers)
{
    Console.WriteLine(number); // for not insert new line each time:  Console.Write(number);
}

Console.WriteLine(string.Join(", ", messages));
Console.WriteLine(string.Join(", ", doubleNumbers));


Console.WriteLine(string.Join(", ", numbers2));
Console.WriteLine(string.Join(", ", programmingLanguages));



