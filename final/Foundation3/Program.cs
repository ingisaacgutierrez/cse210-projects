using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("\n ***** Lecture Event *****");
      DateTime dateTimeOne = new DateTime(2023,12,23,22,0,0);
      Address addressOne = new Address("123 Main St","Interlachen", "FL", "USA");
      Lecture lecture = new Lecture("The book of Mormon","The book", dateTimeOne, addressOne, "Isaac Gutierrez", 25);
      Console.WriteLine("\n-- Standard Details: --");
      Console.WriteLine(lecture.StandardDetails());
      Console.WriteLine("\n-- Full Datails --");
      Console.WriteLine(lecture.FullDetails());
      Console.WriteLine("\n-- Short Description --");
      Console.WriteLine(lecture.ShortDescription());
      Console.WriteLine();

      Console.WriteLine("\n *****  Reception Event *****");
      DateTime dateTimeTwo = new DateTime(2024,04,15 ,15,30,0);
      Address addressTwo = new Address("3145 Vineyard Drive","Cleveland", "Ohio", "USA");
      Reception reception = new Reception("codeincsharp@gmail.com","Code Camp", "A camp where you learn to code in  c# language", dateTimeTwo,addressTwo);
      Console.WriteLine("\n-- Standard Details: --");
      Console.WriteLine(reception.StandardDetails());
      Console.WriteLine("\n-- Full Datails --");
      Console.WriteLine(reception.FullDetails());
      Console.WriteLine("\n-- Short Description --");
      Console.WriteLine(reception.ShortDescription());
      Console.WriteLine();

      Console.WriteLine("\n ***** Outdoor Gathering Event *****");
      DateTime dateTimeThree = new DateTime(2024,01,6,09,0,0);
      Address addressThree = new Address("123 Main St","Interlachen", "FL", "USA");
      OutdoorGathering outdoorGathering = new OutdoorGathering("Football Camp","Learn to play soccer with our trainers", dateTimeThree,addressThree,"Sunny");
      Console.WriteLine("\n-- Standard Details: --");
      Console.WriteLine(outdoorGathering.StandardDetails());
      Console.WriteLine("\n-- Full Datails --");
      Console.WriteLine(outdoorGathering.FullDetails());
      Console.WriteLine("\n-- Short Description --");
      Console.WriteLine(outdoorGathering.ShortDescription());
      Console.WriteLine();

    }
}