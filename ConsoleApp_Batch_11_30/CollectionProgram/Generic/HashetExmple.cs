using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30.CollectionProgram.Generic
{
    class BookEqualityComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book x, Book y)
        {
            if(x.BookName.ToLower() == y.BookName.ToLower() && x.Author.ToLower() == y.Author.ToLower()) 
                return true;

            return false;
        }

        public int GetHashCode(Book obj)
        {
            return (obj.BookName.ToLower() + obj.Author.ToLower()).GetHashCode();
        }
    }

    class Book
    {
        public int BookId { get;}
        public string BookName { get; set; }
        public string Author { get; set; }

        private static int Identity = 1;

        public Book()
        {
            BookId = Identity;
            Identity++;
        }
    }
    internal class HashetExmple
    {
        static void Main(string[] args)
        {
            Book book1 = new Book() { BookName = "Java Complete Reference",Author = "A"};
            Book book2 = new Book() { BookName = ".Net Complete Reference", Author = "A" };
            Book book3 = new Book() { BookName = "Python Complete Reference", Author = "A" };
            Book book4 = new Book() { BookName = "PHP Complete Reference" , Author = "A" };
            //Duplicate Books
            Book book5 = new Book() { BookName = "Python Complete Reference", Author = "B" };
            Book book6 = new Book() { BookName = "PHP Complete Reference", Author = "B" };

            HashSet<Book> books = new HashSet<Book>(new BookEqualityComparer())
            {
                book1,book2,book3,book4,book5,book6
            };
          

            foreach (var item in books)
            {
                Console.WriteLine("BookId : " + item.BookId + " Book : " + item.BookName + " Author : " + item.Author);
            }
            //books.ForEach(item => { Console.WriteLine("BookId : " + item.BookId + " Book : " + item.BookName); });
        }
    }
}
