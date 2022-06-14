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

        public Book[] Triage(SortField sortOption)
        {
            switch (sortOption)
            {
                case SortField.Name:
                    Array.Sort(Books, Book.CompareByName);
                    return Books;
                case SortField.Author:
                    Array.Sort(Books, Book.CompareByAuthor);
                    return Books;
                case SortField.PublishingHouse:
                    Array.Sort(Books, Book.CompareByPublishingHouse);
                    return Books;
            }

            throw new ArgumentException("Сортировки такой нет.");
        }

        public Book[] SortByCompareOption(CompareBookDelegate option)
        {
            Array.Sort(Books, option.Invoke);
            return Books;
        }
    }

    public delegate int CompareBookDelegate(Book first, Book second);

}
