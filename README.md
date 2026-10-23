# Malzeme Listesi

<p align="center">
  <strong>Malzeme kayıtları için Windows masaüstü arayüzü</strong><br>
  WPF ve SQLite tabanlı uygulama; Material Design bileşenleriyle modern arayüz.
</p>

<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-8.0%20Windows-512BD4?logo=dotnet&logoColor=white">
  <img alt="UI" src="https://img.shields.io/badge/UI-WPF-0078D4?logo=windows&logoColor=white">
  <img alt="Database" src="https://img.shields.io/badge/Database-SQLite-003B57?logo=sqlite&logoColor=white">
  <img alt="UI library" src="https://img.shields.io/badge/Design-Material%20Design-757575">
</p>

---

## Genel Bakış

Malzeme Listesi, .NET 8 Windows ve WPF ile oluşturulmuş bir masaüstü uygulamasıdır. Proje bağımlılıklarında SQLite ve Material Design temaları yer alır. Ana pencerede ayarlar penceresini açan bir kontrol ve özel başlık çubuğu davranışları bulunmaktadır.

## Teknolojiler

- C# / .NET 8 for Windows
- WPF ve XAML
- Microsoft.Data.Sqlite
- MaterialDesignThemes ve MaterialDesignColors

## Özellik Alanları

- 🧰 Malzeme listesi için masaüstü uygulama çatısı
- 🗃️ SQLite veri katmanı için paket desteği
- 🎨 Material Design tabanlı arayüz bileşenleri
- ⚙️ Ayarlar penceresi
- 🪟 Özel pencere başlığı, küçültme, büyütme ve kapatma kontrolleri

> Bu açıklama projedeki paketler ve ana pencere koduna dayanır. Malzeme ekleme/düzenleme, içe/dışa aktarma gibi ayrıntılı işlevler ancak ilgili ekran ve veri katmanı kodu incelendikten sonra kesinleştirilebilir.

## Derleme

1. Windows üzerinde .NET 8 SDK kurun.
2. Visual Studio ile MalzemeListesi.sln dosyasını açın.
3. NuGet paketlerini geri yükleyin.
4. Release yapılandırmasında derleyin.
5. Uygulamayı ilk çalıştırmada veritabanı dosyasının oluşturulduğunu ve uygulama yazma izinlerini doğrulayın.

Komut satırı:

- dotnet restore .\\MalzemeListesi.sln
- dotnet build .\\MalzemeListesi.sln -c Release

## Veri ve Bakım

- SQLite veritabanını düzenli yedekleyin.
- Uygulamanın yazdığı dosyaların konumunu ve Windows kullanıcı izinlerini kontrol edin.
- Gerçek kullanım öncesinde verilerin eklenmesi, düzenlenmesi ve uygulama yeniden açıldığında korunması senaryolarını test edin.

## Durum

Bu README mevcut proje yapısını özetler. Uygulamanın tüm işlevleri ve veri şeması için kaynak kodun geri kalanı ayrıca gözden geçirilmelidir.
