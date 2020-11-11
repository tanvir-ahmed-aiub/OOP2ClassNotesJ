using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class FixedAccount:Account
    {
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }
        private int tenureYear;

        public int TenuteYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        public FixedAccount() { }
        public FixedAccount(string name, string accNo, double balance, int createYear, int tenureYear):base(name,accNo,balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }
        
        public override void Withdraw(double amount)
        {
            /*string cYear = DateTime.Now.Year.ToString();
            int currentYr = Int32.Parse(cYear);*/
            int currentYr = DateTime.Now.Year;
            if (currentYr - createYear >= tenureYear)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Account is not matured enough");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Create Year: " + createYear);
            Console.WriteLine("Tenute Year: " + tenureYear);
            Console.WriteLine("Current Year: " + DateTime.Now);
        }

        public new void Demo1() {
            Console.WriteLine("Fixed");
        }
        public override void Demo2()
        {
            Console.WriteLine("Fixed");
        }
    }
}
