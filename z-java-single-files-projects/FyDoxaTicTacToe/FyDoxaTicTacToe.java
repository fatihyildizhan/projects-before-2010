import java.util.Scanner;
public class FyDoxaTicTacToe 
{
	// Game Name is TicTacToe
	// You enter X or O if you can put 3 of each you win...
	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);

		// This is array which included matrix
		String[][] places={{" ","1","2","3"},{"1","-","-","-"},{"2","-","-","-"},{"3","-","-","-"}};
		int turN=0;
		String firstPlayer=null;
		String secondPlayer = null;
		String winner="";
		int row=0;
		int column=0;
		
		// if user enter '1' the game starts or not game will break
		try 
		{
			System.out.println("Welcome to TicTacToe 09'. \nPlease Enter '1' to start the Game!");
			int start=sc.nextInt();
			if(start==1)
			{
				System.out.print("First player Please Enter Your Name w/out space : ");
				firstPlayer=sc.next();
				System.out.println(firstPlayer+" you're Player is 'O'");
				System.out.print("\nSecond player Please Enter Your Name w/out space : ");
				secondPlayer=sc.next();
				System.out.println(secondPlayer+" you're Player is 'X'");
				System.out.println("\nGOOD LUCK!");
			}
			else
			{
				System.out.println("Bye Bye...");
				return;
			}
		}
		catch(Exception Ex) // user can be enter String value to integer , this is a just caution
		{
			System.out.println("Please enter '1' to start The Game ; Restart the Game!");
			return;
		}
		for(int i=0;i<9;)
		{
			// this boolean is to check is new coordinates exist ?
			boolean kontrol=true; 
			
			if(turN==0)
			{
				System.out.print("\n"+firstPlayer+" Puts 'O'\nEnter a row: ");
				row = sc.nextInt();

				System.out.print("Enter a column: ");
				column = sc.nextInt();
			}
			else
			{
				System.out.print("\n"+secondPlayer+" Puts 'X'\nEnter a row: ");
				row = sc.nextInt();

				System.out.print("Enter a column: ");
				column = sc.nextInt();
			}
			
			if(row>=places.length||column>=places.length) // if user enter integer outOfIndex this block starts
			{
				System.out.println("Out of index...");
			}
			else
			{
				if(places[row][column]!="-")
				{
					kontrol=false;
				}
				if(kontrol)
				{
					if(turN==0) // one time program puts 'O' then puts 'X'
					{
						places[row][column]="O";
						turN++;
					}
					else
					{
						places[row][column]="X";
						turN--;
					}
					i++;
				}
				else
				{
					System.out.println("This coordinate is exists\n");
				}
				for(int a=0;a<places.length;a++)
				{
					for(int b=0;b<places[a].length;b++)
					{	
						System.out.print(places[a][b]+" ");
					}
					System.out.println();
				}
			}
			boolean theWinner=false; // this is a boolean to check is there any winner ?
			
			// These conditions to check is there any 3 of same char ?
			if(places[1][1].equals(places[1][2])&&places[1][1].equals(places[1][3])&&places[1][1]!="-")
			{
				theWinner=true;
				winner=places[1][1];
			}
			else if(places[2][1].equals(places[2][2])&&places[2][2].equals(places[2][3])&&places[2][1]!="-")
			{
				theWinner=true;
				winner=places[2][1];
			}
			else if(places[3][1].equals(places[3][2])&&places[3][2].equals(places[3][3])&&places[3][1]!="-")
			{
				theWinner=true;
				winner=places[3][1];
			}
			else if(places[1][1].equals(places[2][2])&&places[2][2].equals(places[3][3])&&places[1][1]!="-")
			{
				theWinner=true;
				winner=places[1][1];
			}
			else if(places[1][3].equals(places[2][2])&&places[2][2].equals(places[3][1])&&places[3][1]!="-")
			{
				theWinner=true;
				winner=places[3][1];
			}
			else if(places[1][1].equals(places[2][1])&&places[2][1].equals(places[3][1])&&places[3][1]!="-")
			{
				theWinner=true;
				winner=places[3][1];
			}
			else if(places[1][2].equals(places[2][2])&&places[2][2].equals(places[3][2])&&places[3][2]!="-")
			{
				theWinner=true;
				winner=places[3][2];
			}
			else if(places[1][3].equals(places[2][3])&&places[2][3].equals(places[3][3])&&places[3][3]!="-")
			{
				theWinner=true;
				winner=places[3][3];
			}
			
			// if there is a winner we have to congratulations ...
			if(theWinner)
			{
				if(winner.equals("O"))
				{
					System.out.println("congratulations "+firstPlayer+" You WON!...");
				}
				else
				{
					System.out.println("Congratulations '"+secondPlayer+"' You WON!...");
				}
				break;
			}
			else
			{
				System.out.println("The is no any Winner There is Friendly...");
			}
		}
	}
	//Fatih Yýldýzhan
	//fatih@yildizhanlar.com
	//www.fatihyildizhan.com
}
