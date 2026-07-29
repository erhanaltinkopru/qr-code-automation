/*
 * Bu kod örneğinde, QRCoder kütüphanesini ve System.Drawing nesnelerini
 * kullanarak üretilen QR kodun tam ortasına özel bir logo (örneğin firma logosu)
 * yerleştirmeyi gösteriyorum. Okunabilirliği bozmamak için logo boyutunun
 * çok büyük olmamasına dikkat etmeliyiz.
 */

using System;
using System.Drawing;
using System.Drawing.Imaging;
using QRCoder;

namespace QRCodeAutomation.Generate
{
    class QRWithLogo
    {
        public static void GenerateQRWithLogo(string textToEncode, string logoPath, string outputPath)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                // Hata düzeltme seviyesini (ECC) H (High) seçiyoruz ki ortadaki logo
                // QR kodun bir kısmını kapattığında bile kod okunmaya devam edebilsin.
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.H))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        // QR kodu bitmap olarak alıyoruz (Piksel boyutu 20, renkler siyah/beyaz)
                        using (Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true))
                        {
                            // Ortaya yerleştireceğimiz logoyu yüklüyoruz
                            using (Bitmap logoImage = new Bitmap(logoPath))
                            {
                                // QR kod ve logo çizim işlemlerini gerçekleştiriyoruz
                                using (Graphics g = Graphics.FromImage(qrCodeImage))
                                {
                                    // Logonun konumunu QR kodun tam ortası olarak hesaplıyoruz
                                    int logoWidth = qrCodeImage.Width / 5;  // Logo genişliği QR kodun 5'te 1'i kadar
                                    int logoHeight = qrCodeImage.Height / 5;
                                    int left = (qrCodeImage.Width - logoWidth) / 2;
                                    int top = (qrCodeImage.Height - logoHeight) / 2;

                                    // Logoyu çiziyoruz
                                    g.DrawImage(logoImage, new Rectangle(left, top, logoWidth, logoHeight));
                                }

                                // Sonucu kaydediyoruz
                                qrCodeImage.Save(outputPath, ImageFormat.Png);
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Logolu QR Kod başarıyla üretildi: {outputPath}");
        }

        static void Main(string[] args)
        {
            string sampleText = "https://erhanaltinkopru.com";
            string logo = "logo.png"; // Diskte var olması gereken logo dosyası
            string output = "qr_with_logo.png";

            try
            {
                GenerateQRWithLogo(sampleText, logo, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                Console.WriteLine("Not: Bu örneği çalıştırmak için 'logo.png' adında bir görselin proje dizininde bulunması gerekir.");
            }
        }
    }
}
