# BaltaDoS

BaltaDoS, Layer 7 saldırılarını simüle eden bir Denial of Service aracı olarak tasarlanmıştır. İlk olarak 2017 yılında Abdulhalik Akdeniz tarafından geliştirilmiş ancak yayınlanmamıştır. 
Projenin geliştirilmesinde Visual Studio 2012 ve .NET Framework 4.5 kullanılmıştır.


## ✨ Özellikler

- **GET Flood**: Hedef sunucuya sürekli GET istekleri gönderir.
- **POST Flood**: Hedef sunucuya sürekli POST istekleri gönderir.
- **Slowloris**: Birçok bağlantı kurarak sunucuya yavaş HTTP istekleri gönderir ve bağlantıları sürekli açık tutar.
- **SSL Desteği**: SSL ve non-SSL bağlantıları destekler.
- **GUI**: Kullanıcıların saldırı parametrelerini kolayca ayarlayabileceği çeşitli metin kutuları ve kontrol düğmeleri içerir.
- **Çoklu İstemci Desteği**: Threading kullanarak aynı anda birden fazla istemciyi destekler.
- **User-Agent değişimi** : Her HTTP isteği için rastgele olarak belirlenen User-Agent değerleri kullanarak hedef sunucuya istek gönderme. Bu özellik, isteklerin tespit edilmesini zorlaştırarak saldırıların etkinliğini artırır.

## 🖼️ Ekran Görüntüleri

### POST Flooding
![dos1](https://github.com/AbdulhalikAkdeniz/BaltaDoS/assets/139945380/f4c28b87-9b01-4155-82f0-874fc295fbfa)


## ⚙️ Kurulum

1. Projeyi klonlayın veya ZIP olarak indirin:
    ```bash
    git clone https://github.com/AbdulhalikAkdeniz/BaltaDoS.git
    ```
2. Visual Studio veya benzeri IDE'de `baltaDoS.sln` dosyasını açın.

3. Projeyi çalıştırın

4. Alternatif olarak `baltaDoS/bin/Debug/` yolunu izleyerek `Balta DoS v1.0.exe` dosyasını çalıştırabilirsiniz.

## 🚀 Kullanım

1. Hedef sunucunun adresini ve URL giriniz. Flooding esnasında SSL bağlantısı kurulup kurulmayacağını seçiniz.
2. Uygulamanın sağ tarafında yer alan klasör ikonundan saldırı yöntemi seçimi yapılması gerekmektedir.
   proje klasöründe yer alan `get flood.balta` `post flood.balta` veya `slowloris.balta` dosyalarından dilediğinizi seçiniz.
3. Açıklamalar
   - **Saldırgan Limiti**: Thread sayısı
   - **Saldırgan başına soket** : Her bir thread'in sunucuyla bağlantı kuracağı Soket sayısıdır. Slowloris metoduna aittir. Thread sayısı ile çarpımı kadar bağlantıyı aktif tutarak sunucunun kaynaklarının tükenmesine neden olur.
   - **Saniye başına saldırgan** : Thread oluşturma hızıdır. Ani artışta kendi ağınız zarar görebileceğinden düşük tutmak daha iyi sonuç verebilir.
5. Saldırıyı başlatmak için "Vur" butonuna tıklayın. Aktif saldırganlar label'ında thread limitine ulaşılmışsa "Dur" butonu aktifleşecek ve flood'u durdurabilirsiniz.
6. Ayrıca sunucuya düzenli olarak ping atılmaktadır. Eğer uzun süre sunucudan yanıt gelmezse programın altındaki alan yeşilden kırmızı renge dönecektir.

#### Örnek ayarlar : 
- **GET veya POST flood ->** 100 saldırgan (thread), saniye başına saldırgan:5
- **Slowloris ->** thread sayısı:100, saniye başına saldırgan:1, saldırgan başına soket:20

## 📜 Lisans

Bu proje [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html) (GPL-3.0) lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## ⚠️ Sorumluluk Reddi

Bu araç, sadece test ve eğitim amaçlı kullanılmak üzere geliştirilmiştir. Yasal olmayan yollarla kullanımı ciddi yasal sonuçlara yol açabilir. Geliştirici, bu aracın kötüye kullanılması durumunda sorumluluk kabul etmez.

## 📧 İletişim

Sorularınız veya geri bildirimleriniz için lütfen [abdulhalikakdeniz08@gmail.com](mailto:abdulhalikakdeniz08@gmail.com) adresine e-posta gönderin.
