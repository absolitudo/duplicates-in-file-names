using System;
using System.Collections.Generic;
using System.IO;

public class FileNamesManipulator
{
    private string[] fileNames;
    private decimal wordsToMatch = 1;
    private Dictionary<string, string[]> matches = new Dictionary<string, string[]>();

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

    public void SetWordsToMatch(decimal value)
    {
        wordsToMatch = value;
    }

    public void MatchWords()
    {
        // do some algorithm stuff
    }

    public Dictionary<string, string[]> GetMatches()
    {
        return matches;
    }

}
