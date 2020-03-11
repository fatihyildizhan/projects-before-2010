public class Fatih_Yildizhan_717346_HW_Fibonacci
{
	public static void main(String[] args)
{
		//Declare 3 long numbers because, we have 3 variables.
		//First one is number 1 , second is number 2 and number 3 is total of them.
		//Declare an integer to be counter.
		
		long num1=1;
		long num2=0;
		long num3=0;
		int  numCount=1;

		while(numCount<10)	
		{
			if(numCount==1)
			{
				System.out.println("Numbers  of   Fibonacci");
				System.out.print(num1+" ");
			}
			else
			{}
			num3=num1+num2;
				System.out.print(num3+" ");
			num2=num1;
			num1=num3;
				numCount++;
		}		
	}
	//Ýlkim Dilara Kadakaloðlu
}
