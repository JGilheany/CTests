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



using System;

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
        bool found = true;

        if (found)
        {
            Console.WriteLine("Set contains 42");
        }

    }
}

Console.WriteLine($"Total: {total}");
