namespace Bank_Ceo;

public class Manager : Person, IOrganizer
{
    public Manager(Guid gUID, string name, string surname, int age, string position, decimal salary) : base(gUID, name, surname, age, position, salary)
    {
    }

    public void Organize() { Console.WriteLine("Organize"); }
    public decimal CalculateSalaries(List<Worker> workers)
    {
        decimal totalSalaries = 0;
        foreach (var worker in workers)
        {
            totalSalaries += worker.Salary;
        }
        return totalSalaries;
    }
}