using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using QRCoder;
using ZXing;

namespace QRCodeAutomation
{
    public partial class Form1 : Form
    {
        private string? selectedLogoPath = null;
        private string? loadedQRImagePath = null;
        private Bitmap? generatedQRBitmap = null;

        public Form1()
        {
            InitializeComponent();
            SetupCustomStyles();
        }

        private void SetupCustomStyles()
        {
            // Set Form properties
            this.Text = "QR Code Automation Studio";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Initialize default tab states
            ShowPanel(panelGenerator);
            btnNavGenerator.BackColor = Color.FromArgb(30, 41, 59); // Active slate color
            btnNavGenerator.ForeColor = Color.White;
            btnNavReader.BackColor = Color.FromArgb(15, 23, 42); // Sidebar dark slate
            btnNavReader.ForeColor = Color.FromArgb(148, 163, 184); // Cool grey
        }

        private void ShowPanel(Panel activePanel)
        {
            panelGenerator.Visible = (activePanel == panelGenerator);
            panelReader.Visible = (activePanel == panelReader);
        }

        private void btnNavGenerator_Click(object sender, EventArgs e)
        {
            ShowPanel(panelGenerator);
            btnNavGenerator.BackColor = Color.FromArgb(30, 41, 59);
            btnNavGenerator.ForeColor = Color.White;
            btnNavReader.BackColor = Color.FromArgb(15, 23, 42);
            btnNavReader.ForeColor = Color.FromArgb(148, 163, 184);
        }

        private void btnNavReader_Click(object sender, EventArgs e)
        {
            ShowPanel(panelReader);
            btnNavReader.BackColor = Color.FromArgb(30, 41, 59);
            btnNavReader.ForeColor = Color.White;
            btnNavGenerator.BackColor = Color.FromArgb(15, 23, 42);
            btnNavGenerator.ForeColor = Color.FromArgb(148, 163, 184);
        }

        // --- QR GENERATION LOGIC ---
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string textToEncode = txtInputText.Text.Trim();
            if (string.IsNullOrEmpty(textToEncode))
            {
                MessageBox.Show("Lütfen QR koda dönüştürülecek bir metin girin kanka.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.Q;
                if (selectedLogoPath != null)
                {
                    // Logo varsa hata düzeltmeyi en üst seviye olan H (High) yapıyoruz.
                    eccLevel = QRCodeGenerator.ECCLevel.H;
                }

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode, eccLevel))
                    {
                        using (QRCode qrCode = new QRCode(qrCodeData))
                        {
                            // QR Kodu oluştur
                            Bitmap qrBitmap = qrCode.GetGraphic(20, Color.Black, Color.White, true);

                            // Eğer logo seçildiyse ortasına ekle
                            if (selectedLogoPath != null && File.Exists(selectedLogoPath))
                            {
                                using (Bitmap logoImage = new Bitmap(selectedLogoPath))
                                {
                                    using (Graphics g = Graphics.FromImage(qrBitmap))
                                    {
                                        int logoSize = qrBitmap.Width / 5; // Logo boyutu QR kodun 5'te 1'i
                                        int left = (qrBitmap.Width - logoSize) / 2;
                                        int top = (qrBitmap.Height - logoSize) / 2;

                                        g.DrawImage(logoImage, new Rectangle(left, top, logoSize, logoSize));
                                    }
                                }
                            }

                            // Önceki bitmap'i temizle
                            generatedQRBitmap?.Dispose();
                            generatedQRBitmap = qrBitmap;

                            // PictureBox'ta göster
                            picQRPreview.Image = generatedQRBitmap;
                            btnSaveQR.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"QR üretilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Görsel Dosyaları (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
                ofd.Title = "QR Ortasına Eklenecek Logo Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedLogoPath = ofd.FileName;
                    lblLogoStatus.Text = Path.GetFileName(ofd.FileName);
                    lblLogoStatus.ForeColor = Color.FromArgb(16, 185, 129); // Emerald green status
                    btnRemoveLogo.Visible = true;
                }
            }
        }

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            selectedLogoPath = null;
            lblLogoStatus.Text = "Logo seçilmedi (isteğe bağlı)";
            lblLogoStatus.ForeColor = Color.FromArgb(148, 163, 184); // Cool grey
            btnRemoveLogo.Visible = false;
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            if (generatedQRBitmap == null) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG Dosyası (*.png)|*.png";
                sfd.FileName = "generated_qr.png";
                sfd.Title = "QR Kodu Kaydet";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        generatedQRBitmap.Save(sfd.FileName, ImageFormat.Png);
                        MessageBox.Show("QR Kod başarıyla kaydedildi kanka!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kaydetme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- QR READING LOGIC ---
        private void btnLoadQRImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Görsel Dosyaları (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Title = "Çözümlenecek QR Kod Görseli Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        loadedQRImagePath = ofd.FileName;
                        picLoadedQR.Image = Image.FromFile(ofd.FileName);
                        txtReadResult.Text = "";
                        btnReadQR.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Görsel yüklenemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnReadQR_Click(object sender, EventArgs e)
        {
            if (loadedQRImagePath == null || !File.Exists(loadedQRImagePath)) return;

            try
            {
                using (Bitmap bitmap = new Bitmap(loadedQRImagePath))
                {
                    ZXing.Windows.Compatibility.BarcodeReader reader = new ZXing.Windows.Compatibility.BarcodeReader
                    {
                        AutoRotate = true,
                        Options = new ZXing.Common.DecodingOptions
                        {
                            TryHarder = true,
                            PossibleFormats = new[] { BarcodeFormat.QR_CODE }
                        }
                    };

                    Result result = reader.Decode(bitmap);

                    if (result != null)
                    {
                        txtReadResult.Text = result.Text;
                        txtReadResult.ForeColor = Color.FromArgb(16, 185, 129); // Success green
                    }
                    else
                    {
                        txtReadResult.Text = "HATA: Görsel üzerinde geçerli bir QR kod çözümlenemedi kanka.";
                        txtReadResult.ForeColor = Color.FromArgb(239, 68, 68); // Red color for error
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Okuma sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtReadResult.Text) && !txtReadResult.Text.StartsWith("HATA:"))
            {
                Clipboard.SetText(txtReadResult.Text);
                MessageBox.Show("QR kod içeriği panoya kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
