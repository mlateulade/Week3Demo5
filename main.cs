using System;

class MainClass {
  public static void Main (string[] args) {
    
    int remainder;
    int odd=0;
    int even=0;

    Console.WriteLine("Enter number 1");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter number 2");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int num=num1;num<=num2;num++)
    {    
      remainder = num % 2;
      if (remainder == 0)
      {
        Console.WriteLine("The number " + num + " is even");
        even++; 
      }
      else
        {
        Console.WriteLine("The number " + num + " is odd");
        odd++;
        }
    }

    Console.WriteLine("Total odd number count = "+odd);
    Console.WriteLine("Total odd number count = "+even);


  }
}