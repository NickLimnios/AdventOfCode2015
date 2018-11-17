using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc_2015
{
    public static class aoc_2015_d1_b
    {
        /// <summary>
        /// Read each character of the input file and store them into 
        /// a character array. For each character add a Tuple with the
        /// direction(+1 or -1) and currentfloor (sum of all previous directions) 
        /// to a list. The last item on the list contains the final floor.
        /// The first index of the list with currentfloor = -1 is the first time 
        /// entering a basement. (we add +1 to the index cause of zero based indexing).
        /// </summary>
        public static void Execute()
        {
            char[] chars;
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                chars = reader.ReadToEnd().ToCharArray();
            }
            List<Tuple<int, int>> steps = new List<Tuple<int, int>>();
            int direction = 0;
            int currentFloor = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                direction = chars[i] == '(' ? 1 : chars[i] == ')' ? -1 : 0;
                currentFloor += direction;
                steps.Add(new Tuple<int, int>(direction, currentFloor));
            }

            int finalFloor = steps.Last().Item2;
            Console.WriteLine($"Final Floor is : {finalFloor}");

            int position = steps.IndexOf(steps.Where(i => i.Item2 == -1).First()) +  1; //index is zero based, but we want to start from 1
            Console.WriteLine($"Position first entered first basement is : {position}");
        }
    }
}
