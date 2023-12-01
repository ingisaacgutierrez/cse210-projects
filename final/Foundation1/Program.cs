using System;

class Program
{
    static void Main(string[] args)
    {
      List<Video> videos = new List<Video>();
      
      
      //------------------------------------VIDEO #1-----------------------------------------------------
       Video V1 = new Video();
       V1._title = "I Visited All 50 States in 5 Days";
       V1._author = "PeterMC";
       V1._length = "38:23";
       
       Comment c1 = new Comment();
       c1._commenterName = "@zackplaying";
       c1._text = "The flight announcement at the end of the video literally made me choke back a tear for you all. Great video, boys. Congratulations. Cheers";

       Comment c2 = new Comment();
       c2._commenterName = "@erlahan2200";
       c2._text = "The dedication it took to travel to all 50 states in 5 days from planning to actually beating the world record is insane. Congrats on the world record you deserve a sub for that. Also the fact that this has only 14k views is crazy.";

       Comment c3 = new Comment();
       c3._commenterName = "@MrCtopps";
       c3._text = "Man I did a road trip with 2 of my friends and it was an unforgettable experience. It made me hella happy to see yall accomplish that!!";

       Comment c4 = new Comment();
       c4._commenterName ="@nflandnba4";
       c4._text = "This is the craziest/most amazing vid ever! Congrats Peter very well deserved.";

       V1._comment.Add(c1);
       V1._comment.Add(c2);
       V1._comment.Add(c3);
       V1._comment.Add(c4);

       videos.Add(V1);

       //------------------------------------VIDEO #2-----------------------------------------------------
      
       Video V2 = new Video();
       V2._title = "My Problem with OG Fortnite.";
       V2._author = "Ninja";
       V2._length = "10:44";
       
       Comment c1V2 = new Comment();
       c1V2._commenterName = "@victormartins2184";
       c1V2._text = "Now Ninja knows how I feel when I choke constantly lmao";

       Comment c2V2 = new Comment();
       c2V2._commenterName = "@orlandorossi";
       c2V2._text = "OG Fortnite will no longer exist in a few days...";

       Comment c3V2 = new Comment();
       c3V2._commenterName = "@MrCtopps";
       c3V2._text = "Man I did a road trip with 2 of my friends and it was an unforgettable experience. It made me hella happy to see yall accomplish that!!";

       Comment c4V2 = new Comment();
       c4V2._commenterName ="@nflandnba4";
       c4V2._text = "This is the craziest/most amazing vid ever! Congrats Peter very well deserved.";

       V2._comment.Add(c1V2);
       V2._comment.Add(c2V2);
       V2._comment.Add(c3V2);
       V2._comment.Add(c4V2);

       videos.Add(V2);
       
       //------------------------------------VIDEO #3-----------------------------------------------------
       
       Video V3 = new Video();
       V3._title = "LEARN TO DRAW FROM 0 to 100! | Roadmap| DrawlikeaSir";
       V3._author = "Draw like a Sir";
       V3._length = "22:51";
       
       
       Comment c1V3 = new Comment();
       c1V3._commenterName = "@eyesareeying1";
       c1V3._text = "You help us draw like a sir , and you surely do edit like a god ! Top level skills";

       Comment c2V3 = new Comment();
       c2V3._commenterName = "@krijay1907";
       c2V3._text = "This man is single handedly carrying my art journey 😭❤❤❤❤";

       Comment c3V3 = new Comment();
       c3V3._commenterName = "@duck_sandwich9967";
       c3V3._text = "Why does drawing feel like a game except it never ends";

      
       V3._comment.Add(c1V3);
       V3._comment.Add(c2V3);
       V3._comment.Add(c3V3);

       videos.Add(V3);
       
       //------------------------------------VIDEO #4-----------------------------------------------------
       Video V4 = new Video();
       V4._title = "How To Learn C# in 2023 - Learning Path, Tips & Tricks, and More";
       V4._author = "IAmTimCorey";
       V4._length = "46:36";
      
       Comment c1V4 = new Comment();
       c1V4._commenterName = "@monet1530";
       c1V4._text = "Thank you for all your advise and hard work Tim. As an aspiring software developer your advise has been invaluable.";

       Comment c2V4 = new Comment();
       c2V4._commenterName = "@kopilkaiser8991";
       c2V4._text = "Interesting, informative, and amazing content. Definite watch for people who are eager to understand to learn C# development pathway.";

       Comment c3V4 = new Comment();
       c3V4._commenterName = "@francisf.amunde2619";
       c3V4._text = "Thanks a million for this Tim, as always, you are an inspiration to me. more power to your elbow!";

       V4._comment.Add(c1V4);
       V4._comment.Add(c2V4);
       V4._comment.Add(c3V4);

       videos.Add(V4);
      
        foreach (var video in videos)
        {
          Console.WriteLine();
          video.DisplayVideoInformation();
          Console.WriteLine();
        }

    }
}