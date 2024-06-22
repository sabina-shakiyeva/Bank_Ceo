namespace Bank_Ceo;

public class Person
{
    public Person(Guid gUID, string name, string surname, int age, string position, decimal salary)
    {
        GUID = gUID;
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public Guid GUID { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
}
public interface IOrganizer
{
    void Organize();
}