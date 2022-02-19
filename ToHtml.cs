using SautinSoft;
public class ToHtml
{
    private readonly string filePath;
    public ToHtml(string filePath) => this.filePath = filePath;

    public void Work()
    {
        if (!File.Exists(filePath))
            throw new ApplicationException($"File not exists");
        var file = Path.ChangeExtension(filePath, "html");
        var f = new PdfFocus();
        f.OpenPdf(filePath);
        f.ToHtml(file);
    }
}