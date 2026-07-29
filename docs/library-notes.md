# QR Code Automation - Kullanılan Kütüphaneler ve Çalıştırma Notları

Bu projede QR kod üretimi ve çözümlenmesi için tercih ettiğim stabil NuGet paketleri ve kurulum detayları aşağıdadır.

---

## 1. Kullanılan Kütüphaneler (Libraries Used)

### QR Kod Üretimi (Generation)
* **QRCoder**: C# ve .NET projelerinde bağımsız, ekstra bağımlılık gerektirmeden hızlı bir şekilde QR kod üretmek için en stabil ve popüler kütüphanedir.
* **NuGet Kurulum Komutu**:
  ```bash
  dotnet add package QRCoder
  # veya Paket Yöneticisi Konsolu üzerinden:
  Install-Package QRCoder
  ```

### QR Kod Okuma (Reading)
* **ZXing.Net**: Multi-format 1D/2D barkod/QR kod görüntü işleme ve okuma kütüphanesidir. Java'daki popüler ZXing kütüphanesinin .NET portudur.
* **ZXing.Net.Bindings.Windows.Compatibility**: .NET 6/7/8 projelerinde `System.Drawing.Common` (Bitmap sınıfı) desteği ile görselleri doğrudan okuyabilmek için ek bağlayıcı paket.
* **NuGet Kurulum Komutu**:
  ```bash
  dotnet add package ZXing.Net
  dotnet add package ZXing.Net.Bindings.Windows.Compatibility
  # veya Paket Yöneticisi Konsolu üzerinden:
  Install-Package ZXing.Net
  Install-Package ZXing.Net.Bindings.Windows.Compatibility
  ```

---

## 2. Projeyi Çalıştırma (How to Run)

1. Proje klasöründe yeni bir .NET Konsol uygulaması oluşturun veya mevcut bir projeye dahil edin:
   ```bash
   dotnet new console
   ```
2. Yukarıdaki NuGet paketlerini projeye yükleyin.
3. İlgili `.cs` dosyalarını projenize ekleyin.
4. Logolu QR kod testi yapacaksanız, kodun çalıştırıldığı dizine `logo.png` adında küçük bir görsel yerleştirmeyi unutmayın.
5. Uygulamayı derleyip çalıştırın:
   ```bash
   dotnet run
   ```
