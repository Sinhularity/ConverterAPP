using System.Diagnostics;

class Program
{
    public static void Main(String[] args) {
        // Fábricas concretas
        IFileFactory converterFactory;
        // Convertidor base
        IFileConverter fileConverter;
        string fileName;

        Console.WriteLine("Que tipo de archivo desea convertir\n1. PDF a JPG\n2. Docx a JPG");
        int opcion;
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion) 
        {
            case 1: 
            converterFactory = new PDFactory();
            fileName = GetFileName();
            break;
            case 2:
                converterFactory = new DocxFactory();
                fileName = GetFileName();
            break;
            default:
                return;    
        }

        fileConverter = converterFactory.InitializeConverter();
        fileConverter.Conversion(fileName);

    }

    public static string GetFileName(){
        Console.WriteLine("Introduce el nombre del archivo sin extension");
        return Console.ReadLine() ?? string.Empty;
    }
}
