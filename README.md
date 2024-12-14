# MyPortfolio Projesi

ASP.NET MVC ile geliştirdiğim bu portföy projesinde, SQL veritabanı işlemleri için Entity Framework – DbFirst yaklaşımını kullandım. Projenin amacı, 
kişisel yeteneklerimi, deneyimlerimi ve projelerimi tanıtan bir platform oluşturarak hem profesyonel alanda kendimi ifade edebilmek hem de yazılım geliştirme 
becerilerimi sergilemektir. Kullanıcı tarafında, ziyaretçiler “Giriş Bilgileri” ile karşılanırken, “Hakkımda Alanı”, “Uzmanlıklar”, "Kategoriler" ve kategoriler ile ilişkili 
“Projeler”, “Referanslar”, “Eğitimler” ve “Deneyimler” bölümleri ile zengin bir içerik sunulmaktadır. Sayfanın sonunda ise kullanıcılar için bir “İletişime Geç”
alanı bulunmaktadır. Admin panelinde, tüm bu alanlar üzerinde dinamik bir kontrol sağlanmış ve CRUD işlemleri uygulanmıştır. Ayrıca, güvenli bir yapı için 
doğrulama ve yetkilendirme (authentication & authorization) mekanizmaları ile validation kontrolleri de sisteme entegre edilmiştir.

## Kullanıcı Paneli
Kullanıcı paneli, aşağıdaki sayfaları içeriyor ve ziyaretçilerin proje sahibinin kişisel ve profesyonel bilgilerini keşfetmesine olanak tanıyor:
*	Giriş Bilgileri: Ziyaretçiler, ana sayfada karşılanarak projeye ilk adımı atıyor.
*	Hakkımda Alanı: Proje sahibinin kişisel tanıtımı ve genel bilgiler bu bölümde sunuluyor.
*	Uzmanlıklar ve Projeler: Proje sahibinin sahip olduğu uzmanlık alanları ve bu alanlara ait gerçekleştirdiği projeler detaylı şekilde (github linkleri ile birlikte) görüntülenebiliyor. 
*	Referanslar: Proje sahibine ait referanslar incelenerek daha fazla bilgi edinilebiliyor.
*	Eğitimler ve Deneyimler: Kullanıcılar, proje sahibinin akademik geçmişi ve profesyonel deneyimlerini öğrenebiliyor.
*	İletişime Geç: Sayfanın sonunda yer alan bu bölüm aracılığıyla kullanıcılar, iletişim formu üzerinden doğrudan mesaj gönderebiliyor.
  
Bu sayfalar, portföy projesinin amacına uygun olarak, ziyaretçilere proje sahibinin beceri ve deneyimlerini etkili bir şekilde sunmayı hedefler.

## Admin Paneli
Admin, kendisine atanan yetkiler doğrultusunda Admin Paneli'ne giriş yaparak portföy sitesinin tüm içeriklerini dinamik bir şekilde yönetebilir, panel üzerinden aşağıdaki işlemleri gerçekleştirebilirler:
*	Giriş Alanı : Kullanıcıyı karşılayan metni düzenleyebilir, silebilir, yedek metinler hazırlayıp ‘gösterilmesin’ seçeneğinde tutabilir. 
*	Hakkımda Alanı: Kişisel tanıtım metnini düzenleyebilir, silebilir ve içeriğinde pdf formatında CV belgesi tutabilir. 
*	Uzmanlıklar: : Yeni uzmanlık alanları ekleyebilir, mevcut uzmanlıkları düzenleyebilir veya silebilir.
*	Projeler: Kategoriler ekleyebilir, silebilir, düzenleyebilir ve bu kategoriler ile ilişkili projeler için de aynı işlemleri yapabilir.
*	Referanslar: Sisteme yeni referanslar ekleyebilir, mevcut referansları güncelleyebilir veya silebilir.
*	Eğitimler ve Deneyimler: Admin, eğitim ve deneyim bilgilerini sisteme ekleyebilir, güncelleyebilir veya silebilir.
*	İletişim Mesajları: Kullanıcılardan gelen mesajları “okunmamış mesajlar” ve “tüm mesajlar” şeklinde görüntüleyebilir.
  
Admin paneli, portföy sitesinin içerik yönetimini kolaylaştırmak ve siteyi dinamik bir yapıda tutmak amacıyla kapsamlı bir kontrol mekanizması sunar.

## Proje Özellikleri
*	Asp.Net MVC5 ile geliştirildi.
*	Veritabanı olarak Microsoft SQL Server tercih edildi.
*	Entity Framework ile Database-First yaklaşımı kullanılarak geliştirildi.
*	Fluent Validation kullanılarak giriş doğrulamaları yapılmıştır.
*	Oturum yönetimi Session ile sağlanmış, güvenlik için Authentication ve Authorization mekanizmaları uygulanmıştır.

## Kullanılan Teknolojiler
*	Database First / Entity Framework
*	Authentication / Authorization / Fluent Validation
*	SQL
*	LINQ Sorguları
*	Partial Views

## Proje Görselleri
![2024-12-14_23-36-29](https://github.com/user-attachments/assets/a5c97316-df21-4596-918c-c9ea9ca2f2ca)
![2024-12-14_23-36-49](https://github.com/user-attachments/assets/e15c8a1d-e3d6-4369-8bb7-9ab131b17f67)
![2024-12-14_23-37-13](https://github.com/user-attachments/assets/58c3407b-5261-4a56-8d60-6f1a1d0bfa07)
![2024-12-14_23-38-38](https://github.com/user-attachments/assets/94bf3668-49b8-4be6-9adf-bdef34198a91)
![2024-12-14_23-38-58](https://github.com/user-attachments/assets/9ca1f9d8-0291-4d97-9157-99fd174e0657)

### Admin Tarafı
![2024-12-14_23-52-43](https://github.com/user-attachments/assets/28d4cb1a-3a61-4a1e-9208-8da87c8b68d3)
![2024-12-14_23-52-53](https://github.com/user-attachments/assets/f3964a54-06cf-49ca-b036-a42b24d27303)
![2024-12-14_23-53-28](https://github.com/user-attachments/assets/f97d602f-c654-409b-b1d0-52b348ed1b05)
![2024-12-14_23-54-01](https://github.com/user-attachments/assets/53f0823e-3e20-4809-86f6-2c2f5e4d56ae)
![2024-12-14_23-55-00](https://github.com/user-attachments/assets/10391b9f-0865-40fd-b13b-bb2724756236)
![2024-12-14_23-55-12](https://github.com/user-attachments/assets/9a55867c-a672-4ad4-945b-31bb6a998a0c)
