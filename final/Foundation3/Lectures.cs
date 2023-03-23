public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;
    private string _book;

    public Lectures(string speakerName, int capacity, string date, string time, string book)
    {
        this._eventTitle = "Lectures";
        this._description = "Have a speaker and limited capacity";
        this._date = date;
        this._time = time;
        Address lecturesAddress = new Address("301 W 13th St Suite 100", "Kansas City");
        lecturesAddress.GetFullAddress();
        this._address = lecturesAddress;
        this._speakerName = speakerName;
        this._capacity = capacity;
        this._book = book;
    }

    public void LecturesDetails()
    {
        Console.WriteLine($"The speaker for this session will be {_speakerName}");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Reading events are an opportunity to talk and see the author's perspective on specific points in the book.");
        Console.WriteLine("The opportunity to ask questions and criticize is offered in a respectful environment.");
        Console.WriteLine($"The capacity for event will be {_capacity}, be sure to hurry up to sign up!");
        Console.WriteLine($"The book that we are going to analyze is {_book}.");
        Console.WriteLine(StandardDetails());
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

    }
}