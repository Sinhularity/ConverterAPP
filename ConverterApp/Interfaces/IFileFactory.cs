interface IFileFactory
{
    IFileConverter InitializeConverter();
    string GetExtension ();
}