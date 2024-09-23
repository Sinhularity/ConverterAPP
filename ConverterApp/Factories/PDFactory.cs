class PDFactory:IFileFactory
{
    public IFileConverter InitializeConverter() {
        return new ConvertFromPDF();
    }

    public string GetExtension(){
        return ConvertFromPDF.EXTENSION;
    }
}