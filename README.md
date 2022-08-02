# BattleShip
----------------------------------------------------- Amiral Battı Nedir? -----------------------------------------------------

   Amiral battı genel olarak 2 kişinin strateji çerçevesi içerisinde kendi oyun alanlarına karşıdaki oyuncudan gizli yerleştirdikleri yatay ve dikey olmak üzere 1x1, 2x1, 3x1, 4x1, 5x1 şeklinde gemiler ile oynanan bir oyundur. Bu versiyonun farkı ise, bütün gemiler 1x1 boyutunda olmak üzere alan boyutuna göre değişen gemi miktarlarına bağlı olarak yerleştirilecek en son gemi "Filo Komutanı" olarak düşünülerek vurulduğu taktirde düşmanın kaç gemisi kaldığı umursamaksızın vuran oyuncu oyunu kazanır.

--------------------------------------------------------  Nasıl Oynanır?  --------------------------------------------------------

1- Ana Menü üzerinde hangi tür oynamak istediğinize bağlı olarak Tek Oyunculu ve Çok Oyunculu butonlar bulunmaktadır.

a- Tek Oyunculu Oyun

    a1- Tek Oyunculu oyun oynanmak isteniyorsa, alan boyutlarından bir tanesi seçilmek zorundadır.
    
        a1.1- Alan boyutu seçim işlemi yapıldıktan sonra Tek Oyunculu butonuna basılmalıdır.
      
    a2- Oyun başladıktan sonra ilk olarak oyun alanı içerisinde(3x3 oyun alanı için 2 gemi - 6x6 oyun alanı 
    için 8 gemi - 10x10 oyun alanı için 24 gemi) gemiler yerleştirilmelidir. (Her yerleştirme işlemi 
    gerçekleştiğinde düşman oyuncu yani bilgisayar'ın gemileri için random sayı ile gemi yerleştirme işlemi 
    yapılmakta.)
    
        a2.1- Yerleştireceğiniz son geminiz filo komutanınız olacaktır o yüzden dikkat ediniz.
        
    a3- Gemiler yerleştirildikten sonra görünürlüğü açılacak yazı-tura atılmak zorundadır.
    
    a4- Yazı - tura sonucunda başlanacak taraf ilk vuruş hakkına sahip olacaktır bu açıdan avantajlıdır. 
    Oyun alanı içerisinde rakibinizin koyacağı yerleri tahmin ederek ona göre vuruş 
    hakkınızı kullanmalısınız. Azıcıkta şansınız yaver gitmeli :)
    
b- İki Oyunculu Oyun

   İki oyunculu oyunda farklı olarak alan boyut seçimi bulunmamaktadır. 5x5 alan içerisinde 10 gemi ile oynanmaktadır.

    b1- İki oyunculu oyun butonuna tıklandıktan sonra açılacak form içerisinde aynı ağa bağlı iki 
    bilgisayardan birisinin "Oyun Oluştur/Host the Game" butonu ile bir sunucu oluşturması gerekmektedir.
    Diğer oyuncu ise oyunu oluşturan bilgisayarın ip'sini yazarak oyuna katıl demelidir.
    (TCP ile bilgi alış-verişi sağlanmaktadır.)
    
    b2- Bağlantıların başarılı olma durumunda açılacak form ekranında Oyuncu 1 yani oyun sunucusunu kuran 
    kişi zar atmalıdır. Bu zar sonucuna göre ilk yerleştirme ve vurma hakkı kazanan oyuncuya verilecektir.
    
    b3- Zar sonucunda kazanan oyuncu ilk olmak üzere kendi oyun alanlarına gemileri yerleştirme işlemleri
    sıra ile yapılmaktadır.
    
    b4- Yerleştirme işlemleri bittikten sonra ise zar sonucunu kazanan oyuncu rakibinin alanında öncelik 
    olarak filo komutanını nereye koyduğunu tahmin ederek vurmalıdır. Bu şekilde ilk filo komutanını
    vuran ya da rakibinin bütün gemilerini vuran oyuncu oyunu kazanmaktadır.
