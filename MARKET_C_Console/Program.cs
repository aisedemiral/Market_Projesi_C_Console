using MARKET_C_Console;

while (true)
{
    Console.WriteLine("***************************************");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*       -MARKETİMİZE HOŞGELDİNİZ-     *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*          1-Müşteri Ekle             *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*          2-Müşterileri Listele      *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*          3-Ürün Ekle                *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*          4-Ürün Listele             *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("*          5-Sipariş Ver              *");
    Console.WriteLine("*                                     *");
    Console.WriteLine("***************************************");

    Console.WriteLine(" ");
    UrunYonetimi urunyonet = new UrunYonetimi();
    Console.WriteLine("giriş yapabilmek için lütfen tc kimlik numaranızı giriniz.");
    long tc = long.Parse(Console.ReadLine());
    bool musteriVarMi = false;
    MusteriYonetimi yonetim = new MusteriYonetimi();
    List<Musteri> musteriList = yonetim.MusteriEkle();
    Musteri secilenMusteri = null;
    string cevap;
    foreach (var musteri in musteriList)
    {
        if (musteri.TCNo == tc)
        {
            musteriVarMi = true;
            secilenMusteri = musteri;
            break;
        }
        else
        {
            musteriVarMi = false;
        }

    }

    if (musteriVarMi == true)
    {
        Console.WriteLine("sisteminize başarılı giriş yaptınız.\n ürün listemiz aşşağıdaki gibidir");
        Console.WriteLine(" ");
        Console.WriteLine("**********************************************");
        Console.WriteLine("*                                            *");
        Console.WriteLine("*  ürün_adi ürün_fiyati ürün_kodu ürün_stoğu *");
        Console.WriteLine("*                                            *");
        var urunListesi = urunyonet.UrunEkle();
        foreach (var urun in urunListesi)
        {
            Console.WriteLine("*  "+urun.UrunAdi+"       "+urun.UrunFiyati+" TL       "+urun.UrunKodu+"    "+urun.UrunStok+" adet *");

        }
        
        
        Console.WriteLine("*                                            *");
        Console.WriteLine("**********************************************");

        int sepetTutari = 0;
        int malzeme = 0;
        int adet = 0;
        int yeniurun = 1;
        while (yeniurun == 1)
        {
            Console.WriteLine("ürün listemizde almak isteğiniz ürünün kodunu giriniz.");
            malzeme = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("seçtiğiniz üründen kaç adet girmek istediğinizi giriniz.");
            adet = Convert.ToInt32(Console.ReadLine());


            List<sepet> sepetim = new List<sepet>();
            sepet Sepet = new sepet();
            int ücret;
            switch (malzeme)
            {
                case 1:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 1).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi+ " dan " + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 30;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,adet);
                }
                    ;
                    break;
                case 2:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 2).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi, + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 7;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 3:
                {

                    var urun = urunListesi.Where(x => x.UrunKodu == 3).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 15;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 4:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 4).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 70;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 5:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 5).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 10;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 6:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 6).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 25;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 7:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 7).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 60;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 8:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 8).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 45;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 9:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 9).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 45;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;
                case 10:
                {
                    var urun = urunListesi.Where(x => x.UrunKodu == 10).LastOrDefault();
                    Console.WriteLine(urun.UrunAdi + adet + "adet alıyorsunuz.tutarınız:" + sepetTutari);
                    ücret = 250;
                    sepetTutari = ücret * adet;
                    Sepet.SepeteEkle(urun.UrunAdi,UrunStoku:adet);
                }
                    ;
                    break;


            }

            Console.WriteLine(" şu anlık sepetinizin toplam tutarı " + sepetTutari + "tl dir.");
            Console.WriteLine("alışverişe devam etmek istiyorsanız 1 alışverişi bitirmek istiyorsanız 0 basınız. ");
            int devam;
            devam = Convert.ToInt32(Console.ReadLine());
            if (devam == 0)
            {
                yeniurun = 0;
                Console.WriteLine("alışverişiniz bitti bizi tercih ettiğiniz için teşekkür ederiz.");
                Console.WriteLine("Sepetinizin toplam tutarı: " + sepetTutari +
                                  "tl dir.\n ödemenizi nasıl yapmak istersiniz \n 1-nakit\n2-kredi kartı\n3-banka kartı");
                int odeme;
                odeme = Convert.ToInt16(Console.ReadLine());
                switch (odeme)
                {
                    case 1:
                    {
                        Console.WriteLine("nakit ödemeniz alınmısştır");
                        
                    }
                        break;
                    case 2:
                    {
                        Console.WriteLine("lütfen kredi kartınızın şifresini giriniz");
                        int sifrem = Convert.ToInt32(Console.ReadLine());
                        if (sifrem == secilenMusteri.KartSifresi)
                        {
                            Console.WriteLine("şifrenizi doğru girdiniz ödeme başarılı.\n yaptığınız harcama gelecek ayın kart borcuna yansıyacaktır.");
                        }
                        else
                        {
                            Console.WriteLine("şifrenizi yanlış girdiniz .ödeme gerçekleşemedi.");
                        }
                    }
                        break;
                    case 3:
                    {
                        Console.WriteLine("lütfen banka kartınızın şifresini giriniz.");
                        int sifrem = Convert.ToInt32(Console.ReadLine());
                        if (sifrem == secilenMusteri.KartSifresi)
                        {
                            Console.WriteLine(
                                "kartınızın şifresi doğru girilmiştir.\n yaptığınız harcama bakiyenizden düşmüştür.");
                        }
                        else
                        {
                            Console.WriteLine("şifreniz yanlış.");
                        }
                    }
                        break;
                }
            }
            else if (devam == 1)

            {
                Console.WriteLine("alışverişiniz devam ediyor");
            }
        }

    }
    else
    {
        Console.WriteLine("devam edebilmek için kayıt olmanız gerekmektedir . kayıt olmak ister misiniz?");
        cevap = Console.ReadLine();
        if (cevap == "evet")
        {
            Console.WriteLine("lütfen adınızı giriniz:");
            string musteriAdi = Console.ReadLine();
            Console.WriteLine("lütfen soyadınızı giriniz:");
            string musteriSoyadi = Console.ReadLine();
            Console.WriteLine("lütfen TCNO nuzu giriniz");
            long musteriTCNo = long.Parse(Console.ReadLine());
            Console.WriteLine("lütfen adresinizi giriniz.");
            string musteriAdresi = Console.ReadLine();
            Console.WriteLine("lütfen kartınızın şifresini giriniz.");
            int musterikartSifresi = Convert.ToInt32(Console.ReadLine());
            Musteri musteri = new Musteri(musteriAdi, musteriSoyadi, musteriTCNo, musteriAdresi, musterikartSifresi);
            musteriList.Add(musteri);
            Console.WriteLine("adınız:{0} soyadınız:{1} TC numaranız:{2} adres:{3}", musteri.Adi, musteri.Soyadi,
                musteri.TCNo, musteri.Adresi);

        }
        else
        {
            Console.WriteLine("uygulamamızdan ayrılıyorsunuz.İYİ GÜNLER DİLERİZ...");
        }
    }
}

