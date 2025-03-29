using Classes_M1;

// Creates customer ID.
string firstName = "";
string lastName = "";
BankCustomer customer1 = new(firstName, lastName);

firstName = "";
BankCustomer customer2 = new(firstName, lastName);

firstName = "James";
lastName = "Brisco";
BankCustomer customer3 = new(firstName, lastName);

Console.WriteLine($"BankCustomer 1: {customer1.FirstName} {customer1.LastName} {customer1.CustomerId}");

Console.WriteLine($"BankCustomer 2: {customer2.FirstName} {customer2.LastName} {customer2.CustomerId}");
Console.WriteLine($"BankCustomer 3: {customer3.FirstName} {customer3.LastName} {customer3.CustomerId}");


// Created customer accounts
BankAccount account1 = new(customer1.CustomerId, 10000,"Checking");

BankAccount account2 = new(customer2.CustomerId, 15000, "Checking");
BankAccount account3 = new(customer3.CustomerId, 1012, "Checking");

Console.WriteLine($"Account 1: Account# {account1.AccountNumber}\n {account1.AccountType} balance: {account1.Balance}, rate {BankAccount.InterestRate}%\n ID {account1.CustomerId}");

Console.WriteLine($"Account 2: Account# {account2.AccountNumber}, type {account2.AccountType}, balance {account2.Balance},rate {BankAccount.InterestRate}, cutomer ID {account2.CustomerId}");
Console.WriteLine($"Account 3: Account# {account3.AccountNumber}, type {account3.AccountType}, balance {account3.Balance},rate {BankAccount.InterestRate}, cutomer ID {account3.CustomerId}");
