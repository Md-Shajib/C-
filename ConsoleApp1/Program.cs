using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter Your Name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("\n Hello " + userName + " What about you?");
        Console.WriteLine("\n\n Select your choice: ");
        Console.WriteLine("  1.Very Fine \n  2. Fine \n  3. Not bad \n  4. Bad");
        
        string status = Console.ReadLine();

        if(status == "1")
        {
            Console.WriteLine("I am Very Fine");
        } else if(status == "2")
        {
            Console.WriteLine("I am Fine");
        }else if(status == "3")
        {
            Console.WriteLine("I am Not bad");
        }
        else
        {
            Console.WriteLine("I am Bad");
        }

        Console.WriteLine("Hello I am {0}. I am {1}", userName, status);
        
    }
}
