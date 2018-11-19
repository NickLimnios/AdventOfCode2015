using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc_2015
{
    public static class aoc_2015_d3_a
    {
        public class Location
        {
            private int x;
            public int X { get { return x; } set { x = value; } }

            private int y;
            public int Y { get { return y; } set { y = value; } }

            public Location(int X, int Y)
            {
                x = X;
                y = Y;
            }

            public void Move(char direction)
            {
                switch (direction)
                {
                    case '>':
                        x += 1;
                        break;
                    case '<':
                        x -= 1;
                        break;
                    case '^':
                        y += 1;
                        break;
                    case 'v':
                        y -= 1;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Read the input file and store it into a character array.
        /// For each character set a Location object accordingly, and load 
        /// it into a list. Finally, count the distinct locations in the list.
        /// </summary>
        public static void Execute()
        {
            Location santasCurrentLocation = new Location(0,0);

            List<Location> visitedLocations = new List<Location>();
            visitedLocations.Add(new Location(0, 0));

            char[] chars;
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                chars = reader.ReadToEnd().ToCharArray();
            }

            for (int i = 0; i < chars.Length; i ++)
            {
                santasCurrentLocation.Move(chars[i]);
                visitedLocations.Add(new Location(santasCurrentLocation.X, santasCurrentLocation.Y));
            }

            int distinctVisitedLocations = visitedLocations.GroupBy(p => new { p.X , p.Y}).Select(g => g.First()).ToList().Count;

            Console.WriteLine($"{distinctVisitedLocations} houses receive at least one present.");
        }
    }
}
