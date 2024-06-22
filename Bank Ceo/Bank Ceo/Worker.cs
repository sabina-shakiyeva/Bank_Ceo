namespace Bank_Ceo;


public class Worker : Person
{
    public Worker(Guid gUID, string name, string surname, int age, string position, decimal salary, DateTime startTime, DateTime endTime) : base(gUID, name, surname, age, position, salary)
    {
        StartTime = startTime;
        EndTime = endTime;

    }

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public List<Operation> Operations { get; set; } = new List<Operation>();


    public void AddOperation(Operation operation)
    {
        Operations.Add(operation);
    }
}