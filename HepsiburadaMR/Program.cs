using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaMR
{
    class Program
    {
        static void Main(string[] args)
        { 
            string inputValue = Console.ReadLine();

            var splited = inputValue.Split(' ');
            int splitCount = 0;
             
            if (splited != null || splited.Length > 3 )
            {
                int mapX = Convert.ToInt32(splited[0].Substring(0, 1));
                int mapY = Convert.ToInt32(splited[0].Substring(1));
                HBRover.setBorderX(mapX);
                HBRover.setBorderY(mapY);
            }

            string roverMoveString = "";
            int roverXCordinate = 0;
            int roverYCordinate = 0;
            char roverRote = ' ';
            foreach (var split in splited)
            { 
                if (splitCount == 0)
                {                   
                    splitCount++;
                    continue;
                }
                if (splitCount % 2 == 0)
                {
                    roverMoveString = split;

                    HBRover hBRover = new HBRover(roverXCordinate, roverYCordinate, roverRote);
                    hBRover.Move(roverMoveString);
                    Console.WriteLine(hBRover.ToString());
                }
                else
                { 
                    roverXCordinate = Convert.ToInt32(split.Substring(0,1));
                    roverYCordinate = Convert.ToInt32(split.Substring(1,1));
                    roverRote = Convert.ToChar(split.Substring(2,1));
                } 
                splitCount++;
            } 

            Console.ReadLine();
        }
    }
}
