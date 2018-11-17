/* 
* Read the input file, store into a string and split
* it to a character array. For each character set the 
* floor value accordingly. The first time it becomes 
* negative set the position value and set the flag so 
* it is not calculated again. When reach the end of the
* array, break the loop and log the final floor and
* position value. 
*/
var result = function(){
    const fs = require('fs');
    var file = "../_Input/aoc_2015_d1_input.txt";
    var str = fs.readFileSync(file).toString();
    var chars = str.split('');
    var c;
    var floor = 0;
    var position = 0;
    var enteredBasementFlag = false;
    for (c in chars)
    {
        if (chars[c] === '(')
            floor += 1
        else if (chars[c] === ')')
            floor += -1

        if (floor === -1 && enteredBasementFlag === false)
        {
            position = parseInt(c) + 1; // zero based index
            enteredBasementFlag = true;
        }

    }
    console.log("The final floor is : " + floor );
    console.log("The first time entered the first basement is : " + position );
}

result();