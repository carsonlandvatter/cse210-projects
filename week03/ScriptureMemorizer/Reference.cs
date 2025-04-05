public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int? verseEnd;

    //this is considered a field. It stores the book/chapter for the object. No values. Just placeholders 

    public Reference(string book, int chapter, int verseStart)
    //This constructor initializes the object.
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = null;
        //This. is used for variables that have the same name as the constructor parameters.
    }

    public string GetDisplayText()
    {
        if (verseEnd == null)
        {
            return $"{book} {chapter}:{verseStart}";
        }
        else
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
    }
}