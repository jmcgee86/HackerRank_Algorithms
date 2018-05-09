'use strict';

const fs = require('fs');

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
 * Complete the solve function below.
 */
function solve(a0, a1, a2, b0, b1, b2) {
    /*
     * Write your code here.
     */
    var comparison = [0, 0];
    
       
            if (a0>b0)
            {
                comparison[0]++;
            }
            else if (a0<b0)
            {
                comparison[1]++;
            }
            
            if(a1>b1)
            {
                comparison[0]++;
            }
            else if (a1<b1)
            {
                comparison[1]++;
            }
    
            if (a2>b2)
            {
                comparison[0]++;
            }
            else if (a2<b2)
            {
                comparison[1]++;
            }
       
    
       
    return comparison;

}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const a0A1A2 = readLine().split(' ');

    const a0 = parseInt(a0A1A2[0], 10);

    const a1 = parseInt(a0A1A2[1], 10);

    const a2 = parseInt(a0A1A2[2], 10);

    const b0B1B2 = readLine().split(' ');

    const b0 = parseInt(b0B1B2[0], 10);

    const b1 = parseInt(b0B1B2[1], 10);

    const b2 = parseInt(b0B1B2[2], 10);

    let result = solve(a0, a1, a2, b0, b1, b2);

    ws.write(result.join(" ") + "\n");

    ws.end();
}