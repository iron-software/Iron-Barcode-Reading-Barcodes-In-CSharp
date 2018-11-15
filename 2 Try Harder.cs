using IronBarCode;
using System;

namespace ReadingBarcodesInCSharpTutorial
{
    public partial class Examples
    {
        public static void TryHarder()
        {
            BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("TryHarderQR.png", BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

            if (Result != null && Result.Text == "https://ironsoftware.com/csharp/barcode/")
            {
                Console.WriteLine("TryHarder was a success.  Read Value: " + Result.Text);
            }
        }
    }
}