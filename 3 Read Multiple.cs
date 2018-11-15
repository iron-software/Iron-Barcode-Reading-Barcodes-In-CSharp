using IronBarCode;
using System;
using System.Drawing;


namespace ReadingBarcodesInCSharpTutorial
{
    public partial class Examples
    {
        public static void ReadMultipleFromPdf()
        {
          
            // Multiple barcodes may be scanned up from a single document or image.  A PDF document may also used as the input image
            PagedBarcodeResult[] PDFResults = BarcodeReader.ReadBarcodesFromPdf("MultipleBarcodes.pdf", BarcodeEncoding.All, BarcodeReader.BarcodeRotationCorrection.Low, BarcodeReader.BarcodeImageCorrection.None);

            // Work with the results
            foreach (var PageResult in PDFResults)
            {
                string Value = PageResult.Value;
                int PageNum = PageResult.PageNumber;
                System.Drawing.Bitmap Img = PageResult.BarcodeImage;
                BarcodeEncoding BarcodeType = PageResult.BarcodeType;
                byte[] Binary = PageResult.BinaryValue;
                Console.WriteLine(PageResult.Value+" on page "+ PageNum);
            }
        }

        public static void ReadMultipleFromTiffScan()
        {
            // Multi frame TIFF and GIF images can also be scanned, and multiple threads will be used automatically in the background for improved performance
            PagedBarcodeResult[] MultiFrameResults = BarcodeReader.ReadBarcodesFromMultiFrameTiff("Multiframe.tiff", BarcodeEncoding.AllOneDimensional, BarcodeReader.BarcodeRotationCorrection.High, BarcodeReader.BarcodeImageCorrection.MediumCleanPixels);
           
            // Work with the results
            foreach (var PageResult in MultiFrameResults)
            {
                string Value = PageResult.Value;
                int PageNum = PageResult.PageNumber;
                System.Drawing.Bitmap Img = PageResult.BarcodeImage;
                BarcodeEncoding BarcodeType = PageResult.BarcodeType;
                byte[] Binary = PageResult.BinaryValue;
                Console.WriteLine(PageResult.Value + " on page " + PageNum);
            }
        }


        public static void MultiThreading()
        {

            // The BarcodeResult.ReadBarcodesMultiThreaded method allows for faster barcode scanning of multiple images.  All threads are automatically managed by IronBarCode.
            var ListOfDocuments = new[] { "image1.png", "image2.jpg", "image3.pdf" };

            // The true flag at the end allows us to expect multiple barcodes per document.
            PagedBarcodeResult[] BatchResults = BarcodeReader.ReadBarcodesMultiThreaded(ListOfDocuments, BarcodeEncoding.All, true);


            // Work with the results
            foreach (var Result in BatchResults)
            {
                string Value = Result.Value;
                System.Drawing.Bitmap Img = Result.BarcodeImage;
                BarcodeEncoding BarcodeType = Result.BarcodeType;
                byte[] Binary = Result.BinaryValue;
                var InputFileName = ListOfDocuments[Result.PageNumber-1];
                Console.WriteLine(Result.Value +" found in file "+ InputFileName);
            }
        }
    }
}