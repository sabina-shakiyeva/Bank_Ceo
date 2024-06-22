namespace Bank_Ceo;

public class Operation
{
    public Operation(Guid gUID, string processName, DateTime dateTime)
    {
        GUID = gUID;
        ProcessName = processName;
        DateTime = dateTime;
    }

    public Guid GUID { get; set; }
    public string ProcessName { get; set; }
    public DateTime DateTime { get; set; }
}