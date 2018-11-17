# Read each character of the input file and set the 
# floor value accordingly. When reach the end of the
# file, break the loop and print the final floor value.

floor = 0
position = 0
enteredBasement = False

with open("input.txt") as inputFile:
    while True:

        character = inputFile.read(1)
        position += 1

        if not character:
            print("Final Floor is : ",floor)
            break
        elif character == '(' :
            floor += 1
        elif character == ')' :
            floor -= 1   
