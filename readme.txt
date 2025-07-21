Yemek Tanıtım Sitesi - ASP.NET Projesi

Bu proje, ASP.NET kullanılarak geliştirilmiş bir yemek tanıtım uygulamasıdır. HTML, CSS ve Razor yapılarıyla birlikte çalışır. Aşağıda projede yer alan sayfaların açıklamaları bulunmaktadır:

Navigasyon Bar:
Tüm sayfaların üst kısmında bir navigasyon bar (menü çubuğu) yer almaktadır. Bu bar, kullanıcıların sayfalar arasında kolayca geçiş yapmasını sağlar. ASP.NET layout dosyası (örneğin _Layout.cshtml) üzerinden tanımlanmıştır ve tüm sayfalarda ortak olarak görünür.

Menü Görüntüleme (Ana Sayfa):
Amaç: Kullanıcılara sitede sunulan yemekleri tanıtmak ve menüyü görsel destekli olarak sergilemek.
Menü, anasayfa üzerinde yer almakta olup her yemeğin görseli, genel adı ve varsa çeşitleri gösterilmektedir. İçerik Razor View sayfasında (Index.cshtml) dinamik ya da statik olarak sunulur.

Kullanıcı Kayıt Ekranı:
Amaç: Kullanıcıların siteye kayıt olmasını sağlamak.
Bu sayfada bir form yapısı yer almaktadır. Form alanları: Ad Soyad, Kullanıcı Adı, E-posta ve Şifre.
ASP.NET form yapısı kullanılmıştır ve veriler POST yöntemiyle sunucuya gönderilir. Kayıt bilgileri, formun gönderilmesiyle birlikte arka planda (Controller aracılığıyla) işlenerek bir listeye eklenir ya da veritabanına kaydedilebilir.

Kayıt Listesi Sayfası:
Amaç: Kayıt olan kullanıcıların bilgilerini tablo hâlinde listelemek.
Bu sayfa, HTML table yapısı ile hazırlanmıştır. Sütun başlıkları: Ad Soyad, E-posta ve Kullanıcı Adı.
Veriler, Controller üzerinden View’a model olarak gönderilir ve foreach döngüsü ile listelenir.

İletişim Sayfası:
Amaç: Kullanıcıların site yönetimiyle veya restoranla iletişim kurmasını sağlamak.
Formda Ad Soyad, E-posta ve Mesaj alanları yer alır. Mesaj bölümü için textarea kullanılmıştır.
Form verileri Gönder butonuna basıldığında Controller üzerinden işlenebilir veya doğrulama yapılabilir.

Not: Proje ASP.NET MVC yapısıyla geliştirilmiştir. Formlardan gelen veriler Controller’lar aracılığıyla yönetilir ve View sayfalarında kullanıcıya sunulur. Veri kalıcılığı için opsiyonel olarak veritabanı bağlantısı da yapılabilir.