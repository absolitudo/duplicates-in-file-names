using System;
using System.Collections.Generic;
using System.IO;

public class FileNamesManipulator
{
    private string[] fileNames;
    private decimal wordsToMatch = 1;
    private string selectedPath;
    private Dictionary<string, List<string>> matches = new Dictionary<string, List<string>>();

    public void Refresh()
    {
        this.matches.Clear();
        this.SetFileNames(Directory.GetFiles(this.selectedPath));
    }


    public void SetSelectedPath(string path)
    {
        this.selectedPath = path;
    }

    public Boolean IsPathSelected()
    {
        if (!string.IsNullOrEmpty(this.selectedPath))
        {
            return true;
        }
        return false;
    }

    private void SetFileNames(string[] names)
    {
        for(int index = 0; index < names.Length; index += 1)
        {
            names[index] = Path.GetFileNameWithoutExtension(names[index]);
        }
        this.fileNames = names;
    }

    public string[] GetFileNames()
    {
        return this.fileNames;
    }

    public void SetWordsToMatch(decimal value)
    {
        this.wordsToMatch = value;
    }

    public void MatchWords()
    {

        for (int i = 0; i < fileNames.Length; i += 1)
        {
            string fileName = fileNames[i];

            string[] words = fileName.Split(' ');
            List<string> wordCombinations = this.CreateWordCombinations(words);

            foreach (string wordCombination in wordCombinations)
            {
                if (!matches.ContainsKey(wordCombination))
                {
                    List<string> duplicateFiles = new List<string>();

                    for (int j = i + 1; j < fileNames.Length; j += 1)
                    {
                        if (fileNames[j].Contains(wordCombination))
                        {
                            duplicateFiles.Add(fileNames[j]);
                        }

                    }

                    if (duplicateFiles.Count > 0)
                    {
                        duplicateFiles.Add(fileNames[i]);
                        matches.Add(wordCombination, duplicateFiles);
                    }

                }

            }
           
        }

    }

    private List<string> CreateWordCombinations(string[] words)
    {
        List<string> wordCombinations = new List<string>();

        decimal maxWords = wordsToMatch <= words.Length ? wordsToMatch : words.Length;
        
        if (maxWords > 1)
        {
            for (int i = 0; i < words.Length; i += 1)
            {
                string currentCombination = words[i];

                if (i + maxWords <= words.Length)
                {
                    for (int j = 1; j < maxWords; j += 1)
                    {

                        currentCombination = currentCombination + " " + words[i + j];

                    }

                    wordCombinations.Add(currentCombination);

                }

            }
        } else
        {
            foreach (string word in words)
            {
                wordCombinations.Add(word);
            }

        }

        return wordCombinations;
    }

    public Dictionary<string, List<string>> GetMatches()
    {
        return this.matches;
    }

}
