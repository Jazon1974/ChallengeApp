using ChallengeApp;

var employee = new Employee("Jacek", "Jaxiewicz");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Avarage: {statistics.Avarge:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");