
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }
        
        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

       // void AddGrade(decimal grade);

        //void AddGrade(long grade);

        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
