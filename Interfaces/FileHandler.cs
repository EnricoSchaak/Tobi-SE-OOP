namespace Interfaces;

public interface FileHandler
{
    public string FilePath { get; set; }  

    public void DeleteFile();

}

// FileHandler muss ein INterface sein, da ich immer nur von maximal einer KLasse erben darf!