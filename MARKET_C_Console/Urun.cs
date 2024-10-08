namespace MARKET_C_Console;

public class Urun
{
    public string UrunAdi { get; set; }
    public int UrunKodu { get; set; }
    public int UrunFiyati { get; set; }
    public int UrunStok { get; set; }


    public Urun(string urunAdi, int urunKodu,int urunFiyati,int urunStok)
    {
        UrunAdi = urunAdi;
        UrunKodu = urunKodu;
        UrunFiyati = urunFiyati;
        UrunStok = urunStok;
    }
}

