namespace Frendy.Shared.Models;

/// <summary>
/// Класс с данными файла
/// </summary>
public class FileData
{
    private string _fileName;
    
    public string FileExtension { get; private set; }
    public string FileName
    {
        get => _fileName;
        set
        {
            if (Path.GetExtension(value).ToLowerInvariant() is var fileExtension 
                && string.IsNullOrEmpty(fileExtension))
                throw new ArgumentException($"{nameof(FileName)} \"{value}\" is empty or without extension");

            FileExtension = fileExtension;
            _fileName = value;
        }
    }

    public byte[] FileContent { get; set; }
}