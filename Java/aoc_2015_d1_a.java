package com.source.aoc2015;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

public class aoc_2015_d1_a {
	
	/* Read the input file, store into a string and split
	* it to a character array. For each character set the 
	* floor value accordingly. When reach the end of the
	* array, break the loop and print the final floor value. */
	public static void Execute() {
		try {
			int floor = 0;
			String contents;
			contents = new String(Files.readAllBytes(Paths.get("input.txt")));
		
			char chars[] = contents.toCharArray();
			for (int i = 0; i < chars.length;i++)
			{
				if (chars[i] == '(')
					floor += 1;
				else if (chars[i] == ')')
					floor -= 1;
			}
			
			System.out.println(String.format("The final floor is : %s ", floor));
		
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
