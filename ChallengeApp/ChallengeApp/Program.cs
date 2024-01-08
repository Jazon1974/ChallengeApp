using ChallengeApp;

var employee = new Employee("Jacek", "Jaxiewicz");
employee.AddGrade("2");
employee.AddGrade(4);
employee.AddGrade(10);
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Avarage WithWhile: {statistics4.Avarge:N2}");
Console.WriteLine($"Min WithWhile: {statistics4.Min}");
Console.WriteLine($"Max WithWhile: {statistics4.Max}");
Console.WriteLine();

var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine($"Avarage WithForEach: {statistics1.Avarge:N2}");
Console.WriteLine($"Min WithForEach: {statistics1.Min}");
Console.WriteLine($"Max WithForEach: {statistics1.Max}");
Console.WriteLine();

var statistics3 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Avarage WithDoWhile: {statistics3.Avarge:N2}");
Console.WriteLine($"Min WithDoWhile: {statistics3.Min}");
Console.WriteLine($"Max WithDoWhile: {statistics3.Max}");
Console.WriteLine();

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine($"Avarage WithFor: {statistics2.Avarge:N2}");
Console.WriteLine($"Min WithFor: {statistics2.Min}");
Console.WriteLine($"Max WithFor: {statistics2.Max}");
Console.WriteLine();