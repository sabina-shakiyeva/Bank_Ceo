namespace Bank_Ceo;

public class CEO : Person, IOrganizer
{
    public CEO(Guid gUID, string name, string surname, int age, string position, decimal salary) : base(gUID, name, surname, age, position, salary)
    {
    }

    public void Control()
    {
        Console.WriteLine("Control");
    }
    public void Organize()
    {
        Console.WriteLine("Organize");
    }
    public void MakeMeeting()
    {
        Console.WriteLine("Make Meeting");
    }
    public void DecreasePercentage(decimal percent)
    {
        Salary = Salary - ((Salary * percent) / 100);
    }
}