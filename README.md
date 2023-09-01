# Taksit Uygulaması

**Kullandığım Teknolojiler**
--
-Asp.Net Web Forms

-Microsoft Sql Server

-Bootstrap

**Projenin Amacı**
--
Bir Satıcının ürünlerini müşterilerine taksitli şekilde sattığı seneryoda
ürünlerin ve müşterilerin takibini, ödenen miktarları, ödeme tarihlerini, 
taksit eksik ödendiyse eksik miktarı kullanıcıya gösteren ve takibini kolaylaştıran
bir web sitesi yapmayı planladım. Bunu GEDAT'da stajım süresince 3-4 hafta gibi bir süre içerisinde hazırladım.

--
**Uygulamanın Anasayfası**

Proje Açılığı zaman ilk sayfa olarak gelen sayfamızda mevcut müşter, ürün ve taksidi alınmakta olan ürünleri listeledim ve sol tarafta da
bir sidebar mevcut. Buradaki menülerden işlemlerimizi gerçekleştirebiliyoruz.
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/9bad705f-c0b0-4641-bdd8-b9ac7cbd2a04)

**Müşteri Kayıt Sayfası**

Bu sayfaya geçiş yaptığımızda bizden müşterimizin adı-soyadı,tc,tel no, adres bilgilerini istiyor ve veri girişi sırasında hatalı girişleri
önlemek için validation'lar kullandım. Kullanıcı aynı kişiyi girmeye çalıştığında hata vermesi için bir fonksiyon ve girişi önlemek için de trigger yazdım.

![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/adba1411-0e36-4f41-9c98-f7d604afea4d)

**Müşteri İçin Kefil Girişi**
Satıcının istemesine bağlı olarak müşterinin üzerine kefil kaydediyorum.
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/38d10f7e-d626-4e07-a213-6f081f76efe6)
--
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/fd46a453-20d2-47c0-af05-6ca9c6213aac)


**Ürün Girişi Sayfası**

Bu sayfada kullanıcı daha önceden kaydettiği ürünleri görebiliyor ve duruma göre ekleme yapabiliyor.
Yanlış girişleri veya aynı ürünü 2.defa kaydetmeyi önlemek için validationlar kullandım.
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/a01a1448-9e02-407d-ba22-e94aeef1c4fe)

**Ürün Satış Sayfası**

Bu sayfa beni en çok uğraştıran sayfaydı. Kullanıcı seçim yaptıkça fonksiyonlar tetikleniyor ve boşluklar buna göre doluyor.
Bazı hesaplamaları class'ımda gerçekleştirdim.
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/fb70bb1b-e390-48c6-8175-02ab6ac92483)

Kullanıcı ürün seçimi yaptığı zaman ürünün eklendiği fiyat geliyor fakat satış yaparken bunu değiştirebiliyorsunuz ve hesaplama buna göre yapılıyor.
Normalde ps5'ın fiyatı 20.000 ₺ olarak girilmiş ama satış esnasında bu fiyata, satıcı indirim veya zam yapabilir.
Sonrasında bizden taksit miktarı girişi yapmamızı istiyor
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/19984f82-2c32-4b73-8594-824d86765b53)

taksit miktarı girildikten sonra peşin alınan miktar ve aylık ödenmesi beklenen miktar listeleniyor.
Peşin alınan miktarı azaltıp yükseltmemize göre aylık ödenecek taksit miktarı değişiyor örnekte göründüğü üzre:
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/709bff17-91db-4f81-b7e0-b5fb0e8ad77c)

Son olarak da müşterinin bir notu varsa veya ödeme dolar üzerinden yapılacaksa bunun notunu buraya girebiliyoruz. bilgiyi gönderdiğimiz zaman altta yeşil bir alert çıkıyor ve giriş yapılıp yapılmadığını anlıyoruz.
![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/8d0a56b5-b60b-4898-a617-5cf9ecfcc507)

**Ürün Ödeme Sayfası**

Ürün ödeme sayfasının temel görünşü aşağıdaki şekilde:

![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/857de736-cfa2-4920-aaa9-f4d12b658250)

Kullanıcı müşteri araması yapmak istediği zaman textBox'a id de yazabilir müşteri adının ilk harflerini de ve buna göre müşteirnin mevcut aldığı ürünleri ve çeşitli bilgileir görebilir.
Buradaki müşteri id'sine göre ödeme alabiliyoruz. Sağ üstteki button'a tıklayarak ödeme alanına gidebiliriz ve sonrasında bizi böyle bir sayfa karşılıyor:
Bu bölümde aylık taksit tutarının üstünde ödeme yapılmasını kapattım fakat aylık taksit tutarının altında ödeme yapılmasına olanak verdim ve burada yapılan eksik ödemeleri ödeme tablosunda yine listeledim.(Sonradan borcu kapat gibisinden bir fonksiyon eklenebilir isteğe göre)


![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/fc948c5f-40b8-498c-a111-b3865e539bab)

**Tahsilat Listesi Sayfası**

Bu sayfada Müşterilerimizin daha önceden yaptığı ödemeleri ve şuanda gerçekleşen ödeme/eksik ödeme bilgilerine textBox'a müşterinin adını veya id'sini yazarak erişebiliyoruz.


![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/c20b4bcf-4fb5-4cf5-a0d4-f688843b86bd)

Arama yaptığımız zaman ise eksik ödeme varsa buna göre alttaki tabloda gösteriliyor yoksa Boş olarak gözüküyor.


![image](https://github.com/barbo7/Taksitli-Urun-Satis-Uygulamasi/assets/114573591/b214471a-74d9-41f3-b093-7c169eabeef9)

--
Uygulamayı yaparken çok fazla Veri Tabanı işlemi yaptım ve güvenlik önlemi almak için view ve triggerlarla ilgilendim. 
aşağıda ise VeriTabanı'nın create table/view/trigger cümleleri bulunmakta Takibini Yapmak için Bir word dosyasında bulundurdum:

Create Table TBL_MUSTERI(musteri_id int IDENTITY(1,1) PRIMARY KEY, ad_soyad varchar(30) not null,tc nchar(11) not null,vergi_kimlik_no nchar(10) null,telno nchar(11) not null,adres varchar(100) null);
Create Table TBL_URUNLER (urun_id int IDENTITY(1,1) PRIMARY KEY, urun_ad varchar(60) not null, fiyat decimal(18, 2)not null);
Create Table TBL_TAKSITLER(taksit_id int IDENTITY(1,1) PRIMARY KEY,musteri_id int not null, urun_id int not null, toplam_fiyat decimal(18, 2)not null, kac_taksit int not null, odenen decimal(18, 2)not null, kalan decimal(18, 2)not null,musteri_not varchar(100) null);
Create Table TBL_KEFIL(kefil_id int IDENTITY(1,1) PRIMARY KEY, musteri_id int, kefil_ad_soyad varchar(60), telno nchar(11),tc nchar(11));

Create Table TBL_TAKSIT_TARIH(taksit_tarih_id int IDENTITY(1,1) PRIMARY KEY,taksit_id int,eklenme_tarihi Date,taksit_tutar decimal(18,2));

CREATE TABLE TBL_ODENEN_TAKSITLER(odenen_id int IDENTITY(1,1) Primary Key,taksit_id int,odenen_miktar decimal(18,2),eksik_miktar(18,2));

CREATE TABLE TBL_ODEME_TAMAMLANAN(tamamlanan_id int IDENTITY(1,1),taksit_id int,musteri_id int,urun_id int,fiyat decimal(18,2));

CREATE VIEW MUSTERI_TAKSIT_BILGILERI AS
SELECT        m.musteri_id AS [Müşteri Id], m.ad_soyad AS [Ad Soyad], SUM(t.toplam_fiyat) AS [Toplam Borç], SUM(t.odenen) AS [Toplam Ödenen], SUM(t.kalan) AS [Toplam Kalan],  t.musteri_not as 'Müşteri Notu',
MAX(t.kac_taksit) AS [Maksimum Taksit Miktarı]
FROM dbo.TBL_MUSTERI AS m INNER JOIN
dbo.TBL_TAKSITLER AS t ON m.musteri_id = t.musteri_id
GROUP BY m.musteri_id, m.ad_soyad, t.musteri_not


CREATE VIEW URUN_TAKSIT AS
SELECT t.taksit_id,u.urun_ad,t.musteri_id FROM TBL_TAKSITLER t 
INNER JOIN TBL_URUNLER u on t.urun_id=u.urun_id;

SELECT        m.ad_soyad AS [AD SOYAD], dbo.TBL_URUNLER.urun_ad AS [Ürün Adı], tt.eklenme_tarihi AS [Alış Tarihi], t.kalan AS[Kalan Tutar],tt.taksit_tutar AS [Aylık Taksit Tutarı], m.musteri_id
FROM            dbo.TBL_MUSTERI AS m INNER JOIN
                         dbo.TBL_TAKSITLER AS t ON t.musteri_id = m.musteri_id INNER JOIN
                         dbo.TBL_TAKSIT_TARIH AS tt ON tt.taksit_id = t.taksit_id INNER JOIN
                         dbo.TBL_URUNLER ON t.urun_id = dbo.TBL_URUNLER.urun_id;

CREATE VIEW [dbo].[MUSTERI_TAKSIT_BILGILERI2]
AS
SELECT        m.musteri_id AS [Müşteri Id], m.ad_soyad AS [Ad Soyad], SUM(t.toplam_fiyat) AS [Toplam Borç], MAX(t.odenen) AS [Toplam Ödenen]
FROM            dbo.TBL_MUSTERI AS m INNER JOIN
                         dbo.TBL_TAKSITLER AS t ON m.musteri_id = t.musteri_id
GROUP BY m.musteri_id, m.ad_soyad;

SELECT        dbo.TBL_ODENEN_TAKSITLER.odenen_miktar, dbo.TBL_ODENEN_TAKSITLER.tarih, dbo.TBL_TAKSITLER.musteri_id, dbo.TBL_URUNLER.urun_ad
FROM            dbo.TBL_ODENEN_TAKSITLER INNER JOIN
                         dbo.TBL_TAKSITLER ON dbo.TBL_ODENEN_TAKSITLER.taksit_id = dbo.TBL_TAKSITLER.taksit_id INNER JOIN
                         dbo.TBL_URUNLER ON dbo.TBL_TAKSITLER.urun_id = dbo.TBL_URUNLER.urun_id


CREATE TRIGGER [dbo].[tr_tarihekle] ON [dbo].[TBL_TAKSITLER]
AFTER INSERT
AS
BEGIN
    DECLARE @taksit_id INT;

    SELECT @taksit_id = taksit_id FROM inserted;

    INSERT INTO TBL_TAKSIT_TARIH (taksit_id, eklenme_tarihi)
    VALUES (@taksit_id, GETDATE());

	DECLARE @topf decimal(18,2),@odenen decimal(18,2),@kalan decimal(18,2);
select @topf = toplam_fiyat,@odenen=odenen FROM inserted;
 set @kalan =@topf-@odenen;
UPDATE TBL_TAKSITLER SET kalan=@kalan WHERE taksit_id=@taksit_id;
END;



CREATE TRIGGER [dbo].[TAMAMLANAN_ODEMELER] ON [dbo].[TBL_TAKSITLER] 
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @taksit_id int, @musteri_id int, @urun_id int, @fiyat decimal(18,2), @kalan_miktar decimal(18,2);

    SELECT @taksit_id = t.taksit_id, @musteri_id = t.musteri_id, @urun_id = t.urun_id, @fiyat = t.toplam_fiyat, @kalan_miktar = t.kalan
    FROM inserted t;

    IF @kalan_miktar < 1
    BEGIN
        IF NOT EXISTS (SELECT * FROM TBL_ODEME_TAMAMLANAN WHERE taksit_id = @taksit_id)
        BEGIN
            INSERT INTO TBL_ODEME_TAMAMLANAN (taksit_id, musteri_id, urun_id, fiyat) 
            VALUES (@taksit_id, @musteri_id, @urun_id, @fiyat);
        END
    END
END;


CREATE VIEW SATIS_TUTANAGI AS
SELECT        m.[ad_soyad], u.[urun_ad], ot.[odenen_miktar], ot.[tarih], m.musteri_id, ot.eksik_miktar 'Eksik Tutar'
FROM            [UrunTahsilat].[dbo].[TBL_ODENEN_TAKSITLER] ot INNER JOIN
                         TBL_ODEME_TAMAMLANAN odt ON ot.taksit_id = odt.taksit_id INNER JOIN
                         TBL_URUNLER u ON odt.urun_id = u.urun_id INNER JOIN
                         TBL_MUSTERI m ON m.musteri_id = odt.musteri_id
UNION
SELECT        m.[ad_soyad], u.[urun_ad], ot.[odenen_miktar], ot.[tarih], m.musteri_id, ot.eksik_miktar 'Eksik Tutar'
FROM            [UrunTahsilat].[dbo].[TBL_ODENEN_TAKSITLER] ot INNER JOIN
                         TBL_TAKSITLER t ON t .taksit_id = ot.taksit_id INNER JOIN
                         TBL_URUNLER u ON t .urun_id = u.urun_id INNER JOIN
                         TBL_MUSTERI m ON m.musteri_id = t .musteri_id


CREATE TRIGGER GECIKENTAKSITTUTAR ON TBL_ODENEN_TAKSITLER
AFTER INSERT AS
BEGIN
    DECLARE @EksikMiktar DECIMAL(18, 2), @ilkTarih DATE, @odenen DECIMAL(18, 2), @aylikTutar DECIMAL(18, 2), @Aylar INT, @Toplam DECIMAL(18, 2);
	declare @odenen_id int
    -- En son eklenen kaydın verilerini al
    SELECT @odenen_id= i.odenen_id,@odenen = t.odenen, @ilkTarih = tt.eklenme_tarihi, @aylikTutar = tt.taksit_tutar, @Toplam = t.toplam_fiyat
    FROM TBL_TAKSITLER t
    INNER JOIN TBL_TAKSIT_TARIH tt ON tt.taksit_id = t.taksit_id
	INNER JOIN inserted i on i.taksit_id=t.taksit_id

    SET @Aylar = CEILING(@odenen / @aylikTutar);

    IF @Aylar > 0 AND  @odenen < @aylikTutar
    BEGIN
        SET @ilkTarih = DATEADD(MONTH, @Aylar, @ilkTarih);
        SET @EksikMiktar = @aylikTutar - (@odenen % @aylikTutar);
    END
    ELSE
    BEGIN
        SET @EksikMiktar = NULL;
    END;
	declare @varmi int;

	SELECT @varmi=COUNT(*) FROM TBL_TAKSITLER WHERE musteri_id in(select musteri_id 
	FROM TBL_ODENEN_TAKSITLER ot INNER JOIN inserted i on ot.odenen_id=i.odenen_id)

    -- Güncellenen satırın eksik miktarını güncelle
	if @varmi >0
	begin

    UPDATE TBL_ODENEN_TAKSITLER
    SET eksik_miktar = @EksikMiktar
    WHERE odenen_id=@odenen_id;
	end
	
END;

CREATE TRIGGER [dbo].[KALANUPDATE] on [dbo].[TBL_TAKSITLER] AFTER UPDATE AS
DECLARE @topf decimal(18,2),@odenen decimal(18,2),@kalan decimal(18,2),@taksit_id int;
select @taksit_id=taksit_id,@topf = toplam_fiyat,@odenen=odenen FROM inserted;
 set @kalan =@topf-@odenen;
UPDATE TBL_TAKSITLER SET kalan=@kalan WHERE taksit_id=@taksit_id;

CREATE VIEW TARIH_BILGI AS
SELECT
    m.ad_soyad AS [AD SOYAD],
    dbo.TBL_URUNLER.urun_ad AS [Ürün Adı],
    tt.eklenme_tarihi AS [Alış Tarihi],
    t.kalan AS [Kalan Tutar],
    tt.taksit_tutar AS [Aylık Taksit Tutarı],
    m.musteri_id
FROM
    dbo.TBL_MUSTERI AS m
INNER JOIN
    dbo.TBL_TAKSITLER AS t ON t.musteri_id = m.musteri_id
INNER JOIN
    dbo.TBL_TAKSIT_TARIH AS tt ON tt.taksit_id = t.taksit_id
INNER JOIN
    dbo.TBL_URUNLER ON t.urun_id = dbo.TBL_URUNLER.urun_id
LEFT JOIN
    dbo.TBL_ODENEN_TAKSITLER AS ot ON ot.taksit_id = t.taksit_id
WHERE
    ot.taksit_id IS NULL or ot.taksit_id IS NOT NULL;




