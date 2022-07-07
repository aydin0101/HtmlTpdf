using IronPdf;
using System;

namespace HtmlTpdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HtmlToPdf\n\n");
            Console.WriteLine("cevirmek istediginiz html dosyasını masaustune alınız ve adını eksiksiz yazınız\n\n");
            string html;
            html=Console.ReadLine();
            var htmlToPdf = new HtmlToPdf();
            var pdfDocumet = htmlToPdf.RenderHTMLFileAsPdf("C:\\Users\\aydin\\OneDrive\\Masaüstü\\" + html + ".html");
            pdfDocumet.SaveAs("C:\\Users\\aydin\\OneDrive\\Masaüstü\\"+ html +".pdf");

            Console.WriteLine("İşlem başarı ile gerçekleşti proğramı kapatabilirsiniz\n\n");

            Console.WriteLine("programı kapatmak için herhangi bir tuşa basınız\n\n");
            Console.WriteLine("By AYDNd");
        }
    }
}
