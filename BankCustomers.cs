using System;
using System.Runtime.InteropServices.Marshalling;

namespace Classes_M1;

class BankCustomer
{

   private static int s_nextCustomerId;
   public string FirstName = "";
   public string LastName = "";
   public readonly string CustomerId;

   static BankCustomer()
   {
      Random random = new();
      s_nextCustomerId = random.Next(1000, 999999);
   }

    public BankCustomer(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
      CustomerId = s_nextCustomerId++.ToString("D10");
    }
}
