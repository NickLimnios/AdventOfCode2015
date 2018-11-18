﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc_2015
{
    public static class aoc_2015_d2_a
    {
        public class Present
        {
            public int Length {get; }
            public int Width { get; }
            public int Height { get; }

            public int SurfaceWrap { get; }
            public int ExtraWrap { get; }
            public int PresentWrap { get; }

            public Present(int Length, int Width, int Height)
            {
                this.Length = Length;
                this.Width = Width;
                this.Height = Height;

                SurfaceWrap = 2 * Length * Width + 2 * Width * Height + 2 * Height * Length;
                ExtraWrap = Math.Min(Length * Width, Math.Min(Width * Height, Height * Length));
                PresentWrap = SurfaceWrap + ExtraWrap;
            }
        }

        /// <summary>
        /// Read each line of the input file, split the dimentions by x,
        /// store them in a string array and create a present object with 
        /// the three dimensions and load it into a list. In the object 
        /// initialisation calculate the present wrap needed based on its 
        /// dimensions. The total wrap is the sum of the wrap of all presents
        /// in the list.
        /// </summary>
        public static void Execute()
        {
            List<Present> presents = new List<Present>();
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int l, w, h = 0;

                    String[] dimensions = line.Split('x');
                    Int32.TryParse(dimensions[0], out l);
                    Int32.TryParse(dimensions[1], out w);
                    Int32.TryParse(dimensions[2], out h);

                    Present present = new Present(l,w,h);
                    presents.Add(present);
                }
            }

            int totalWrap = presents.Sum(p => p.PresentWrap);
            Console.WriteLine($"Total wrapping paper is : {totalWrap} square feet.");
        }
    }
}
