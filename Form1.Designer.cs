namespace QRCodeAutomation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.btnNavGenerator = new System.Windows.Forms.Button();
            this.btnNavReader = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            
            // Generator Panel
            this.panelGenerator = new System.Windows.Forms.Panel();
            this.lblGenTitle = new System.Windows.Forms.Label();
            this.lblInputLabel = new System.Windows.Forms.Label();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.btnSelectLogo = new System.Windows.Forms.Button();
            this.btnRemoveLogo = new System.Windows.Forms.Button();
            this.lblLogoStatus = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelQRBox = new System.Windows.Forms.Panel();
            this.picQRPreview = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new System.Windows.Forms.Button();

            // Reader Panel
            this.panelReader = new System.Windows.Forms.Panel();
            this.lblReadTitle = new System.Windows.Forms.Label();
            this.btnLoadQRImage = new System.Windows.Forms.Button();
            this.panelLoadBox = new System.Windows.Forms.Panel();
            this.picLoadedQR = new System.Windows.Forms.PictureBox();
            this.btnReadQR = new System.Windows.Forms.Button();
            this.lblResultLabel = new System.Windows.Forms.Label();
            this.txtReadResult = new System.Windows.Forms.TextBox();
            this.btnCopyResult = new System.Windows.Forms.Button();

            this.panelSidebar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelGenerator.SuspendLayout();
            this.panelQRBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRPreview)).BeginInit();
            this.panelReader.SuspendLayout();
            this.panelLoadBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadedQR)).BeginInit();
            this.SuspendLayout();

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Controls.Add(this.btnNavGenerator);
            this.panelSidebar.Controls.Add(this.btnNavReader);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 548);
            this.panelSidebar.TabIndex = 0;

            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248))))); // Cyan/Sky blue
            this.lblSidebarTitle.Location = new System.Drawing.Point(15, 20);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(120, 25);
            this.lblSidebarTitle.Text = "QR STUDIO";

            // 
            // btnNavGenerator
            // 
            this.btnNavGenerator.FlatAppearance.BorderSize = 0;
            this.btnNavGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGenerator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavGenerator.Location = new System.Drawing.Point(0, 80);
            this.btnNavGenerator.Name = "btnNavGenerator";
            this.btnNavGenerator.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavGenerator.Size = new System.Drawing.Size(180, 45);
            this.btnNavGenerator.Text = "QR Kod Üret";
            this.btnNavGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGenerator.UseVisualStyleBackColor = true;
            this.btnNavGenerator.Click += new System.EventHandler(this.btnNavGenerator_Click);

            // 
            // btnNavReader
            // 
            this.btnNavReader.FlatAppearance.BorderSize = 0;
            this.btnNavReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavReader.Location = new System.Drawing.Point(0, 125);
            this.btnNavReader.Name = "btnNavReader";
            this.btnNavReader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavReader.Size = new System.Drawing.Size(180, 45);
            this.btnNavReader.Text = "QR Kod Oku";
            this.btnNavReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReader.UseVisualStyleBackColor = true;
            this.btnNavReader.Click += new System.EventHandler(this.btnNavReader_Click);

            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59))))); // Slate Gray 800
            this.panelContainer.Controls.Add(this.panelGenerator);
            this.panelContainer.Controls.Add(this.panelReader);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(180, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(523, 548);
            this.panelContainer.TabIndex = 1;

            // 
            // panelGenerator
            // 
            this.panelGenerator.Controls.Add(this.lblGenTitle);
            this.panelGenerator.Controls.Add(this.lblInputLabel);
            this.panelGenerator.Controls.Add(this.txtInputText);
            this.panelGenerator.Controls.Add(this.btnSelectLogo);
            this.panelGenerator.Controls.Add(this.btnRemoveLogo);
            this.panelGenerator.Controls.Add(this.lblLogoStatus);
            this.panelGenerator.Controls.Add(this.btnGenerate);
            this.panelGenerator.Controls.Add(this.panelQRBox);
            this.panelGenerator.Controls.Add(this.btnSaveQR);
            this.panelGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGenerator.Location = new System.Drawing.Point(0, 0);
            this.panelGenerator.Name = "panelGenerator";
            this.panelGenerator.Size = new System.Drawing.Size(523, 548);
            this.panelGenerator.TabIndex = 0;

            // 
            // lblGenTitle
            // 
            this.lblGenTitle.AutoSize = true;
            this.lblGenTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenTitle.ForeColor = System.Drawing.Color.White;
            this.lblGenTitle.Location = new System.Drawing.Point(20, 20);
            this.lblGenTitle.Name = "lblGenTitle";
            this.lblGenTitle.Size = new System.Drawing.Size(142, 30);
            this.lblGenTitle.Text = "QR Kod Üret";

            // 
            // lblInputLabel
            // 
            this.lblInputLabel.AutoSize = true;
            this.lblInputLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblInputLabel.Location = new System.Drawing.Point(20, 65);
            this.lblInputLabel.Name = "lblInputLabel";
            this.lblInputLabel.Size = new System.Drawing.Size(166, 17);
            this.lblInputLabel.Text = "Metin veya URL adresi girin:";

            // 
            // txtInputText
            // 
            this.txtInputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputText.ForeColor = System.Drawing.Color.White;
            this.txtInputText.Location = new System.Drawing.Point(20, 90);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(250, 150);
            this.txtInputText.TabIndex = 0;

            // 
            // btnSelectLogo
            // 
            this.btnSelectLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSelectLogo.FlatAppearance.BorderSize = 0;
            this.btnSelectLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectLogo.ForeColor = System.Drawing.Color.White;
            this.btnSelectLogo.Location = new System.Drawing.Point(20, 250);
            this.btnSelectLogo.Name = "btnSelectLogo";
            this.btnSelectLogo.Size = new System.Drawing.Size(100, 32);
            this.btnSelectLogo.Text = "Logo Ekle";
            this.btnSelectLogo.UseVisualStyleBackColor = false;
            this.btnSelectLogo.Click += new System.EventHandler(this.btnSelectLogo_Click);

            // 
            // btnRemoveLogo
            // 
            this.btnRemoveLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRemoveLogo.FlatAppearance.BorderSize = 0;
            this.btnRemoveLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveLogo.ForeColor = System.Drawing.Color.White;
            this.btnRemoveLogo.Location = new System.Drawing.Point(125, 250);
            this.btnRemoveLogo.Name = "btnRemoveLogo";
            this.btnRemoveLogo.Size = new System.Drawing.Size(25, 32);
            this.btnRemoveLogo.Text = "X";
            this.btnRemoveLogo.UseVisualStyleBackColor = false;
            this.btnRemoveLogo.Visible = false;
            this.btnRemoveLogo.Click += new System.EventHandler(this.btnRemoveLogo_Click);

            // 
            // lblLogoStatus
            // 
            this.lblLogoStatus.AutoSize = true;
            this.lblLogoStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLogoStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLogoStatus.Location = new System.Drawing.Point(20, 290);
            this.lblLogoStatus.Name = "lblLogoStatus";
            this.lblLogoStatus.Size = new System.Drawing.Size(250, 15);
            this.lblLogoStatus.Text = "Logo seçilmedi (isteğe bağlı)";

            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129))))); // Emerald green
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(20, 325);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(250, 45);
            this.btnGenerate.Text = "QR Kodu Üret";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // 
            // panelQRBox
            // 
            this.panelQRBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelQRBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQRBox.Controls.Add(this.picQRPreview);
            this.panelQRBox.Location = new System.Drawing.Point(290, 90);
            this.panelQRBox.Name = "panelQRBox";
            this.panelQRBox.Size = new System.Drawing.Size(210, 210);
            this.panelQRBox.TabIndex = 6;

            // 
            // picQRPreview
            // 
            this.picQRPreview.Location = new System.Drawing.Point(5, 5);
            this.picQRPreview.Name = "picQRPreview";
            this.picQRPreview.Size = new System.Drawing.Size(200, 200);
            this.picQRPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRPreview.TabIndex = 0;
            this.picQRPreview.TabStop = false;

            // 
            // btnSaveQR
            // 
            this.btnSaveQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233))))); // Sky blue
            this.btnSaveQR.Enabled = false;
            this.btnSaveQR.FlatAppearance.BorderSize = 0;
            this.btnSaveQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveQR.ForeColor = System.Drawing.Color.White;
            this.btnSaveQR.Location = new System.Drawing.Point(290, 325);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(210, 45);
            this.btnSaveQR.Text = "QR Görselini Kaydet";
            this.btnSaveQR.UseVisualStyleBackColor = false;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);


            // 
            // panelReader
            // 
            this.panelReader.Controls.Add(this.lblReadTitle);
            this.panelReader.Controls.Add(this.btnLoadQRImage);
            this.panelReader.Controls.Add(this.panelLoadBox);
            this.panelReader.Controls.Add(this.btnReadQR);
            this.panelReader.Controls.Add(this.lblResultLabel);
            this.panelReader.Controls.Add(this.txtReadResult);
            this.panelReader.Controls.Add(this.btnCopyResult);
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(523, 548);
            this.panelReader.TabIndex = 1;
            this.panelReader.Visible = false;

            // 
            // lblReadTitle
            // 
            this.lblReadTitle.AutoSize = true;
            this.lblReadTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReadTitle.ForeColor = System.Drawing.Color.White;
            this.lblReadTitle.Location = new System.Drawing.Point(20, 20);
            this.lblReadTitle.Name = "lblReadTitle";
            this.lblReadTitle.Size = new System.Drawing.Size(144, 30);
            this.lblReadTitle.Text = "QR Kod Oku";

            // 
            // btnLoadQRImage
            // 
            this.btnLoadQRImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLoadQRImage.FlatAppearance.BorderSize = 0;
            this.btnLoadQRImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQRImage.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadQRImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadQRImage.Location = new System.Drawing.Point(20, 90);
            this.btnLoadQRImage.Name = "btnLoadQRImage";
            this.btnLoadQRImage.Size = new System.Drawing.Size(210, 35);
            this.btnLoadQRImage.Text = "QR Görseli Seç";
            this.btnLoadQRImage.UseVisualStyleBackColor = false;
            this.btnLoadQRImage.Click += new System.EventHandler(this.btnLoadQRImage_Click);

            // 
            // panelLoadBox
            // 
            this.panelLoadBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelLoadBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadBox.Controls.Add(this.picLoadedQR);
            this.panelLoadBox.Location = new System.Drawing.Point(20, 140);
            this.panelLoadBox.Name = "panelLoadBox";
            this.panelLoadBox.Size = new System.Drawing.Size(210, 210);
            this.panelLoadBox.TabIndex = 2;

            // 
            // picLoadedQR
            // 
            this.picLoadedQR.Location = new System.Drawing.Point(5, 5);
            this.picLoadedQR.Name = "picLoadedQR";
            this.picLoadedQR.Size = new System.Drawing.Size(200, 200);
            this.picLoadedQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoadedQR.TabIndex = 0;
            this.picLoadedQR.TabStop = false;

            // 
            // btnReadQR
            // 
            this.btnReadQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnReadQR.Enabled = false;
            this.btnReadQR.FlatAppearance.BorderSize = 0;
            this.btnReadQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadQR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReadQR.ForeColor = System.Drawing.Color.White;
            this.btnReadQR.Location = new System.Drawing.Point(20, 370);
            this.btnReadQR.Name = "btnReadQR";
            this.btnReadQR.Size = new System.Drawing.Size(210, 45);
            this.btnReadQR.Text = "Çözümle & Oku";
            this.btnReadQR.UseVisualStyleBackColor = false;
            this.btnReadQR.Click += new System.EventHandler(this.btnReadQR_Click);

            // 
            // lblResultLabel
            // 
            this.lblResultLabel.AutoSize = true;
            this.lblResultLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblResultLabel.Location = new System.Drawing.Point(260, 90);
            this.lblResultLabel.Name = "lblResultLabel";
            this.lblResultLabel.Size = new System.Drawing.Size(107, 19);
            this.lblResultLabel.Text = "Okunan İçerik:";

            // 
            // txtReadResult
            // 
            this.txtReadResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtReadResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReadResult.ForeColor = System.Drawing.Color.White;
            this.txtReadResult.Location = new System.Drawing.Point(260, 115);
            this.txtReadResult.Multiline = true;
            this.txtReadResult.Name = "txtReadResult";
            this.txtReadResult.ReadOnly = true;
            this.txtReadResult.Size = new System.Drawing.Size(240, 235);
            this.txtReadResult.TabIndex = 5;

            // 
            // btnCopyResult
            // 
            this.btnCopyResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(165)))), ((int)(((byte)(233)))));
            this.btnCopyResult.FlatAppearance.BorderSize = 0;
            this.btnCopyResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyResult.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyResult.ForeColor = System.Drawing.Color.White;
            this.btnCopyResult.Location = new System.Drawing.Point(260, 370);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(240, 45);
            this.btnCopyResult.Text = "Sonucu Panoya Kopyala";
            this.btnCopyResult.UseVisualStyleBackColor = false;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 548);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelGenerator.ResumeLayout(false);
            this.panelGenerator.PerformLayout();
            this.panelQRBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQRPreview)).EndInit();
            this.panelReader.ResumeLayout(false);
            this.panelReader.PerformLayout();
            this.panelLoadBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadedQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Button btnNavGenerator;
        private System.Windows.Forms.Button btnNavReader;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelGenerator;
        private System.Windows.Forms.Label lblGenTitle;
        private System.Windows.Forms.Label lblInputLabel;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.Button btnSelectLogo;
        private System.Windows.Forms.Button btnRemoveLogo;
        private System.Windows.Forms.Label lblLogoStatus;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panelQRBox;
        private System.Windows.Forms.PictureBox picQRPreview;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Panel panelReader;
        private System.Windows.Forms.Label lblReadTitle;
        private System.Windows.Forms.Button btnLoadQRImage;
        private System.Windows.Forms.Panel panelLoadBox;
        private System.Windows.Forms.PictureBox picLoadedQR;
        private System.Windows.Forms.Button btnReadQR;
        private System.Windows.Forms.Label lblResultLabel;
        private System.Windows.Forms.TextBox txtReadResult;
        private System.Windows.Forms.Button btnCopyResult;
    }
}
