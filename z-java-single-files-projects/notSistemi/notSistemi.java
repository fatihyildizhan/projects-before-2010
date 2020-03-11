import java.util.Scanner;
public class notSistemi 
{
	public static void main(String[] args)
	{
		Scanner sc=new Scanner (System.in);
		System.out.println("Kaç öðrenci var ?");
		int ogr=sc.nextInt();
		NotlariAl (ogr);
	}

	public static void NotlariAl(int ogrSayisi)
	{
		int fails=0;
		int sayac=0;
		String[] ogrKalan = new String[ogrSayisi];
		Scanner sc=new Scanner(System.in);
		for(int i=1;i<=ogrSayisi;i++)
		{
		System.out.println("\n"+i+".öðrencinin adý: ");
		String ogrAd=sc.next();
		System.out.println(i+".öðrencinin notu: ");
		double not=sc.nextDouble();
		char grade=NotKontrol(not);
		if(grade=='F')
		{
			fails++;
			ogrKalan[sayac]=ogrAd;
			sayac++;
		}
		System.out.println("Ogrenci Adý: "+ogrAd+"	Ogrenci Notu: "+grade);
		}
		printFails(fails);
		for(int i=0;i<fails;i++)
		{
			System.out.println((i+1)+".ogrenci: "+ogrKalan[i]);
		}
	}
	public static char NotKontrol(double n)
	{
		char g;
		if(n>=90) g='A';
		else if(n>=80) g='B';
		else if(n>=70) g='C';
		else if(n>=60) g='D';
		else g='F';
			return g;
	}
	public static void printFails(int count)
	{
	String s="\nKalan öðrenci sayýsý: "+count;
	System.out.println(s);
	}
	//Fatih Yýldýzhan
	//fatih@yildizhanlar.com
	//www.fatihyildizhan.com
}
