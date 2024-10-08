namespace MARKET_C_Console;

public class Musteri
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public long TCNo { get; set; }
    public string Adresi { get; set; }
    public int KartSifresi { get; set; }

    public Musteri(string adi,string soyadi,long tcno,string adresi,int kartSifresi)
    {
        Adi = adi;
        Soyadi = soyadi;
        TCNo = tcno;
        Adresi = adresi;
        KartSifresi = kartSifresi;
    }
    

    
}
