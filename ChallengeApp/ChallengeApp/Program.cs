using ChallengeApp;

var employee = new Employee("Jacek", "Jaxiewicz");
employee.AddGrade("2");
employee.AddGrade(4);
employee.AddGrade(10);
var statistics = employee.GetStatisticsWithWhile();

Console.WriteLine($"Avarage WithWhile: {statistics.Avarge:N2}");
Console.WriteLine($"Min WithWhile: {statistics.Min}");
Console.WriteLine($"Max WithWhile: {statistics.Max}");
Console.WriteLine();

var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine($"Avarage WithForEach: {statistics.Avarge:N2}");
Console.WriteLine($"Min WithForEach: {statistics.Min}");
Console.WriteLine($"Max WithForEach: {statistics.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Avarage WithDoWhile: {statistics.Avarge:N2}");
Console.WriteLine($"Min WithDoWhile: {statistics.Min}");
Console.WriteLine($"Max WithDoWhile: {statistics.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine($"Avarage WithFor: {statistics.Avarge:N2}");
Console.WriteLine($"Min WithFor: {statistics.Min}");
Console.WriteLine($"Max WithFor: {statistics.Max}");
Console.WriteLine();