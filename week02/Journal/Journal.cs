public class Journal 
//Stores a list of journal entries
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[1], parts[2]);
                entry._date = parts[0];
                _entries.Add(entry);
            }
        }
    }
}