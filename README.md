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

<img width="1914" height="1249" alt="QRCodeGenerator-Screen1" src="https://github.com/user-attachments/assets/5f18b302-2f88-4c57-85ab-3ccc31ed52f1" />
<img width="1914" height="1249" alt="QRCodeGenerator-Screen2" src="https://github.com/user-attachments/assets/405b99d3-6429-48d0-b3e5-ace2e8c6868b" />
