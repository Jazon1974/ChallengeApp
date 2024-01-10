using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("==============================================");
Console.WriteLine("Jeżeli chcesz wyjsć wpisz zamiast oceny literę q");
Console.WriteLine();

var employee = new Employee();


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avarage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvargeLetter: {statistics.AverageLetter}");
