package com.source.aoc2015;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

public class aoc_2015_d1_b {
	
	/* Read the input file, store into a string and split
	* it to a character array. For each character set the 
	* floor value accordingly. The first time it becomes 
	* negative set the position value and set the flag so 
	* it is not calculated again. When reach the end of the
	* array, break the loop and log the final floor and
	* position value. */
	public static void Execute() {
		try {
			int floor = 0;
			String contents;
			Integer position = 0;
			Boolean enteredBasement = false;
			contents = new String(Files.readAllBytes(Paths.get("input.txt")));
		
			char chars[] = contents.toCharArray();
			for (int i = 0; i < chars.length;i++)
			{
				if (chars[i] == '(')
					floor += 1;
				else if (chars[i] == ')')
					floor -= 1;
				
				if (floor == -1 && !enteredBasement)
				{
					position = i + 1; //zero based indexing
					enteredBasement = true;
				}
			}
			
			System.out.println(String.format("The final floor is : %s ", floor));
			System.out.println(String.format("The first position entered first basement is : %s ", position));
		
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}