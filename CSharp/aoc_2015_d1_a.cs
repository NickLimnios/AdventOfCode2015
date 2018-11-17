ing System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc_2015
{
    public static class aoc_2015_d1_a
    {
        /// <summary>
        /// Read each character of the input file and store them into 
        /// a character array. For each character add a Tuple with the
        /// direction(+1 or -1) and currentfloor (sum of all previous directions) 
        /// to a list. The last item on the list contains the final floor.
        /// </summary>
        public static void Execute()
        {
            char[] chars;
            using (StreamReader reader = new StreamReader("../../../../../_Input/aoc_2015_d1_input.txt"))
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
        }
    }
}
