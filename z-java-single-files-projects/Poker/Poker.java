import java.util.Scanner;
import java.util.Random;
public class Poker
{
	static Scanner input = new Scanner(System.in);
	static Random rndm = new Random();
	//Programýn Amacý tek kullanýcý için poker oyunu gibi 5 farklý kart daðýtmaktýr
    //methodlarda ufak deðiþiklikler sayesinde birden fazla oyuncu için uygun hale getirilebilir...
    
    //Main
    // oyuncuKartlar Methoduna , kartlariDagit ve SayiUret methodlarýndan gelen deðerler verilip
    // oyuncudakiKartlar string dizisine atýlýp ekrana for döngüsüyle yazýlmýþtýr.
public static void main(String[] args) 
	{
		System.out.print("Oyuncu sayýsý giriniz:	");
		int oyuncuSayisi = input.nextInt(); 
		if(oyuncuSayisi>10||oyuncuSayisi<1)
		{
			System.out.println("\nPoker ancak 1 ile 10 kiþi arasýnda oynanabilir");
		}
		else
		{
			String[] oyuncudakiKartlar = oyuncuKartlar(kartlariDagit(),sayiUret(oyuncuSayisi),oyuncuSayisi);
			int counter=1;
			for(int i = 0; i<5*oyuncuSayisi;i++)
			{
				if(i%5==0)
				{
					System.out.println("\n"+counter+". Oyuncu");
					counter++;
				}	
				System.out.print(oyuncudakiKartlar[i]+" ");
			}
		}
	}
//kartlariDagit Methodu
// karTur ve kartNo dizilerini kullanarak 52 lik bir deste oluþturup bunu kartlar String dizisine atar
// geriye kartlar String dizisini döndürür
public static String[] kartlariDagit()		//KartlarýDaðýt Method
	{
	
	String[] kartTur = new String[] { "Maça", "Karo", "Sinek", "Kupa" };
    String[] kartNo = new String[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kýz", "Papaz" };
    String[] kartlar = new String[52];
	
	for (int i = 0; i < kartTur.length; i++)
    {
        for (int x = 0; x < kartNo.length; x++)
        {
            kartlar[i * 13 + x] = kartTur[i] + "-" + kartNo[x];
        }    
    }
	  return kartlar;
	}
//SayiUret Methodu
// Birbirinden farklý 52 ye kadar 5 farklý sayý uretir.
// geriye int dizi þeklinde ürettiði sayýlarý döndürür
public static int[] sayiUret(int Sayi)		//SayiUret Method
{
	int[] uretilenler = new int[5*Sayi];
	
	for(int i=0; i<uretilenler.length;)
	{
		boolean kontrol = true;
		int uretilen = rndm.nextInt(52);
		for(int j=0; j<uretilenler.length; j++)
		{
			if(uretilen == uretilenler[j])
			{
				kontrol = false;
				break;
			}
		}
		if(kontrol == true)
		{
			uretilenler[i] = uretilen;
			i++;
		}
	}
	return uretilenler;
}
//oyuncuKartlar Methodu
// uretilen 52 lik kaðýt destesi ile üretilen 5 farklý sayýyý birleþtirir
// çalýþma mantýðý þudur... 5 farklý sayýyý 52lik destenin içinden seçip oyuncuKartlar String dizisine atar
// elimizde Maça - 5 , Karo - Kýz gibi 5 farklý kombinasyon bulunur...
public static String[] oyuncuKartlar(String[] dizi,int[] sayilar,int sayi)	//oyuncuKartlar Method
	{
		String[] oyuncuKartlar = new String[sayilar.length];
		for(int i = 0; i<sayi*5; i++)
		{
			oyuncuKartlar[i] = dizi[sayilar[i]];	
		}
		return oyuncuKartlar;
	}
//Fatih Yýldýzhan
//fatih@yildizhanlar.com
//www.fatihyildizhan.com
}
