namespace firstAssessment
{
    class Book
    {
        public string Title = "";
        public int Pages;

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a variable of type object.Print it.

            Console.WriteLine("the answer of question one ");

            Book myBook = new Book();
            myBook.Title = "c#basics";
            myBook.Pages = 10;
            object obj = myBook;

            Console.WriteLine(obj);







        }
    }
}
