// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));


// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// var rand = new Random();

// // Generate and display 5 random integers between 0 and 100.
// Console.WriteLine("Five random integers between 0 and 100:");
// for (int ctr = 0; ctr <= 4; ctr++)
//     Console.Write(ctr);
//     Console.Write("{0,8:N0}", rand.Next(2));

// Console.WriteLine();

// var rand = new Random();
// int coin = rand.Next(2);

// Console.WriteLine((coin == 0) ? "Heads" : "Tails");


// string permission = "Admin|Manager";
// int level = 56;

// if (permission.Contains("Admin")){
//     if(level > 55){
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//         else {Console.WriteLine("Welcome, Admin User"); }
// }

// else if (permission.Contains("Manager")){
//     if (level >= 20){
//     Console.WriteLine("Contact an Admin for access.");
//     }
//     else {Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else {Console.WriteLine("You do not have sufficient privileges");
// }


// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine($"Outside of code block: {value}");


// bool flag = true;
// if (flag)
// {
//     Console.WriteLine(flag);
// }

// string name = "steve";
// if (name == "bob") 
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else 
//     Console.WriteLine("Found Chuck");



// using System;

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {

//     total += number;

//     if (number == 42)
//     {
//         bool found = true;

//         if (found)
//         {
//             Console.WriteLine("Set contains 42");
//         }

//     }
// }

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");




// // SKU = Stock Keeping Unit. 
// // SKU value format: <product #>-<2-letter color code>-<size code>

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// // Creates grid for game

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Assuming y_axis and x_axis are arrays of strings
//         var y_axis = new string[] {"A", "B", "C", "D", "E", "F"};
//         var x_axis = new string[] {"1", "2", "3", "4", "5", "6"};

//         var grid = new List<string>();
//         foreach (var a in y_axis)
//         {
//             foreach (var b in x_axis)
//             {
//                 grid.Add(a + b);
//             }
//         }
//         Console.WriteLine(string.Join(" ", grid));
//     }
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name); 

// for (int i = 1; i < 101; i++);{
    
//     if(((i % 3) == 0) && ((i % 4) == 0));
//         Console.WriteLine($"{i} Fizz");
//     else Console.WriteLine(i);

// }


// // FizzBuzz
// for (int i = 1; i < 101; i++)
// {
//     if(((i % 3) == 0) && ((i % 4) == 0))
//         Console.WriteLine($"{i} FizzBuzz");
    
//     else if ((i % 3) == 0)
//         Console.WriteLine($"{i} Fizz");    

//     else if ((i % 5) == 0)
//         Console.WriteLine($"{i} Buzz");    
    
//     else Console.WriteLine(i);
// }

// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// /*
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");
// */


Random random = new Random();
int atkhero = random.Next(1, 11);
int atkmonst = random.Next(1, 11);
int hphero = 10;
int hpmonst = 10;

do
{
    atkhero = random.Next(1, 11);
    hpmonst = hpmonst - atkhero;
    Console.WriteLine($"The Hero swung for {atkhero} damage! The monster has {hpmonst} health left.");
    if (hpmonst <= 0) break;

    atkmonst = random.Next(1, 11);
    hphero = hphero - atkmonst;
    Console.WriteLine($"The Monster swung for {atkmonst} damage! The hero has {hphero} health left.");
    if (hphero <= 0) break;


} while (hphero > 0 && hpmonst > 0);

// Console.WriteLine(hphero);
// Console.WriteLine(hpmonst);

if (hphero > hpmonst){
    Console.WriteLine("Huzzah! The monster has been vanquished");
}
else Console.WriteLine("The hero has been slain!");
