namespace MARKET_C_Console;

public class sepet
{
    private UrunYonetimi urunyonetimi = new UrunYonetimi();

    private List<sepet> sepetim;

    public void SepeteEkle(string UrunAdi,int UrunStoku)
    {
        Console.WriteLine("ürün sepetinize başarıyla eklenmiştir.");
        Console.WriteLine("eklenen ürün adı"+UrunAdi);
        Console.WriteLine("eklenen urunde bulunan stok sayısı:"+UrunStoku);
    }
}