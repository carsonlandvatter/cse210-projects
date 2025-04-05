using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

public class Scripture

{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = new List<Word>();

        string[] splitWords = scriptureText.Split(' ');
        //This loops through each word in the array.
        foreach (string w in splitWords)
        {
            words.Add(new Word(w));
            //This makes the object get added to the list and false means the wort is not hidden quite yet.
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.GetDisplayText());
        foreach (Word word in words)
        //Loops through every word object in words list.
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWords(int numberToHide)
    //This controls how many words to hide when the user presses Enter.
    {
        Random random = new Random();
        int hiddenCount = 0;

        int availableToHide = 0;
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                availableToHide++;
            }
        }
        int actualToHide = Math.Min(numberToHide, availableToHide);

        while (hiddenCount < actualToHide)
        {
            if (AllWordsHidden()) Environment.Exit(0);

            int index = random.Next(words.Count);

            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hiddenCount++;
            }

        }

    }

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public int WordCounter()
    {
        int count = 0;
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }
}