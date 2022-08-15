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

//import pages
//if (files.Length > 2) {
//    for (int i = 2; i < docs[i].Pages.Count; i = i ++)
//    {
//        docs[0].InsertPage(docs[i], i);
//    }
//}

//foreach (PdfDocument doc in docs)

//{

//    doc.Close();

//}
//PdfDocumentViewer("MergeDocuments.pdf");








////create a PDF document

//PdfDocument doc = new PdfDocument();

// doc.PageSettings.Size = PdfPageSize.A4;

// //reset the default margins to 0

// doc.PageSettings.Margins = new PdfMargins(0);

// //create a PdfMargins object, the parameters indicate the page margins you want to set

// PdfMargins margins = new PdfMargins(60, 60, 60, 60);

// //create a header template with content and apply it to page template

// doc.Template.Top = CreateHeaderTemplate(doc, margins);

// //apply blank templates to other parts of page template

// doc.Template.Bottom = new PdfPageTemplateElement(doc.PageSettings.Size.Width, margins.Bottom);

// doc.Template.Left = new PdfPageTemplateElement(margins.Left, doc.PageSettings.Size.Height);

// doc.Template.Right = new PdfPageTemplateElement(margins.Right, doc.PageSettings.Size.Height);


////Create a PdfPageSettings object

//  PdfPageSettings setting = new PdfPageSettings();




//  //Save page size and margins through the object

//  setting.Size = new SizeF(1000, 1000);

//  setting.Margins = new Spire.Pdf.Graphics.PdfMargins(20);




//  //Create a PdfHtmlLayoutFormat object
//  PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();


////Load HTML from a URL path using LoadFromHTML method

//         Thread thread = new Thread(() =>
//         { doc.LoadFromHTML(Url, true, true, false, setting, htmlLayoutFormat); });

//         thread.SetApartmentState(ApartmentState.STA);

//         thread.Start();

//            thread.Join();



////Set IsWaiting property to true

//htmlLayoutFormat.IsWaiting = true;




// //save the file
//doc.SaveToFile($"D:/Exelon-Proj-data/SpirePDF/SamplePDF/{Guid.NewGuid()}-PdfHeader.pdf");


//static PdfPageTemplateElement CreateHeaderTemplate(PdfDocument doc, PdfMargins margins)

//{

//    //get page size

//    SizeF pageSize = doc.PageSettings.Size;



//    //create a PdfPageTemplateElement object as header space

//    PdfPageTemplateElement headerSpace = new PdfPageTemplateElement(pageSize.Width, margins.Top);

//    headerSpace.Foreground = false;



//    //declare two float variables

//    float x = margins.Left;

//    float y = 0;



//    //draw image in header space

//    PdfImage headerImage = PdfImage.FromFile(@"D:\Exelon-Proj-data\SpirePDF\resources\logo.png");

//    float width = headerImage.Width / 3;

//    float height = headerImage.Height / 3;

//    headerSpace.Graphics.DrawImage(headerImage, x, margins.Top - height - 2, width, height);



//    //draw line in header space

//    PdfPen pen = new PdfPen(PdfBrushes.Gray, 1);

//    headerSpace.Graphics.DrawLine(pen, x, y + margins.Top - 2, pageSize.Width - x, y + margins.Top - 2);



//    //draw text in header space

//    PdfTrueTypeFont font = new PdfTrueTypeFont(new Font("Impact", 25f, FontStyle.Bold));

//    PdfStringFormat format = new PdfStringFormat(PdfTextAlignment.Left);

//    String headerText = "HEADER TEXT";

//    SizeF size = font.MeasureString(headerText, format);

//    headerSpace.Graphics.DrawString(headerText, font, PdfBrushes.Gray, pageSize.Width - x - size.Width - 2, margins.Top - (size.Height + 5), format);



//    //return headerSpace

//    return headerSpace;

//}


