public class Entry 
//Represents a single journal entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd");
        //stores today's date
        _promptText = prompt;
        //saves the prompt
        _entryText = response;
        //saves the response
    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }
}