using Spire.Doc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

class ConvertFromDocx:IFileConverter
{
    private string defaultPath = IFileConverter.DEFAULT_PATH;
    private string outputExtension = IFileConverter.OUPUT_EXTENSION;
    public const string EXTENSION = ".docx";

    public void Conversion(string fileName) {
        string inputFile = fileName + EXTENSION;
        string inputPath = Path.Combine(defaultPath,inputFile);
        string outputFile;
        string outputPath;

        var docxDocument = new Document();
        docxDocument.LoadFromFile(inputPath);
        for (int i = 0; i < docxDocument.PageCount; i++) {
            using(System.Drawing.Image pageImage = 
            docxDocument.SaveToImages(i,Spire.Doc.Documents.ImageType.Bitmap)) {
               using (MemoryStream ms = new MemoryStream()) {
                    pageImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    ms.Seek(0, SeekOrigin.Begin);
                    using(var Image = 
                    SixLabors.ImageSharp.Image.Load<Rgba32>(ms)) {
                        outputFile = fileName + outputExtension;
                        outputPath = Path.Combine(defaultPath, outputFile);
                        Image.Save(outputPath);
                    }
               }
            }
        }
    }
}