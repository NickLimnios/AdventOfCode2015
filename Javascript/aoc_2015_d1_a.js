/* 
* Read the input file, store into a string and split
* it to a character array. For each character set the 
* floor value accordingly. When reach the end of the
* array, break the loop and log the final floor value. 
*/
var result = function(){
    const fs = require('fs');
    var file = "../_Input/aoc_2015_d1_input.txt";
    var str = fs.readFileSync(file).toString();
    var chars = str.split('');
    var i;
    var floor = 0;
    for (i in chars)
    {
        if (chars[i] === '(')
            floor += 1
        else if (chars[i] === ')')
            floor += -1
    }
    console.log("The final floor is : " + floor );
}

result();
