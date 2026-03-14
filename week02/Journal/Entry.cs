using System;

public class Entry
{
    public string _dateTime;   // Stores both date and time
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_dateTime} - {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine(); // For spacing between entries
    }
}