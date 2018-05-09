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
 * Complete the staircase function below.
 */
function staircase(n) {
    
    for(var row = 0; row<n; row++)
        {
            var line = [];
            for (var spaces = 0; spaces<(n-row-1); spaces++)
                {
                    line.push(" ");
                }
            for (var hashes = 0; hashes<row+1; hashes++)
                {
                line.push("#");
                }
            console.log(line.join(""));
        }

}

function main() {
    const n = parseInt(readLine(), 10);

    staircase(n);
}