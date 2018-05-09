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
 * Complete the plusMinus function below.
 */
function plusMinus(arr) {
var positives = 0;
var negatives = 0;
var zeros = 0;
    
arr.forEach(function(num)
{
    if (num > 0)
        {
            positives++;
        }
    else if (num<0)
        {
            negatives++;
        }
    else
    {
        zeros ++;    
    }
})
    console.log(parseFloat(positives/arr.length).toFixed(6));
    console.log(parseFloat(negatives/arr.length).toFixed(6));
    console.log(parseFloat(zeros/arr.length).toFixed(6));

}

function main() {
    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));

    plusMinus(arr);
}