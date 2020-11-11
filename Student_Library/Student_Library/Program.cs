using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l1 = new Library("Aiub Library");

            Book b1 = new Book("Padma Nadir Majhi","Manik","1001",10);
            Book b2 = new Book("Hajar Bochor Dhore","Zahir","1002",4);
            Book b3 = new Book("Harry Potter 1","J.K","1003",5);
            Book b4 = new Book("Harry Potter 2","J.K","1004",4);

            l1.AddBook(b1,b2,b3,b4);

            //l1.ShowAllBooks();

            var temp = l1.SearchBook("1004");
            if (temp != null) {
                l1.AddNewBookCopy(temp, 5);
            }
            Book b5 = new Book("C++ The complete referecne", "Herbert Schildit", "1005", 10);
            l1.AddBook(b5);
            Console.WriteLine("-------------------------------");
            //l1.ShowAllBooks();

            Student s1 = new Student("Tanvir","1001");
            Student s2 = new Student("Maruf", "1002");

            Borrow br1 = new Borrow("br-001",7,s1);
            br1.AddBook(b1,b2);
            s1.AddBorrow(br1);
            Borrow br2 = new Borrow("br-002", 8, s2);
            br2.AddBook(b3,b4);
            s2.AddBorrow(br2);

            Borrow br3 = new Borrow("br-003", 4, s1);
            br3.AddBook(b5);
            s1.AddBorrow(br3);

            //s1.ShowAllBorrows();

            l1.AddBorrow(br1);
            l1.AddBorrow(br2);
            l1.AddBorrow(br3);

            //l1.ShowAllBorrows();

            Account a1 = new Account("Tanvir", "10001", 500.00);
            s1.Account = a1;

            Account a2 = new Account("Library", "1002", 10000.00);
            l1.Account = a2;

            l1.ReturnBook(br1);
            l1.ReturnBook(br3);

            Console.WriteLine("Student Balance: " + s1.Account.Balance);
            Console.WriteLine("Library Balance: " + l1.Account.Balance);





        }
    }
}
