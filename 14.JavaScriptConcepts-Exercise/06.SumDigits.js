function solve(number){
    let sum = 0;

    while(number > 0){
        let lastDigit = number % 10;
        sum += lastDigit;

        number = Math.floor(number / 10);
    }

    console.log(sum)
}

solve(12345)
solve(245678)
solve(1984)
solve(666)
solve(35813215497894131454654651322131646654)