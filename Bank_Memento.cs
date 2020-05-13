using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_Lv6
{
    class Bank_Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public Bank_Memento(string ownername, string owneraddress, decimal balance)
        {
            this.OwnerName = ownername; this.OwnerAddress = owneraddress; this.Balance = balance;
        }
        public Bank_Memento(BankAccount account)
        {
            this.OwnerName = account.OwnerName; this.OwnerAddress = account.OwnerAddress; this.Balance = account.Balance;
        }
        public void AddState(BankAccount account)
        {
            Balance = account.Balance;
        }
    }
}
