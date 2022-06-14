namespace SortBook
{
    public class Book
    {
        private readonly string _name;
        private readonly string _author;
        private readonly string _publishingHouse;


        public Book(string name, string author, string publishingHouse)
        {
            if (name == null || author == null || publishingHouse == null)
                throw new ArgumentNullException("Существует параметр(ы) равные null");
            _name = name;
            _author = author;
            _publishingHouse = publishingHouse;
        }

        public static int CompareByName(Book first, Book secong)
        {
            return string.Compare(first._name, secong._name);
        }

        public static int CompareByAuthor(Book first, Book second)
        {
            return string.Compare(first._author, second._author);
        }

        public static int CompareByPublishingHouse(Book first, Book second)
        {
            return string.Compare(first._publishingHouse, second._publishingHouse);
        }

        public override string ToString()
        {
            return $"{_name} - {_author}  -  {_publishingHouse}";
        }
    }
}
