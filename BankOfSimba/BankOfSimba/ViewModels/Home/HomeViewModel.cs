using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<BankAccount> accounts = new List<BankAccount>
        {
            new BankAccount("Simba", 20000, AnimalType.Lion, true, true),
            new BankAccount("Timon", 5000, AnimalType.Meerkat, false, true),
            new BankAccount("Rafiki", 6000, AnimalType.Mandrill, false, true),
            new BankAccount("Zazu", 4000, AnimalType.Hornbill, false, true),
            new BankAccount("Zordon", 10000, AnimalType.Lion, false, false)
        };

        public void Raise()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].IsKing != false)
                {
                    accounts[i].Balance += 100;
                }
                else
                {
                    accounts[i].Balance += 10;
                }
            }
        }
    }  
}