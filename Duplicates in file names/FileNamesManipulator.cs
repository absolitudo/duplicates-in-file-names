using System;
using System.IO;

public class FileNamesManipulator
{
    private string[] fileNames;
    private decimal wordsToMatch = 1;


    public void SetFileNames(string[] names)
    {
        for(int index = 0; index < names.Length; index += 1)
        {
            names[index] = Path.GetFileName(names[index]);
        }
        fileNames = names;
    }

    public string[] GetFileNames()
    {
        return fileNames;
    }

    internal void SetWordsToMatch(decimal value)
    {
        wordsToMatch = value;
    }
}
