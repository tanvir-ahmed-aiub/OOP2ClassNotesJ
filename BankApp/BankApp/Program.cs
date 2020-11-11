using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("Tanvir","121");
            Employee e2 = new Employee("Sabbir", "122");
            Employee e3 = new Employee("Rahim", "123");
            b.AddEmployee(e1);
            b.AddEmployee(e2,e3);
            //b.ShowAllEmployees();

            Customer c = new Customer("121","Tanvir","Dhaka");
            Account a1 = new SavingsAccount("Tanvir","1133",120.00);
            Account a2 = new FixedAccount("Tanvir","1134",50000,2015,5);

            FixedAccount a3 = new FixedAccount();

            a3.Demo1();
            a3.Demo2();

            a2.Demo1();
            a2.Demo2();
            c.AddAccounts(a1,a2);
            c.ShowAllAccounts();



        }
    }
}
