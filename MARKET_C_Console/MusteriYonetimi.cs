namespace MARKET_C_Console;

public class MusteriYonetimi
{
     List<Musteri> musteriListesi;

     public MusteriYonetimi()
     {
          musteriListesi = new List<Musteri>();
     }

     public List<Musteri> MusteriEkle()
     {
         musteriListesi.Add(new Musteri("aise","demiral",10151329776,"darıca/kocaeli",12345));
         musteriListesi.Add(new Musteri("silanisa","gündoğdu",28390487162,"pendik/istanbul",2345));
         musteriListesi.Add(new Musteri("yunus emre","yıldırım",29384716374,"Gaziantep",87654));
         musteriListesi.Add(new Musteri("halime nisa","aygün",19283746372,"pendik/istanbul",3456));
         musteriListesi.Add(new Musteri("mehmet","yıldız",98765432145,"pendik/istanbul",345667));
         return musteriListesi;
     }

}