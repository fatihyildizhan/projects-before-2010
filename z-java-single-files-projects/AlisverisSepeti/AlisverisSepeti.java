import java.util.Scanner;


public class AlisverisSepeti 
{
	public static void main(String[] args)
	{
		String[][] sepet = new String[10][4];
		int counter = 0;
		Scanner sc = new Scanner(System.in);
		
		while(counter < 10) //for(; counter < 10; counter++)
		{
			System.out.println("Seçiminizi giriniz. Çýkmak için 0'a basýnýz.");
			System.out.println("et\nsut\nyogurt\ndergi");
			String choice = sc.next();
			if(choice.equals("0"))
				break;
			int birim = BirimFiyatBul(choice);
			if(birim == 0) //yanlýþ seçim yapýldýysa
			{
				System.out.println("Yanlýþ ürün girdiniz.");
				continue;
			}
			System.out.println("Ne kadar olsun?");
			double miktar = sc.nextDouble();
			SepeteEkle(sepet, counter, choice, miktar, birim);
			counter++;
		}
		SepetiHesapla(sepet);
	}
	
	/*
	 * Kullanýcýnýn girdiði et, sut, yogurt, dergi
	 * String'ini eldeki array'le karþýlaþtýrarak birim fiyatýný return eder.
	 * Eðer kullanýcý elde olmayan bir ürün girdiyse 0 döndürür.
	 */
	public static int BirimFiyatBul(String c)
	{
		String[][] urunler = 
		{ {"et", "8"}, 
				{"sut", "5"}, 
				{"yogurt", "4"}, 
				{"dergi", "3"} };
		
		for(int i = 0; i < urunler.length; i++)
		{
			if(urunler[i][0].equals(c))
				return Integer.parseInt(urunler[i][1]);
		}
		return 0;		
	}

	/*
	 * Gelen sepetin gelen index'teki satýrýna gelen seçimi,
	 * gelen miktarý, birim fiyatýný ve ürünün toplam tutarýný 
	 * girer.
	 */
	public static void SepeteEkle(String[][] sepet, 
			int index, String secim, double miktar, int birimfiyat)
	{
		sepet[index][0] = secim; //ürünadý
		sepet[index][1] = miktar + ""; //ürün miktarý
		sepet[index][2] = birimfiyat + ""; //ürünün birim fiyatý
		sepet[index][3] = miktar * birimfiyat + ""; //ürünün toplam tutarý
	}
	
	/*
	 * Sepetteki ürünlerin toplamýný (3. sütunlarýn toplamý) ve
	 * alýnan ürünlerin dökümünü bastýrýr.
	 */
	public static void SepetiHesapla(String[][] sepet)
	{
		double toplam = 0;
		
		for(int i = 0; i < sepet.length; i++)
		{
			//eðer ürün eklenmemiþse döngüyü durdur.
			if(sepet[i][0] == null || sepet[i][0].equals(""))
				break;
			toplam += Double.parseDouble(sepet[i][3]);
			for(int j = 0; j < sepet[i].length; j++)
			{
				System.out.print(sepet[i][j] + "\t");
			}
			System.out.println();
		}
		System.out.println("Alýþveriþiniz toplam " + toplam + " TL tutmuþtur.");
	}
	
}
