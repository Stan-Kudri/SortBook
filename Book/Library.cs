namespace SortBook
{
    public class Library
    {
        private Book[] _triage;

        public Book[] Books
        {
            get => _triage;
        }

        public Library(Book[] books)
        {
            _triage = new Book[books.Length];
            for (int i = 0; i < books.Length; i++)
                Books[i] = books[i];
        }

        public Book[] SortByCompareOption(CompareBookDelegate option)
        {
            Array.Sort(Books, option.Invoke);
            return Books;
        }
    }

    public delegate int CompareBookDelegate(Book first, Book second);

}
