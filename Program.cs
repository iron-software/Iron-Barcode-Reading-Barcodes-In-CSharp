using System;

namespace ReadingBarcodesInCSharpTutorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*  RUN A WIDE RANGE OF TESTS ON IRONBARCODE WITH SAMPLE CODE*/

            Console.WriteLine("GetStarted");
            Examples.GetStarted();

            Console.WriteLine("");
            Console.WriteLine("QRCodeExample");
            Examples.QRCodeExample();

            Console.WriteLine("");
            Console.WriteLine("TryHarder");
            Examples.TryHarder();

            Console.WriteLine("");
            Console.WriteLine("QRCodeExample");
            Examples.QRCodeExample();
         
            Console.WriteLine("");
            Console.WriteLine("ReadMultipleFromPdf");
            Examples.ReadMultipleFromPdf();

            Console.WriteLine("");
            Console.WriteLine("ReadMultipleFromTiffScan");
            Examples.ReadMultipleFromTiffScan();
              
            Console.WriteLine("");
            Console.WriteLine("MultiThreading");
            Examples.MultiThreading();

            Console.WriteLine("");
            Console.WriteLine("ReadPhotograpths");
            Examples.ReadPhotograpths();

            Console.WriteLine("");
            Console.WriteLine("ReadScanPDF");
            Examples.ReadScanPDF();
         

            Console.WriteLine("");
            Console.WriteLine("ReadThumbnail");
            Examples.ReadThumbnail();

            Console.WriteLine("");
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}