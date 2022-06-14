﻿/*
 * Домашнее задание 12.2 Написать делегат, с помощью которого 
реализуется сортировка книг. 
Книга представляет собой класс с полями Название, Автор, Издательство 
и конструктором. 
Создать класс, являющийся контейнером для множества книг (массив
книг). В этом классе предусмотреть метод сортировки книг. Критерий 
сортировки определяется экземпляром делегата, который передается методу в 
качестве параметра. 
Каждый экземпляр делегата должен сравнивать книги по какому-то 
одному полю: названию, автору, издательству.
*/

using SortBook;

var list = new Book[]
{
    new Book("Куколки","Джон Уиндем","Эксклюзивная классика"),
    new Book("Заводной Апельсин","Энтони Бёрджесс","Эксмо"),
    new Book("О мышах и о людях","Джон Стейнбек","Азбука классики"),
    new Book("Мартин Иден","Джек Лондон","Эксклюзивная классика"),
};

PrintArray(list);

var library = new Library(list);

var librarySortByName = library.Triage(SortField.Name);
PrintArray(librarySortByName);

var librarySortByAuthor = library.Triage(SortField.Author);
PrintArray(librarySortByAuthor);

var librarySortByPublishingHouse = library.Triage(SortField.PublishingHouse);
PrintArray(librarySortByPublishingHouse);

var librarySort = library.SortByCompareOption(Book.CompareByAuthor);
PrintArray(librarySort);

void PrintArray(Book[] library)
{
    foreach (var book in library)
    {
        Console.WriteLine(book);
    }
    Console.WriteLine();
}