'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(str => str.trim());

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the miniMaxSum function below.
 */
function miniMaxSum(arr) {
var lowest = arr[0];
var highest = arr[0];
var minSum = 0;
var maxSum =0;
    
    arr.forEach(function(number){
        minSum +=number;
        maxSum +=number;
        
       if (number<lowest)
           {
               lowest = number;
           }
        if(number>highest)
            {
                highest = number;
            }
    });

    minSum -= highest;
    maxSum -= lowest;
    console.log(minSum + " " + maxSum);

}

function main() {
    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    miniMaxSum(arr);
}
