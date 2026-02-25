namespace Conclase9.Models
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string iSBN, bool isBorrowed)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsBorrowed = isBorrowed;
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}\nAvailable: {3}\n",
                Title, Author, ISBN, !IsBorrowed);
        }
    }
}
