using System;
using System.Collections.Generic;
using System.Linq;

namespace QueenAttackMain
{
    public class Queen
    {
        public int QueenXPosition;
        public int QueenYPosition;
        public int TargetXPosition;
        public int TargetYPosition;

        public Queen (int queenXPosition, int queenYPosition, int targetXPosition, int targetYPosition)
        {
            QueenXPosition=queenXPosition;
            QueenYPosition=queenYPosition;
            TargetXPosition=targetXPosition;
            TargetYPosition=targetYPosition;
        }

        public string CanHit()
        {
            if (QueenXPosition == TargetXPosition)
            {
                return "The Queen can attack the target Horizontally.";
            }
            else if (QueenYPosition == TargetYPosition)
            {
                return "The Queen can attack the target Vertically.";
            }
            else if (Math.Abs(QueenXPosition - TargetXPosition) == Math.Abs(QueenYPosition - TargetYPosition))
            {
                return "The Queen can attack the target Diagonally.";
            }
            else
            {
                return "The Queen can not attack the target.";
            }
        }

        

    
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Queen Coordinatess you want:");
            int userQueenCoordX = int.Parse(Console.ReadLine());
            int userQueenCoordY = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Target's Coordinates you want:");
            int userTargetCoordX = int.Parse(Console.ReadLine());
            int userTargetCoordY = int.Parse(Console.ReadLine());

            Queen queen = new Queen(userQueenCoordX, userQueenCoordY, userTargetCoordX, userTargetCoordY);
            Console.WriteLine(queen.CanHit());

        }
    }

}