/*
 * Bu kod örneğinde, ZXing.Net kütüphanesini kullanarak diskte var olan
 * bir QR kod görselini (PNG/JPG) okumayı ve içindeki metni/veriyi
 * çözümleyip konsola yazdırmayı gösteriyorum.
 */

using System;
using System.Drawing;
using ZXing;
using ZXing.Windows.Compatibility; // System.Drawing desteği için

namespace QRCodeAutomation.Read
{
    class QRReaderFromImage
    {
        public static void ReadQRCode(string imagePath)
        {
            // Görseli diskten bitmap olarak yüklüyoruz
            using (Bitmap bitmap = new Bitmap(imagePath))
            {
                // Barkod/QR okuyucuyu hazırlıyoruz
                BarcodeReader reader = new BarcodeReader
                {
                    AutoRotate = true, // Farklı açılardaki QR kodları yakalamak için otomatik döndürme açık
                    Options = new ZXing.Common.DecodingOptions
                    {
                        TryHarder = true, // Çözümleme için daha detaylı tarama yapması için
                        PossibleFormats = new[] { BarcodeFormat.QR_CODE } // Sadece QR kod arıyoruz
                    }
                };

                // Görseli çözümleme işlemine sokuyoruz
                Result result = reader.Decode(bitmap);

                if (result != null)
                {
                    Console.WriteLine("QR Kod Çözümlendi!");
                    Console.WriteLine($"İçerik: {result.Text}");
                    Console.WriteLine($"Format : {result.BarcodeFormat}");
                }
                else
                {
                    Console.WriteLine("Görsel üzerinde geçerli bir QR kod bulunamadı.");
                }
            }
        }

        static void Main(string[] args)
        {
            string imagePath = "simple_qr.png";

            try
            {
                ReadQRCode(imagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                Console.WriteLine("Not: Okuma yapabilmek için belirtilen yolda geçerli bir QR kod görseli bulunmalıdır.");
            }
        }
    }
}
