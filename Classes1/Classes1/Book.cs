namespace Classes1;

public class Book
{
    private string title;
    private string author;
    private int pages;
    private bool open;

    public Book()
    {
        title = "Book";
        author = "Me";
        pages = 100;
        open = false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {title}\n");
        Console.WriteLine($"Author: {author}\n");
        Console.WriteLine($"Pages: {pages}\n");
        Console.WriteLine($"Open: {open}\n");
    }

    public void Open()
    {
        open = true;
    }
    
    public void Close()
    {
        open = false;
    }
}