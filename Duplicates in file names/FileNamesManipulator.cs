using System.IO;

public class FileNamesManipulator
{
    private string[] fileNames;

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

}
