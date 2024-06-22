namespace Bank_Ceo;

public class Client : Person
{
    public Client(Guid gUID, string name, string surname, int age, string position, decimal salary, string liveAdress, string workAdress) : base(gUID, name, surname, age, position, salary)
    {
        LiveAddress = liveAdress;
        WorkAddress = workAdress;
    }

    public string LiveAddress { get; set; }
    public string WorkAddress { get; set; }
    public List<Credit> Credits { get; set; } = new List<Credit>();
}
