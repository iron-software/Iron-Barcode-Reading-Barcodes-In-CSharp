using IronBarCode;
using System;
using System.Drawing;


namespace ReadingBarcodesInCSharpTutorial
{
    public partial class Examples
    {
        public static void ReadPhotograpths()
        {

            // All BarcodeResult.Read methods provide the developer with control to correct image and photograph correction and straightening rotation and perspective from skewed images
            // * RotationCorrection   e.g BarcodeReader.BarcodeRotationCorrection.Extreme  un-rotates and removes perspective from barcode images.
            // * ImageCorrection      e.g BarcodeReader.BarcodeImageCorrection.DeepCleanPixels  separates Barcodes from background imagery and digital noise.
            // * BarcodeEncoding      e.g. BarcodeEncoding.Code128  Setting a specific Barcode format improves speed and reduces the risk of false positive results

            // Example with a photo image
            var PhotoResult = BarcodeReader.ReadASingleBarcode("Photo.jpg", BarcodeEncoding.Code128, BarcodeReader.BarcodeRotationCorrection.Low, BarcodeReader.BarcodeImageCorrection.None);
 
            string Value = PhotoResult.Value;
            System.Drawing.Bitmap Img = PhotoResult.BarcodeImage;
            BarcodeEncoding BarcodeType = PhotoResult.BarcodeType;
            byte[] Binary = PhotoResult.BinaryValue;
            Console.WriteLine(PhotoResult.Value);  

        }

        public static void ReadScanPDF()
        {
            // Best Results with a 200-300 DPI Scan.  Specify a barcode format to avoid false positives in digital noise and text.
            // Multi frame TIFF and GIF images can also be scanned, and multiple threads will be used automatically in the background for improved performance
            var ScanResults = BarcodeReader.ReadBarcodesFromPdf("Scan.pdf", BarcodeEncoding.Code128 | BarcodeEncoding.ITF, BarcodeReader.BarcodeRotationCorrection.Low, BarcodeReader.BarcodeImageCorrection.MediumCleanPixels);

            // Work with the results
            foreach (var PageResult in ScanResults)
            {
                string Value = PageResult.Value;
                int PageNum = PageResult.PageNumber;
                System.Drawing.Bitmap Img = PageResult.BarcodeImage;
                BarcodeEncoding BarcodeType = PageResult.BarcodeType;
                byte[] Binary = PageResult.BinaryValue;
                Console.WriteLine(PageResult.Value + " on page " + PageNum);
            }
        }


        public static void ReadThumbnail()
        {

            // Small or 'Thumbnail' barcode images are automatically detected by IronBarCode and corrected for wherever possible even if they have much digital noise.
            BarcodeResult SmallResult = BarcodeReader.QuicklyReadOneBarcode("ThumbnailOfBarcode.gif", BarcodeEncoding.All);
            Console.WriteLine(SmallResult.Value + " barcode thumbnail found ");

        }
    }
}