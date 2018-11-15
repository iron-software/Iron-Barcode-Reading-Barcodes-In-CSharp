using IronBarCode;
using System;

namespace ReadingBarcodesInCSharpTutorial
{
    public partial class Examples
    {
        public static void GetStarted()
        {
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("GetStarted.png");

            if (Result != null && Result.Text == "https://ironsoftware.com/csharp/barcode/")
            {
                Console.WriteLine("GetStarted was a success.  Read Value: " + Result.Text);
            }
        }

        public static void QRCodeExample()
        {
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("QR.png");

            if (Result != null && Result.Text == "https://ironsoftware.com/csharp/barcode/")
            {
                Console.WriteLine("QRCodeExample was a success.  Read Value: " + Result.Text);
            }
        }
    }
}