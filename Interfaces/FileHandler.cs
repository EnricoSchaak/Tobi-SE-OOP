namespace Interfaces;

/// <summary>/// Ein Interface ist wie ein Vertrag. 
/// Wer ein Interface implementiert muss alle Member (Eigenschaften + Methoden)
/// des Interfaces implementieren.
/// Man könnte auch sagen ein Interface ist eine Blaupause für eine 
/// Klasse / Struct, welche beschreibt welche Methoden/Eigenschaften 
/// diese haben müssen, aber nicht wie diese sein müssen./// </summary>
public interface FileHandler
{
    public string FilePath { get; set; }  

    public void DeleteFile();

}

// FileHandler muss ein INterface sein, da ich immer nur von maximal einer KLasse erben darf!