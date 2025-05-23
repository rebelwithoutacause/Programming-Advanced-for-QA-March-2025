function solve(arr, rotations){
    for(i = 0; i < rotations; i++){
        let element = arr.shift();
        arr.push(element);
    }

    console.log(arr.join(' '));
}

// alternative solution
function solve2(arr, rotations){
    let n = rotations % arr.length

    for(i = 0; i < n; i++){  
        arr.push(arr.shift());    
    }

    console.log(arr.join(' '));
}

solve([51, 47, 32, 61, 21], 2)
solve([2, 4, 15, 31], 6)
solve([3, 5, 8, 12, 17], 3)