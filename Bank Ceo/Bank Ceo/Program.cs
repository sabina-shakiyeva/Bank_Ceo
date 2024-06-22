using Bank_Ceo;

CEO ceo = new CEO(Guid.NewGuid(), "Nargiz", "Aliyeva", 25, "CEO", 98);
//Bank bank=new Bank("Ziraat",1000000,500000,ceo,)
Client client1 = new Client(Guid.NewGuid(), "Sabina", "Shakiyeva", 19, "programmer", 5000, "Absheron", "Nizami");
Client client2 = new Client(Guid.NewGuid(), "Farida", "Shakiyeva", 20, "Doctor", 6000, "Absheron", "Nerimanov");

Bank bank = new Bank("Ziraat bank", 100000000, 500000, ceo);

Manager mg1 = new(Guid.NewGuid(), "Leyla", "Aliyeva", 23, "Manager", 1000);
Manager mg2 = new(Guid.NewGuid(), "Nigar", "Quliyeva", 28, "Manager", 2000);
Worker wk1 = new(Guid.NewGuid(), "Emil", "Mirzeyev", 29, "Worker", 1000, new DateTime(2023, 2, 3), new DateTime(2024, 2, 3));
Worker wk2= new(Guid.NewGuid(),"Abbas","Quliyev",25,"Worker",2000,new DateTime(2024,5,6),new DateTime(2024,6,7));


Credit credit1=new Credit(Guid.NewGuid(),client1,1000,4,12,86);
Credit credit2 = new Credit(Guid.NewGuid(), client2, 5000, 5, 12, 437);


bank.Clients.Add(client1);
bank.Clients.Add(client2);
client1.Credits.Add(credit1);
client2.Credits.Add(credit2);
bank.Managers.Add(mg1);
bank.Managers.Add(mg2);
bank.Workers.Add(wk1);
bank.Workers.Add(wk2);
ceo.Organize();

bank.PayCredit(client2, 437);
bank.PayCredit(client1, 86);

mg2.Organize();
bank.ShowClientCredit(client1.Name + " " + client1.Surname);
bank.ShowAllCredit();

decimal totalSalaryy = mg1.CalculateSalaries(bank.Workers);
Console.WriteLine($"Total Salary:{totalSalaryy}");
bank.CalculateProfit();