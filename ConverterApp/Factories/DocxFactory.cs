class DocxFactory:IFileFactory
{
    public IFileConverter InitializeConverter() {
        return new ConvertFromDocx();
    }
    public string GetExtension () {
        return ConvertFromDocx.EXTENSION;
    }
}