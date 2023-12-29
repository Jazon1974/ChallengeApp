using ChallengeApp;

Employee employee1 = new Employee("Jacek", "Kowalski", 35);
Employee employee2 = new Employee("Paweł", "Nowak", 30);
Employee employee3 = new Employee("Adam", "Piotrowski", 20);

employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(3);
employee1.AddScore(7);
employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(8);
employee2.AddScore(6);
employee2.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(2);
employee3.AddScore(10);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine(employee1.Name + " " + employee1.Surname + " Wiek " + employee1.Age + " ma najwyższą ilośc ocen w sumie " + result1);
}
if (result2 > result3 && result2 > result1)
{
    Console.WriteLine(employee2.Name + " " + employee2.Surname + " Wiek " + employee2.Age + " ma najwyższą ilośc ocen w sumie " + result2);
}
if (result3 > result1 && result3 > result2)
{
    Console.WriteLine(employee3.Name + " " + employee3.Surname + " Wiek " + employee3.Age + " ma najwyższą ilośc ocen w sumie " + result3);
}
