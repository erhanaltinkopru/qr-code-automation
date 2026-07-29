/*
 * Bu kod örneğinde, basit bir metni (örneğin bir URL veya ürün ID'sini)
 * QRCoder kütüphanesi kullanarak nasıl QR koda dönüştüreceğimizi ve
 * PNG formatında diske nasıl kaydedeceğimizi gösteriyorum.
 */

using System;
using System.IO;
using QRCoder;

namespace QRCodeAutomation.Generate
{
    class SimpleQRGenerator
    {
        public static void GenerateQRCode(string textToEncode, string outputPath)
        {
            // QR kod üreticiyi başlatıyoruz
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                // QR kod verisini oluşturuyoruz (Hata düzeltme seviyesini Q seçtik)
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q))
                {
                    // Grafik motorunu başlatıp QR kodu bitmap olarak çiziyoruz
                    using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                    {
                        byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(20);
                        
                        // Dosyaya yazıyoruz
                        File.WriteAllBytes(outputPath, qrCodeAsPngByteArr);
                    }
                }
            }
            Console.WriteLine($"QR Kod başarıyla üretildi: {outputPath}");
        }

        static void Main(string[] args)
        {
            string sampleText = "https://erhanaltinkopru.com";
            string output = "simple_qr.png";
            
            GenerateQRCode(sampleText, output);
        }
    }
}
