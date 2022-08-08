using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticeLinq
{
    public class program
    {
        static void Main (string[] args)
        {
            var myVideoList = new List<string>() { "Zelda", "Mario Cart", "Ghost Recon", "Final Fantasy Fourteen" };

            var gameName = myVideoList.OrderBy(myVideoList => myVideoList);

            myVideoList.Sort();

            foreach(var myVideo in myVideoList)
            {
                Console.WriteLine(myVideo);
            }

            //Console.WriteLine(gameName);



            Console.ReadLine();
        }
    }
}
