# 📞 Telekomünikasyon Otomasyon Sistemi  

## 📌 Proje Hakkında  
Bu proje, **C# ve MSSQL** kullanılarak geliştirilmiş bir **telekomünikasyon otomasyon sistemi**dir. Kullanıcılar sisteme **kullanıcı adı, parola ve kullanıcı tipi** ile giriş yapar. Üç farklı kullanıcı tipi bulunmaktadır:  

1. **Asistan**  
2. **Takım Lideri**  
3. **Grup Yöneticisi**  

Her kullanıcı tipinin farklı yetkileri ve erişim izinleri bulunmaktadır.  

## 🚀 Özellikler  

### 👩‍💻 Asistan Özellikleri  
- **Müşteri Çağrı Listesi**:  
  - Müşterilerin çağrı geçmişini görüntüleyebilir.  
  - Yeni müşteri çağrısı oluşturabilir.  
- **Aylık Prim Listesi**:  
  - Asistanın aylara göre aldığı primleri görüntüler.  
  - Son alınan prime **itiraz edebilir**.  
- **İtirazlarım**:  
  - Yapılan itirazları görüntüleyebilir.  
  - İtirazın **onaylanıp onaylanmadığını takip edebilir**.  

### 🏆 Takım Lideri Özellikleri  
- **İtiraz Listesi**:  
  - Asistanların yaptığı itirazları listeleyebilir.  
  - Seçili bir itiraza **cevap verebilir** (Onaylayabilir veya Reddedebilir).  
  - **Bilgilendir** butonu aracılığıyla, verilen cevap hakkında **grup yöneticilerine e-posta gönderebilir**.  

### 📧 Grup Yöneticisi Özellikleri  
- Grup yöneticileri sisteme giriş yapabilir ancak uygulama içinde herhangi bir işlem yapamazlar.  
- **Takım liderlerinin yaptığı itiraz değerlendirmeleri hakkında e-posta alırlar**.  

## 🏗️ Teknolojiler & Araçlar  
| Teknoloji | Açıklama |  
|-----------|---------|  
| **C# (.NET Framework)** | Uygulamanın temel yazılım dili |  
| **MSSQL** | Veritabanı yönetimi |  
| **Entity Framework** | Veritabanı işlemleri için ORM |  
| **SMTP (E-posta Gönderimi)** | Grup yöneticilerine bilgilendirme maili göndermek için |  
