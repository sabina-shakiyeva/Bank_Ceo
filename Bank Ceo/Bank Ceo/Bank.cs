using System.Runtime.ConstrainedExecution;
namespace Bank_Ceo;

public class Bank
{
    public Bank(string name, decimal budget, decimal profit, CEO cEO/*, List<Worker> workers, List<Manager> managers, List<Client> clients*/)
    {
        Name = name;
        Budget = budget;
        Profit = profit;
        CEO = cEO;
        //Workers = workers;
        //Managers = managers;
        //Clients = clients;
    }

    public string Name { get; set; }
    public decimal Budget { get; set; }
    public decimal Profit { get; set; }
    public CEO CEO { get; set; }
    public List<Worker> Workers { get; set; } = new List<Worker>();
    public List<Manager> Managers { get; set; } = new List<Manager>();
    public List<Client> Clients { get; set; } = new List<Client>();

    public decimal CalculateProfit()
    {
        decimal total = 0;
        foreach(var worker in Workers)
        {
            total += worker.Salary;
        }
        foreach(var manager in Managers)
        {
            total += manager.Salary;
        }
        total += CEO.Salary;
        Profit = Budget - total;
        return Profit;
    }
    public void ShowClientCredit(string fullName)
    {
        foreach (var client in Clients)
        {
            if (client.Name + " " + client.Surname == fullName)
            {
                foreach(var credit in client.Credits)
                {
                    Console.WriteLine($"Client: {client.Name} {client.Surname}, Credit Amount: {credit.Amount}, Percent: {credit.Percent}, Months: {credit.Months}, Payment: {credit.Payment}");
                }
                return;

            }

        }
        Console.WriteLine("Not found");

    }
    public void PayCredit(Client client, decimal money)
    {
        foreach(var credit in client.Credits)
        {
            if (money >= credit.Payment)
            {
                credit.Amount-=credit.Payment;
                money-=credit.Payment;
                Console.WriteLine($"{credit.Payment} odendi qaliq mebleg{credit.Amount}");
            }
        }
    }

    public void ShowAllCredit() {
        foreach(var client in Clients)
        {
            foreach(var credit in client.Credits)
            {
                Console.WriteLine($"Client: {client.Name} {client.Surname}, Credit Amount: {credit.Amount}, Percent: {credit.Percent}, Months: {credit.Months}, Payment: {credit.Payment}");
            }
        }
    
    }

}