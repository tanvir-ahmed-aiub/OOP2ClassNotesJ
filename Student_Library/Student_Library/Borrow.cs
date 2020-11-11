using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Borrow
    {
        public string Id { get; set; }
        public int Day { get; set; }
        public Student Student { get; set; }
        Book[] books;
        public int BookCount { get; set; }
        public Borrow() {
            books = new Book[5];
        }
        public Borrow(string id,int day,Student student) {
            Id = id;
            Day = day;
            Student = student;
            books = new Book[5];
        }
        public void AddBook(params Book[] books)
        {
            foreach (var book in books)
            {
                if (BookCount < 5)
                    this.books[BookCount++] = book;
            }
        }
        public void ShowInfo() {
            Console.WriteLine("Borrow Id "+ Id);
            Console.WriteLine("Borrowed on  "+ Day);
            for (int i = 0; i < BookCount; i++) {
                books[i].ShowInfo();
            }
        }
    }
}
