using ChallengeApp;
using System.ComponentModel.Design;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("==============================================");
Console.WriteLine("Jeżeli chcesz wyjsć wpisz zamiast oceny literę q");
Console.WriteLine();

Employee employee = new Employee();
Supervisor supervisor = new Supervisor();


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var grade = Console.ReadLine();

    if (grade == "q")
    {
        break;
    }
    try
    {
       //employee.AddGrade(grade);
        supervisor.AddGrade(grade);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
}

//var statistics = employee.GetStatistics();
var statistics = supervisor.GetStatistics();

Console.WriteLine($"Avarage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvargeLetter: {statistics.AverageLetter}");



