using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Enter your first name: ");
        //string firstName = Console.ReadLine();
        //Console.WriteLine("Enter your last name: ");
        //string lastName = Console.ReadLine();
        //Console.WriteLine("\"Welcome {0} {1}\"", firstName, lastName);

        Console.WriteLine("Enter your file path- ");
        string path = @"D:\Before Phone Reset\Phn_DCMI(4-16-24)\DCIM\Camera\";
        Console.WriteLine(path.Length);

        int Number = 12;
        bool IsNumber10 = Number == 10 ? true : false;
        Console.WriteLine(IsNumber10);

        int? Age = null;
        if(Age >= 10)
        {
            Console.WriteLine("\n\nThe age is greater than or equal 10\n");
        }else if(Age < 10)
        {
            Console.WriteLine("\n\nThe age is less than 10\n");
        }
        else
        {
            Console.WriteLine("\n\nThe value is null\n");
        }

        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 5;
        Console.WriteLine("Available Tickets: {0}", AvailableTickets);
    }
}