// See https://aka.ms/new-console-template for more information
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.HtmlConverter.Qt;
using System.Drawing;


//Console.WriteLine("Hello, World!");

////Get the HTML string from a .html file
//string htmlString = File.ReadAllText(@"D:\Exelon-Proj-data\HTML_Samples\ItextPDF.html");
////Specify the output file path
//string fileName = $"D:/Exelon-Proj-data/SpirePDF/SamplePDF/{Guid.NewGuid()}-SamplePDFHtmlStringToPdf.pdf";
////Specify the plugin path

//string pluginPath = "D:\\Exelon-Proj-data\\SpirePDF\\plugins";
////Set plugin path
//HtmlConverter.PluginPath = pluginPath;
////Convert HTML string to PDF
//HtmlConverter.Convert(htmlString, fileName, true, 100000, new Size(1080, 1000), new PdfMargins(0), Spire.Pdf.HtmlConverter.LoadHtmlType.SourceCode);

string fileName = $"D:/Exelon-Proj-data/SpirePDF/SamplePDF/{Guid.NewGuid()}-HTMLtoPDF.pdf";

HtmlConverter.Convert(@"D:\Exelon-Proj-data\HTML_Samples\M212.html", fileName,

               //enable javascript
               true,

               //load timeout
               100 * 1000,

               //page size
               new Size(612, 792),
               //new Size(700, 500),


               //page margins
               new PdfMargins(10, 60));


//PdfDocument doc = new PdfDocument();


//doc.LoadFromFile(fileName);
//for (int i = 0; i < doc.Pages.Count; i++)
//{
//    //Add Image 
//    //PdfImage headerImage = PdfImage.FromFile(@"D:\Exelon-Proj-data\SpirePDF\resources\logo.png");
//    //float width = headerImage.Width / 3;
//    //float height = headerImage.Height / 3;
//    //doc.Pages[i].Canvas.DrawImage(headerImage, 85, 20, width, height);

//    //PdfPen pen = new PdfPen(PdfBrushes.Gray, 1);
//    //doc.Pages[i].Canvas.DrawLine(pen, x, y + 60 - 2, 60 - x, y + 60 - 2);

//    //Add Text
//    string headerText = "HEADER TEXT \n HEADER TEXT";
//    PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Impact", 15f));
//    SizeF size = font.MeasureString(headerText);
//    doc.Pages[i].Canvas.DrawString(headerText, font, PdfBrushes.RoyalBlue, doc.Pages[i].Size.Width - 90 - size.Width, 25);
//}

//doc.SaveToFile(fileName);


String[] files = new String[]

{
    @"D:\Exelon-Proj-data\SpirePDF\SamplePDF\20538554-b3e3-45c4-a18e-8e65f722bb04-HTMLtoPDF.pdf",
    @"D:\Exelon-Proj-data\SpirePDF\SamplePDF\32f6ad7e-bb94-475d-9adc-2a179caff05c-HTMLtoPDF.pdf",
    @"D:\Exelon-Proj-data\SpirePDF\SamplePDF\e46c656d-1150-4f31-9230-95c874b1aefb-HTMLtoPDF.pdf",

};


//open pdf documents           

 PdfDocument[] docs = new PdfDocument[files.Length];
 for (int i = 0; i < files.Length; i++)
 {
     docs[i] = new PdfDocument(files[i]);
 }
//append document

for (int i = 1; i < files.Length; i++)
{
    docs[0].AppendPage(docs[i]);
}





docs[0].SaveToFile("MergeDocuments.pdf");





public class SquashPractce
{ 

}