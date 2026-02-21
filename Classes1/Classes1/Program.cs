using System;
using Classes1;
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        
        book.ShowInfo();
        book.Open();
        book.ShowInfo();
        book.Close();
        book.ShowInfo();
        
    }
}