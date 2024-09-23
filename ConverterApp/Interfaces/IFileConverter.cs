interface IFileConverter
{
    static readonly string DEFAULT_PATH = Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments);
    const string OUPUT_EXTENSION = ".jpg";
    void Conversion (string fileName);
}