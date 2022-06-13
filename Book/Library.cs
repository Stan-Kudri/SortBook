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

        public Book[] Triage(SortByParameter parameter)
        {
            switch (parameter)
            {
                case SortByParameter.Name:
                    Array.Sort(Books, Book.CompareByName);
                    return Books;
                case SortByParameter.Author:
                    Array.Sort(Books, Book.CompareByAuthor);
                    return Books;
                case SortByParameter.PublishingHouse:
                    Array.Sort(Books, Book.CompareByPublishingHouse);
                    return Books;
            }

            throw new ArgumentException("Сортировки такой нет.");
        }
    }

    //public delegate int CompareBookDelegate(Book first, Book second);

}
