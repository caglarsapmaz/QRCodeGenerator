using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder; // QR kod kütüphanesini içeri alıyoruz

namespace QRCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı kutuyu boş bırakıp butona basarsa program çökmesin diye uyarı veriyoruz
            if (string.IsNullOrWhiteSpace(txtLink.Text))
            {
                MessageBox.Show("Lütfen önce bir link veya metin girin!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kodu burada durdur, aşağıya devam etme
            }

            string text = txtLink.Text;

            // QR kod oluşturucu nesnesini tanımlıyoruz
            QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();

            // Veriyi QR formata çeviriyoruz
            QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCoder.QRCodeGenerator.ECCLevel.Q);

            // QRCode nesnesini oluşturuyoruz
            QRCode qrCode = new QRCode(qrCodeData);

            // 20 piksel boyutunda QR kod görselini (Bitmap) alıyoruz
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Çıkan görseli ekrandaki PictureBox'a aktarıyoruz
            pictureBox1.Image = qrCodeImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Önce PictureBox'ta bir QR kod var mı diye kontrol ediyoruz
            if (pictureBox1.Image != null)
            {
                // Kaydetme penceresi oluşturuyoruz
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Resmi|*.png|JPEG Resmi|*.jpg"; // Dosya türleri
                saveFileDialog.Title = "QR Kodu Kaydet";

                // Kullanıcı bir yer seçip 'Kaydet'e basarsa:
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                    MessageBox.Show("QR Kod başarıyla kaydedildi!", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Eğer QR kod oluşturmadan kaydetmeye basarsa uyarı veriyoruz
                MessageBox.Show("Önce bir QR kod oluşturmalısın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}