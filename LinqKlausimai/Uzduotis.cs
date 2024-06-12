using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Jonas", Grade = 8, Age = 20 },
            new Student { Name = "Petras", Grade = 5, Age = 22 },
            new Student { Name = "Ona", Grade = 9, Age = 24 },
            new Student { Name = "Rasa", Grade = 7, Age = 26 },
            new Student { Name = "Andrius", Grade = 6, Age = 23 },
            new Student { Name = "Gabija", Grade = 7, Age = 27 }
        };

        // Apskaičiuoti vidutinį visų studentų pažymį
        var averageGrade = students.Average(s => s.Grade);
        Console.WriteLine("Vidutinis pažymys: " + averageGrade);

        // Rasti didžiausią pažymį
        var highestGrade = students.Max(s => s.Grade);
        Console.WriteLine("Didžiausias pažymys: " + highestGrade);

        // Rasti mažiausią pažymį
        var lowestGrade = students.Min(s => s.Grade);
        Console.WriteLine("Mažiausias pažymys: " + lowestGrade);

        // Rasti jauniausią ir vyriausią studentą
        var youngestStudent = students.OrderBy(s => s.Age).First();
        var oldestStudent = students.OrderByDescending(s => s.Age).First();
        Console.WriteLine("Jauniausias studentas: " + youngestStudent.Name + ", Amžius: " + youngestStudent.Age);
        Console.WriteLine("Vyriausias studentas: " + oldestStudent.Name + ", Amžius: " + oldestStudent.Age);

        // Suskaičiuoti kiek studentų turi pažymį 7
        var countOfGrade7 = students.Count(s => s.Grade == 7);
        Console.WriteLine("Studentų skaičius su pažymiu 7: " + countOfGrade7);

        // Naudodami LINQ, raskite tris studentus su aukščiausiais pažymiais ir išveskite jų vardus, pažymius ir amžių.
        // Rasti tris studentus su aukščiausiais pažymiais
        var topThreeStudents = students.OrderByDescending(s => s.Grade).Take(3).ToList();

        // Išvesti jų vardus, pažymius ir amžių
        Console.WriteLine("Trijų studentų su aukščiausiais pažymiais sąrašas:");
        foreach (var student in topThreeStudents)
        {
            Console.WriteLine($"Vardas: {student.Name}, Pažymys: {student.Grade}, Amžius: {student.Age}");
        }
    }

}
