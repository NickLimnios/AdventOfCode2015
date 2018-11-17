# Read each character of the input file, set the 
# floor value accordingly and check if the floor
# value is negative. The first time it becomes negative
# print the position value and set the flag so it is not
# printed again. When reach the end of the
# file, break the loop and print the final floor value.

floor = 0
position = 0
enteredBasementFlag = False

with open("input.txt") as inputFile:
    while True:

        character = inputFile.read(1)
        position += 1

        if not character:
            print("Final Floor is : ", floor)
            break
        elif character == '(' :
            floor += 1
        elif character == ')' :
            floor -= 1

        if floor < 0 and not enteredBasementFlag :
            enteredBasementFlag = True
            print("Position first entered first basement is : ", position)   