import java.util.InputMismatchException;
import java.util.Random;
import java.util.Scanner;
public class FyDoxaAmiralBatti 
{
	// Oyun Adý : Amiral Battý
	// Oyun 10X10 Matristen oluþmaktadýr , 2 adet 2'li 1 adet 3'lü gemi bulunmaktadýr...
	// Oyun çýktý olarak toplam hamle sayýsý , Iska sayýsý, Ýsabet sayýsý ve her gemi battýðýnda gemiye ait bilgi vermektedir...
	// Ýyi Eðlenceler... ;)
	public static void main(String[] args) 
	{
		Random r = new Random();
		Scanner sc = new Scanner(System.in);
		
		// 10X10 luk matris'in tanýmlanmasý
		String[][] places = new String[10][10];
		
		// Geminin matris'te yerleþtirilmesinde kullanýlan deðerler..
		// Gemi 2 li ise krdnt Gemi 3 lü ise krdnt2 deki deðerler kullanýlýr..
		int[] krdnt={-1,1};
		int[] krdnt2={-2,2};
		
		// Eðer tüm gemiler düzgün bir þekilde yerleþtirilemediyse Ýþlem tekrarlanýr...
		// Batan Gemi sayýlarý kullanýcýya bilgi amaçla saklanýr...
		// Ýsabet Sayýsý,Iska Sayýsý ve Toplam Hamle Sayýsý saklanýr...
		int gemilerYerlestiMi=0;
		int batanGemiSayisi=0;
		int isabet=0;
		int iska=0;
		int hamle=0;
		
		// Birinci 2'li geminin kordinat ve Batma Durumunu tutan deðiþkenler ve boolean deðiþkeni 
		boolean gemiBatti1=false;
		int gemi1x1;
		int gemi1y1;
		int gemi1x2;
		int gemi1y2;
		
		// Ýkinci 2'li geminin kordinat ve Batma Durumunu tutan deðiþkenler ve boolean deðiþkeni
		boolean gemiBatti2=false;
		int gemi2x1;
		int gemi2y1;
		int gemi2x2;
		int gemi2y2;
		
		// Birinci 3'lü geminin kordinat ve Batma Durumunu tutan deðiþkenler ve boolean deðiþkeni
		boolean gemiBatti3=false;
		int gemi3x1;
		int gemi3y1;
		int gemi3x2;
		int gemi3y2;
		int gemi3x3 = 0;
		int gemi3y3 = 0;
		
		//Karþýlama Satýrý....
		System.out.println("Amiral Battý Oyununa Hoþgeldiniz...\n Ýyi Eðlenceler...\nBaþlamak için '1' giriniz.");
		int start=sc.nextInt();
		if(start==1)
		{}
		else
		{
			System.out.println("Yine Bekleriz...");
			return;
		}
		
		// While döngüsünde gemiler matris'e yerleþtirilirler sonsuz döngünün sebebi ise 
		// bazý hatalardan dolayý gemiler yerleþtirilemediyse iþlemin tekrarlanmasý
		while(1==1)
		{
			// Matris'in elemanlarý "." ile doldurulur...
			// While'ýn içinde olma sebebi ise herhangi bir gemi yerleþtirilmediyse iþlem tekrarlandýðýnda yerleþen gemileri silmek...
			for(int i=0;i<places.length;i++)
			{
				for(int j=0;j<places[i].length;j++)
				{
					places[i][j]=".";
				}
			}
			
			// Birinci 2'li geminin rastgele matris'e yerleþtirilmesi
			gemi1x1=r.nextInt(places.length-1);
			gemi1y1=r.nextInt(places.length-1);
			
			int which = r.nextInt(2);  // bu satýrda geminin satýrdamý kolondamý yer alacaðý belirlenir...
			int durum = r.nextInt(2); // geminin satýrda ise saðamý solamý kolonda ise aþaðamý yukarýmý olacaðý belirlenir..
			
			gemi1x2=gemi1x1;
			gemi1y2=gemi1y1;
			
			if(which==1)
			{
				gemi1x2=gemi1x1+krdnt[durum];
			}
			else
			{
				gemi1y2=gemi1y1+krdnt[durum];
			}
			
			if(gemi1x2<=places.length-1&&gemi1y2<=places.length-1) // Eðer geminin tamamý matrisler içerisindeyse gemi yerleþtirilir...
			{
				places[gemi1x1][gemi1y1]="@";
				places[gemi1x2][gemi1y2]="@";
				gemilerYerlestiMi++;
			}
			
			// Ýkinci 2'li geminin rastgele matris'e yerleþtirilmesi
			gemi2x1=r.nextInt(places.length-1);
			gemi2y1=r.nextInt(places.length-1);
			
			which = r.nextInt(2);
			durum = r.nextInt(2);
			
			gemi2x2=gemi2x1;
			gemi2y2=gemi2y1;
			
			if(which==1)
			{
				gemi2x2=gemi2x1+krdnt[durum];
			}
			else
			{
				gemi2y2=gemi2y1+krdnt[durum];
			}
			if(gemi2x2<=places.length-1&&gemi2y2<=places.length-1&&places[gemi2x1][gemi2y1]=="."&&places[gemi2x2][gemi2y2]==".")
			{
				places[gemi2x1][gemi2y1]="@";
				places[gemi2x2][gemi2y2]="@";
				gemilerYerlestiMi++;
			}
			// Birinci 3'lü geminin rastgele matris'e yerleþtirilmesi 
			gemi3x1=r.nextInt(places.length-1);
			gemi3y1=r.nextInt(places.length-1);
			
			which = r.nextInt(2);
			durum = r.nextInt(2);
			
			gemi3x2=gemi3x1;
			gemi3y2=gemi3y1;
			
			gemi3x3=gemi3x1;
			gemi3y3=gemi3y1;
			
			if(which==1)
			{
				gemi3x3=gemi3x1+krdnt[durum];
				gemi3x2=gemi3x1+krdnt2[durum];
			}
			else
			{
				gemi3y3=gemi3y1+krdnt[durum];
				gemi3y2=gemi3y1+krdnt2[durum];
			}
			
			if(gemi3x2<=places.length-1&&gemi3y2<=places.length-1&&places[gemi3x1][gemi3y1]=="."&&places[gemi3x2][gemi3y2]=="."&&places[gemi3x3][gemi3y3]==".")
			{
				places[gemi3x1][gemi3y1]="@";
				places[gemi3x2][gemi3y2]="@";
				places[gemi3x3][gemi3y3]="@";
				gemilerYerlestiMi++;
			}
			
			// Eðer tüm gemiler baþarýyla yerleþtilerse oyun baþlar...
			if(gemilerYerlestiMi>=3)
			{
				break;
			}
			else // aksi halde iþlem tekrarlanýr...
			{
				gemilerYerlestiMi=0;
			}
		}
		
		// Sýra kullanýcýda ... Satýr ve Sütün sayýlarýný girerek gemilerin yerlerini tahmin etmeye çalýþýr...
		for(int i=0;i<places.length*places.length;i++)
		{
			try // Sayý haricinde bir deðer girdiði takdirde program catch bloðuna düþecektir...
			{
				System.out.print("Satýr Numarasý Giriniz: ");
				int row=sc.nextInt()-1;
				System.out.print("Sütun Numarasý Giriniz: ");
				int column=sc.nextInt()-1;
				
				// Eðer matris boyutunun dýþýnda deðer girerse uyarý alýp Tekrar yeni deðerler istenecektir...
				if(row<=places.length-1&&column<=places.length-1) 
				{
					hamle++;
					if(places[row][column]!=".") // Eðer kullanýcý herhangi bir gemiye isabet ettirirse
					{
						System.out.println("\nahanda kafasý yarýldý ;)\n");
						places[row][column]="#";
					}
					else // Tabi bide ýskalama þansý var :)))
					{
						System.out.println("\nIskaa...:P\n");
						places[row][column]="x";
						iska++;
					}
					
					// Eðer kullanýcý herhangi bir gemiye isabet ettirirse koordinattaki "." deðer "#" ile deðiþtirilir...
					for(int m=0;m<places.length;m++)
					{
						for(int j=0;j<places[m].length;j++)
						{
							System.out.print(places[m][j]+" ");
							if(places[m][j]=="#")
							{
								isabet++;
							}
						}
						System.out.println();
					}
					
					// Eðer tüm gemiler batýrýlmýþ ise Oyun Biter ve ekranda tüm bilgiler listelenir...
					if(isabet>=7)
					{
						System.out.print("\nTebrikler bütün gemileri vurdunuz...");
						System.out.print("\nToplam Atýþ Sayýnýz: "+hamle);
						System.out.print("\nToplam Iska Sayýnýz: "+iska);
						System.out.print("\nToplam Ýsabet Sayýnýz: "+isabet);
						break;
					}
					
					// Eðer birinci 2'li gemi batýrýlýrsa...
					else if(places[gemi1x1][gemi1y1]=="#"&&places[gemi1x2][gemi1y2]=="#"&&gemiBatti1==false)
					{
						batanGemiSayisi++;
						System.out.println("\nTebrikler..Þuana kadar '"+batanGemiSayisi+"' tane Gemiyi Batýrdýnýz...");	
						gemiBatti1=true;
					}
					
					// Eðer ikinci 2'li gemi batýrýlýrsa...
					else if(places[gemi2x1][gemi2y1]=="#"&&places[gemi2x2][gemi2y2]=="#"&&gemiBatti2==false)
					{
						batanGemiSayisi++;
						System.out.println("\nTebrikler..Þuana kadar '"+batanGemiSayisi+"' tane Gemiyi Batýrdýnýz...");
						gemiBatti2=true;
					}
					
					// Eðer birinci 3'lü gemi batýrýlýrsa...
					else if(places[gemi3x1][gemi3y1]=="#"&&places[gemi3x2][gemi3y2]=="#"&&places[gemi3x3][gemi3y3]=="#"&&gemiBatti3==false)
					{
						batanGemiSayisi++;
						System.out.println("\nTebrikler..Þuana kadar '"+batanGemiSayisi+"' tane Gemiyi Batýrdýnýz...");
						gemiBatti3=true;
					}
					else
					{}	
					isabet=0;
				}
				else // Kullanýcý geçersiz koordinat girdiðinde gösterilecek hata mesajý...
				{
					System.out.println("Lütfen Geçerli Koordinat Giriniz...");
				}
			}
			catch(InputMismatchException Ex) // Sayý haricinde girilecek bir deðer için gösterilecek hata mesajý...
			{
				System.out.println("Lütfen koordinatlarý sayý olarak giriniz..");
			}
		}
	}
	//Fatih Yýldýzhan
	//fatih@yildizhanlar.com
	//www.fatihyildizhan.com
}
