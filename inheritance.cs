using System;
namespace InheritancePrincipleCSharp
{
    
    public class LibraryItem
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public LibraryItem(string id, string title)
        {
            Id = id;
            Title = title;
        }

        public void Borrow()
        {
            Console.WriteLine(Title+" has been borrowed.");
        }

        public void Return()
        {
            Console.WriteLine(Title+" has been returned.");
        }
    }

    
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string id, string title, string author, int pages)
            : base(id, title)
        {
            Author = author;
            Pages = pages;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book: "+Title+ " by "+Author+","+Pages+" pages.");
        }
    }

    
    public class DVD : LibraryItem
    {
        public int Runtime { get; set; } 

        public DVD(string id, string title, int runtime)
            : base(id, title)
        {
            Runtime = runtime;
        }

        public void DisplayDVDInfo()
        {
            Console.WriteLine("DVD: "+Title+", "+"Runtime:"+ Runtime+" minutes.");
        }
    }
    
   
    public class Program
    {
        static void Main(string[] args)
        {
           
            Book novel = new Book("BK001", "The Great Novel", "John Doe", 320);
            novel.DisplayBookInfo();
            novel.Borrow();
            novel.Return();

            Console.WriteLine();

            DVD movie = new DVD("DV001", "Epic Movie", 120);
            movie.DisplayDVDInfo();
            movie.Borrow();
            movie.Return();

            
        }
    }
}