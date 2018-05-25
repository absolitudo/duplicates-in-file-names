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
        /* loop fileNames
         * based on the words to match create all to possible word combinations
         * put the word combination into the dictionary value
         * key is going to be the other fileNames that match this particular word combination
         * if there is a match for more fileNames, also include the fileName that created to word combination
         */

        foreach (string fileName in fileNames)
        {
            string[] words = fileName.Split(' ');
            List<string> wordCombinations = this.CreateWordCombinations(words);
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

    public Dictionary<string, string[]> GetMatches()
    {
        return this.matches;
    }

}
