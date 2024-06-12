//using System;
//using System.Linq;
//using static Program;

//internal class Program
//{
//    private static void Main()
//    {
//        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        // a. Nelyginius skaičius
//        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
//        Console.WriteLine("Nelyginiai skaičiai: " + string.Join(", ", oddNumbers));

//        // b. Skaičiai kurie dalinasi iš 5
//        var divisibleByFive = numbers.Where(n => n % 5 == 0).ToList();
//        Console.WriteLine("Skaičiai kurie dalinasi iš 5: " + string.Join(", ", divisibleByFive));

//        // c. Patikrinti ar sąraše yra skaičius 7
//        bool containsSeven = numbers.Contains(7);
//        Console.WriteLine("Ar sąraše yra skaičius 7: " + containsSeven);

//        // d. Patikrinti ar visi skaičiai lyginiai
//        bool allEven = numbers.All(n => n % 2 == 0);
//        Console.WriteLine("Ar visi skaičiai lyginiai: " + allEven);

//        // e. Patikrinti ar yra bent vienas skaičius, kuris dalinasi iš 8
//        bool anyDivisibleByEight = numbers.Any(n => n % 8 == 0);
//        Console.WriteLine("Ar yra bent vienas skaičius, kuris dalinasi iš 8: " + anyDivisibleByEight);




//        var numbers1 = new List<int> { 5, 6, 7 };

//        // a. Visus skaičius pakelti kvadratu.
//        var squaredNumbers = numbers1.Select(n => n * n).ToList();
//        Console.WriteLine("Skaičiai pakelti kvadratu: " + string.Join(", ", squaredNumbers));

//        // b. Gaukite jų sumą.
//        var sum = numbers1.Sum();
//        Console.WriteLine("Suma: " + sum);

//        // c. Vidurkis
//        var average = numbers1.Average();
//        Console.WriteLine("Vidurkis: " + average);

//}






