namespace Bank_Ceo;


public class Credit
{
    public Credit(Guid gUID, Client client, decimal amount, decimal percent, int months, decimal payment)
    {
        GUID = gUID;
        Client = client;
        Amount = amount;
        Percent = percent;
        Months = months;
        Payment = payment;
    }

    public Guid GUID { get; set; }
    public Client Client { get; set; }
    public decimal Amount { get; set; }
    public decimal Percent { get; set; }
    public int Months { get; set; }
    public decimal Payment { get; set; }
    public decimal CalculatePercent()
    {
        // Calculate the percent
        return Amount * Percent / 100;
    }

    //public void Payment(decimal Odenis)
    //{ 
    ////{
    ////    Amount -= Odenis;
    //}
}