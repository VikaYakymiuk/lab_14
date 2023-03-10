using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var studentsGroup = new List<string[]>();

        while (!inputLine.Equals("END") || !inputLine.Equals("end") || !inputLine.Equals("End"))
        {
            var studentNames = inputLine.Trim().Split();
            studentsGroup.Add(studentNames);
            inputLine = Console.ReadLine();
        }

        var result = studentsGroup.Where(x => x[1].CompareTo(x[0]) == 1);

        foreach (var student in result)
        {
            Console.WriteLine($"{student[0]} {student[1]}");
        }
    }
}
