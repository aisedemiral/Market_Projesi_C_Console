namespace MARKET_C_Console;

public class UrunYonetimi
{
    private List<Urun> urunListesi;

    public UrunYonetimi()
    {
        urunListesi = new List<Urun>();
        UrunEkle();
    }

    public List<Urun> UrunEkle()
    {
        urunListesi.Add(new Urun("kola",1,30,15));
        urunListesi.Add(new Urun("ekmek",2,7,7));
        urunListesi.Add(new Urun("ayran",3,15,21));
        urunListesi.Add(new Urun("peynir",4,70,6));
        urunListesi.Add(new Urun("çikolata",5,10,30));
        urunListesi.Add(new Urun("süt",6,25,9));
        urunListesi.Add(new Urun("zeytin",7,60,14));
        urunListesi.Add(new Urun("bulgur",8,45,24));
        urunListesi.Add(new Urun("nohut",9,45,35));
        urunListesi.Add(new Urun("tereyağı",10,250,12));
        return urunListesi;

    }

    public void UrunCıkart(string urunAdi, int kacAdetCikarilsin)
    {
        foreach (var urun in urunListesi)
        {
            if (urun.UrunAdi == urunAdi)
            {
                urun.UrunStok = urun.UrunStok - kacAdetCikarilsin;
            }
            
        }
        
    }
    
    
}