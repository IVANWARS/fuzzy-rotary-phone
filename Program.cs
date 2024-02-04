 
// Вторая задача

int x =  5;
int y = - 4;

{
    if( x > 0 && y > 0)

    {
        Console.WriteLine("первая четверть");

    }

    if( x < 0 && y > 0)

    {
        Console.WriteLine(" вторая четверть");

    }

   if( x < 0 && y < 0)

   {
       Console.WriteLine(" третья четверть");

   }

   if( x > 0 && y < 0)

   {
       Console.WriteLine(" четвёртая четверть");

   }

}
  

  // Третья задача

 int n = 85;
 int firstDigit = n /10;
 int secondDigit = n % 10;
  
if (firstDigit > secondDigit)
{
   Console.WriteLine(firstDigit);
}
 else

 Console.WriteLine(secondDigit);
