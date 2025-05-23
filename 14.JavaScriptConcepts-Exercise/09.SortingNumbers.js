function solve(arr) {
    let sorted = arr.slice().sort((a, b) => a - b);
    let result = [];
    let left = 0;
    let right = sorted.length - 1;

    while (left <= right) {
        if (left === right) {
            result.push(sorted[left]);
        } else {
            result.push(sorted[left], sorted[right]);
        }
        left++;
        right--;
    }

    return result;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));
console.log(solve([1, 12, 5, 2, 8, 53, 19]));
console.log(solve([23, 7, 2, 1, 5, -41]));