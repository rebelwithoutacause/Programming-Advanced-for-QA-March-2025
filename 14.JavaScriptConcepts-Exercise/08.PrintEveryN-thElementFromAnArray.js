function solve(arr, step) {
    let result = [];

    for (let i = 0; i < arr.length; i += step) {
        result.push(arr[i]);
    }

    return result;
}

console.log(solve(['5', '20', '31', '4', '20'], 2)); 
console.log(solve(['1', '2', '3', '4', '5'], 6)); 
console.log(solve([6, 13, 18, 23, 27], 3))