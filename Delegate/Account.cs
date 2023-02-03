using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate

{

    public delegate void AccountHandler(string message);
    public delegate void NoParameters();
    class Account 
    {
        public int deposit { get; set; }
        public string Description { get; set; }

        AccountHandler? taken;
        public void RegisterHandler(AccountHandler del) => taken = del;

        public Account() { }
        public Account(string description) => Description = description;
        public Account(int dep) => deposit = dep;

        public void Add(int add) => deposit += add;

        public void Take(int take)
        {


            if (deposit >= take)
            {
                deposit -= take;
                //Console.WriteLine($"Withdrawal {take} USD");
                taken?.Invoke($"Withdrawal {take} USD");
            }
            else
            {
                //Console.WriteLine($"Transaction is cancelled, cash shortgage is {deposit - take}");
                taken?.Invoke($"Transaction is cancelled, cash shortgage is {deposit - take}");
            }
        }

        public int Result()
        {
            return deposit;
        }

     }
}
