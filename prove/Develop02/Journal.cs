using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry _newEntry)
    {
        _entries.Add(_newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
  
        using (StreamWriter outputFile = new StreamWriter($"{file}.txt"))
        {
            foreach (Entry entry in _entries)

            outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        //empty entry list
        _entries.Clear();

        //split up text
        string[] lines = System.IO.File.ReadAllLines($"{file}.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry _newEntry = new Entry();
            
            _newEntry._date = parts[0];
            _newEntry._promptText = parts[1];
            _newEntry._entryText = parts[2];

            _entries.Add(_newEntry);
        }
    }

    public void DeleteEntry(int _lastEntry)
    {
        _entries.RemoveAt(_lastEntry);
    }

}