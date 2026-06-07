<img width="820" height="820" alt="QRCode-Screenshot" src="https://github.com/user-attachments/assets/70ad05df-1b39-4b61-8219-8c1ad35f950b" />
# QR Code Generator (QR Kod Oluşturucu)

Bu proje, C# dili ve Windows Forms arayüzü kullanılarak geliştirilmiş, kullanıcıların girdikleri metin veya bağlantıları (URL) anlık olarak QR koda dönüştürmesini ve bu kodları yerel cihazlarına kaydetmesini sağlayan bir masaüstü uygulamasıdır.

## 🚀 Özellikler
* **Anlık QR Kod Üretimi:** Girilen metin veya linkleri hızlı bir şekilde QR koda dönüştürür.
* **Hata ve Boş Değer Kontrolü:** Kullanıcı boş bir girdiyle kod oluşturmaya çalıştığında uyarı mekanizması devreye girer.
* **Gelişmiş QR Kalitesi:** `QRCoder` kütüphanesinin `ECCLevel.Q` (Hata Düzeltme Seviyesi) ayarı kullanılarak yüksek çözünürlüklü ve güvenilir QR kodlar üretilir.
* **Görsel Kaydetme Seçeneği:** Üretilen QR kodlar, kullanıcı tarafından seçilen dizine `.png` veya `.jpg` formatında kaydedilebilir.

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler
* **Dil:** C# (.NET)
* **Arayüz:** Windows Forms (WinForms)
* **QR Kod Motoru:** [QRCoder](https://github.com/codebude/QRCoder) NuGet Paketi

## 💻 Kurulum ve Çalıştırma
1. Bu projeyi bilgisayarınıza indirin veya klonlayın:
   ```bash
   git clone [https://github.com/kullaniciadi/QRCodeGenerator.git](https://github.com/kullaniciadi/QRCodeGenerator.git)
