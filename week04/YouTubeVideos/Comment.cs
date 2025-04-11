public class Comment
{
    private string _name;
    private string _text;

    public Comment(string text, string name)
    {
        _text = text;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}