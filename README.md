# Reading Barcodes In C&num;

A detailed C# tutorial showing how to use the **BarCode** package from Nuget to read Barcodes 

```
 PM > Install-Package Barcode
```


```
using IronBarCode;
using System;
```

**Topic Covered:**


### 1 Get Started.cs
How to read almost any barcode or QR Code in 1 line of code.


### 2 Try Harder.cs
Improving performance by specifying barcode formats to scan, and using the **TryHarder** flag to find skewed or noisy barcodes, at the cost of some speed.


### 3 Read Multiple.cs

Reading one or many barcodes from documents and scans including

- Images
- PDF files
- MultiFrame GIF and TIFF images
- MultiThreading for faster performance


### 4 Reading Imperfect Barcodes.cs
Dealing with real world scenarios such as:

- Reading Barcodes and QR from Photographs
- Scanning PDF files for barcodes
- Reading barcodes from small or thumbnail images

All BarcodeResult.Read methods provide the developer with control to correct image and photograph correction and straightening rotation and perspective from skewed images
- RotationCorrection   e.g BarcodeReader.BarcodeRotationCorrection.Extreme  un-rotates and removes perspective from barcode images.
- ImageCorrection      e.g BarcodeReader.BarcodeImageCorrection.DeepCleanPixels  separates Barcodes from background imagery and digital noise.
- BarcodeEncoding      e.g. BarcodeEncoding.Code128  Setting a specific Barcode format improves speed and reduces the risk of false positive results


## Learn More

See the full tutorial at https://ironsoftware.com/csharp/barcode/tutorials/reading-barcodes/
