using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaMR
{
    public class HBRover
    {
        private static int borderX;
        private static int borderY;
        static int xMax = 5;
        static int yMax = 5;

        public static int getBorderX()
        {
            return borderX;
        }
        public static void setBorderX(int borderX)
        {
            HBRover.borderX = borderX;
        }
        public static int getBorderY()
        {
            return borderY;
        }
        public static void setBorderY(int borderY)
        {
            HBRover.borderY = borderY;
        }

        enum HBRotation
        {
            North = 'N',
            East = 'E',
            South = 'S',
            West = 'W'
        };
        enum HBCommands
        {
            Right = 'R',
            Left = 'L',
            Move = 'M'
        }

        private int xCoordinate;
        private int yCoordinate;

        private HBRotation rotation;
        private char command;

        public HBRover(int xCoordinate, int yCoordinate, char firstRote)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.rotation = GetRotation(firstRote);
        }

        //ilk yonu alınıyor
        private HBRotation GetRotation(char firstRote)
        {
            switch (firstRote)
            {
                case 'N':
                    return HBRotation.North;
                case 'S':
                    return HBRotation.South;
                case 'E':
                    return HBRotation.East;
                case 'W':
                    return HBRotation.West;
                default:
                    throw new Exception("We need N,S,E,W characters");
            }
        }

        public void Move(string commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i].ToString() == "L" || commands[i].ToString() == "R")
                {
                    ChangeRotation(commands[i].ToString());
                }
                else if (commands[i].ToString() == "M")
                {
                    MoveDirection();
                }
                else
                {
                    throw new Exception("We need L,R,M characters");
                }
            }
        }
        //Yonlere gore hareket ediyor haritanın sonu kontrol ediliyor
        public void MoveDirection()
        {
            switch (this.rotation)
            {
                case HBRotation.North:
                    if (yCoordinate < getBorderY())
                    {
                        yCoordinate++;
                    }
                    break;
                case HBRotation.South:
                    if (yCoordinate > 0)
                    {
                        yCoordinate--;
                    }
                    break;
                case HBRotation.West:
                    if (xCoordinate > 0)
                    {
                        xCoordinate--;
                    }
                    break;
                case HBRotation.East:
                    if (xCoordinate < getBorderX())
                    {
                        xCoordinate++;
                    }
                    break;
            }
        }
        //Son durumdaki yonune gore yeni yon belirleniyor.
        public void ChangeRotation(string rotation)
        {
            if (rotation == "L")
            {
                switch (this.rotation)
                {
                    case HBRotation.North:
                        this.rotation = HBRotation.West;
                        break;
                    case HBRotation.West:
                        this.rotation = HBRotation.South;
                        break;
                    case HBRotation.South:
                        this.rotation = HBRotation.East;
                        break;
                    case HBRotation.East:
                        this.rotation = HBRotation.North;
                        break;
                }
            }
            else if (rotation == "R")
            {
                switch (this.rotation)
                {
                    case HBRotation.North:
                        this.rotation = HBRotation.East;
                        break;
                    case HBRotation.East:
                        this.rotation = HBRotation.South;
                        break;
                    case HBRotation.South:
                        this.rotation = HBRotation.West;
                        break;
                    case HBRotation.West:
                        this.rotation = HBRotation.North;
                        break;
                }
            }
        }
        //Sonuc gosterilmeden once tostring istedigimiz formata gore eziliyor
        public override string ToString()
        {
            string currentRote = this.rotation == HBRotation.North ? "N"
                               : this.rotation == HBRotation.South ? "S"
                               : this.rotation == HBRotation.East ? "E"
                               : this.rotation == HBRotation.West ? "W"
                               : ""; ;
            return this.xCoordinate + " " + this.yCoordinate + " " + currentRote;
        }

    }
}
