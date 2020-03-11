import java.util.Scanner;
import java.util.Random;
public class sayisaLoto 
{
	// programýn amacý : istediðiniz limite kadar istediðiniz adet sayýyý ister manuel ister otomatik olarak üretmek.
	// Programda Ýkramiye tutarýný belirleyebilirsiniz...
	public static void main(String[] args) 
	{
		AnaKontrol();
	}
	//AnaKontrol fonksiyonu içerisinde kaç sayý üretileceði , limit ve manuel mi otomatik mi üretmek istediðimizi belirliyoruz.
	public static void AnaKontrol()
	{
		Scanner sc=new Scanner(System.in);
		Random r = new Random();
		System.out.println("Kaç sayý üretelim ?");
		int kacSayi	= sc.nextInt(); 
		if(kacSayi>500)
		{
			System.out.println("herþeyin bir sýnýrý var !\n \t...");
		}
		else
		{
		System.out.println("Limit kaç olsun ?"); // üretilecek maksimum deðeri kullanýcý belirler.
		int limit = sc.nextInt();
		System.out.println("Büyük Ýkramiye Tutarýný Giriniz!\tint/long þeklinde");
		Long ikramiye = sc.nextLong();
		int[] userTahmin = new int[kacSayi]; // kullanýcýnýn tahminlerinin tutulduðu int dizisi
		System.out.println("Sayý tahmin etmek için 1 hariç bir sayý giriniz... \n Otomatik tahmin için 1 giriniz...");
		int tahminTip=sc.nextInt(); // manuel mi otomatik mi sayý üretmek istiyoruz?
		if(tahminTip==1)// kullanýcý sayý üretmeyi programa býrakýrsa if kendisi tahmin etmek isterse else koþulu çalýþýr.
		{
			char[] cumle = new char[]{'s','a','y','ý','l','a','r',' ','ü','r','e','t','i','l','i','y','o','r','.','.','.','\n'}; // bi mesaj sadece :))
			for(int i=0;i<cumle.length;i++)
			{
			System.out.print(cumle[i]+" ");
			}
			for(int i=0;i<kacSayi;)
			{
			boolean kontrol=true;
			int uretilen = r.nextInt(limit)+1;
				for(int j=0;j<kacSayi;j++)
				{
					if(uretilen==userTahmin[j])
					{	
					kontrol=false;
					break;
					}
				}
				if(kontrol==true)
				{
					userTahmin[i]=uretilen;
					i++;
				}
			}			
		}
		else
		{
			for(int i=0;i<kacSayi;i++) // eðer manuel tahmin seçilirse kullanýcýya tahminlerini sorduðumuz döngü
			{
				System.out.println((i+1)+". tahmininiz nedir ?");
				int userSayi = sc.nextInt();
				userTahmin[i]=userSayi;
			}
		}
		int[] randTahmin= SayiUret(kacSayi,limit); // sayýüret fonksiyonu çaðrýlmasý...
		System.out.print("\nSizin Tahminleriniz: "); // ekrana kullanýcýnýn girdiði sayýlarý yazdýrmak
		for(int i=0;i<kacSayi;i++)
		{
			System.out.print(userTahmin[i]+" ");	
		}
		System.out.print("\nRastgele  Tahminler: "); // ekrana random sayýlarý yazdýrmak
		for(int i=0;i<kacSayi;i++)
		{
			System.out.print(randTahmin[i]+" ");	
		}
		int[] dogruTahminler = Control(userTahmin,randTahmin); //control methodundan dönen deðerlerin int diziye atýlýp ekrana yazýlmasý
		System.out.print("\nDoðru     Tahminler: ");
		if(dogruTahminler.length==0) //eðer doðru tahmin yok ise if eðer var ise else koþulu çalýþýr...
		{
			System.out.print("YOK");
		}
		else
		{
			for(int i=0;i<dogruTahminler.length;i++)
			{
				System.out.print(dogruTahminler[i]+" ");
			}	
		}
		System.out.println("\nBüyük Ýkramiye Tutarý = "+ikramiye+" YTL"); // çekiliþ sonunda ikramiyeyi ekrana yazdýrma
		if(dogruTahminler.length==kacSayi) // eðer tüm tahminler doðru ise
		{
			System.out.println("\nTEBRÝKLER BÜYÜK ÝKRAMÝYE KAZANDINIZ !!!");
			System.out.println("\nTam Tamýna "+ikramiye+" YTL");
		}
		else if(dogruTahminler.length==0) // doðru tahmin yokse ikramiyede yok :))
		{
			System.out.println("\nBir tane bile bilemediniz Ýkramiye Falan YOK :))");
		}
		else if(dogruTahminler.length==1||dogruTahminler.length==2||dogruTahminler.length==3) // 1-2 ve 3 bilme durumundada ikramiye yok :))
		{
			System.out.println("\nSadece '"+dogruTahminler.length+"' tane bildiniz..Bu kadarýný herkes bilir :))");
		}
		else // diðer koþullar dýþýnda bilme oraný kadar ikramiye kazanýr...
		{
			System.out.println("\n"+dogruTahminler.length+" tahmininiz tuttu!");
			System.out.println("\n"+((ikramiye/kacSayi)*dogruTahminler.length)+" YTL Kazandýnýz!");
		}
	}
	}
	// Sayýüret fonksiyonu ile birbirinden farklý istediðimiz adet de sayý üretip geriye int dizisi olarak döndürme
	public static int[] SayiUret(int kacSayi,int limit)
	{
		Random r = new Random();
		int[] uretilenler = new int[kacSayi];
		for(int i=0;i<kacSayi;)
		{
		boolean kontrol=true;
		int uretilen = r.nextInt(limit)+1;
			for(int j=0;j<kacSayi;j++)
			{
				if(uretilen==uretilenler[j])
				{	
				kontrol=false;
				break;
				}
			}
			if(kontrol==true)
			{
				uretilenler[i]=uretilen;
				i++;
			}
		}
		return uretilenler;
	}
	// Control fonksiyonu sayesinde kaç tahminin tuttuðunu doðru tahminlerin geriye string olarak döndürülmesini saðlýyoruz.
	public static int[] Control(int[] myLoto,int[] randLoto)
	{
		// bu döngüde kaç tahminin tuttuðu bulunur... count deðerine atanýr...
		int count=0;
		for(int i=0;i<myLoto.length;i++)
		{
			for(int j=0;j<randLoto.length;j++)
			{
				if(myLoto[i]==randLoto[j])
				{
					count++;
				}
			}
		}
		//doðru tahmin sayýsý kapasiteli dizi oluþturulup bilinen deðerler geri döndürülür...
		int sayac=0;
		int[] sonuc=new int[count];
		for(int i=0;i<myLoto.length;i++)
		{
			for(int j=0;j<randLoto.length;j++)
			{
				if(myLoto[i]==randLoto[j])
				{
					sonuc[sayac]=myLoto[i];
					sayac++;
				}
			}
		}
		return sonuc;
	}
	//Fatih Yýldýzhan
	//fatih@yildizhanlar.com
	//www.fatihyildizhan.com
}
