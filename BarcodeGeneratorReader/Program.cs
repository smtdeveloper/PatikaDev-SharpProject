using BarcodeGeneratorReader;
using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

class Program
{
    static void Main(string[] args)
    {
        // Veriyi al
        Console.WriteLine("Veri girin:");
        string data = Console.ReadLine();

        // Barcode oluştur
        BarcodeWriter<Bitmap> writer = new BarcodeWriter<Bitmap>();
        writer.Format = BarcodeFormat.QR_CODE;
        writer.Options = new EncodingOptions
        {
            Width = 400,
            Height = 400,
            Margin = 0
        };



        var result = writer.Write(data);

        // Barcode'u dosyaya kaydet
        string path = "barcode.png";
        if (File.Exists(path))
            File.Delete(path);

        using (var file = new FileStream(path, FileMode.CreateNew))
        {
            result.Save(file, System.Drawing.Imaging.ImageFormat.Png);
        }


        // Barcode oku

        var reader = new BarcodeReader(new BarcodeReader(), new DecodingOptions { TryHarder = true });


        reader.Options = new DecodingOptions { TryHarder = true };

        var barcodeBitmap = new Bitmap(path);

        var result2 = reader.Decode(new Bitmap(@"barcode.png"));

        //// Sonucu göster
        //Console.WriteLine("Okunan veri: " + result2.Text);
        //Console.ReadLine();




    }
}
