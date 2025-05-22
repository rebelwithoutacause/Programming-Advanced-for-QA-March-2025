// по-декларативно решение на задачата
function solve(text, word){
    let counter = 0;

    let strArr = text.split(' ');

    for (let element of strArr){
        if (element === word){
            counter++;
        }
    }

    console.log(counter)
}

// по-функционално решение на задачата
function functionalSolution(text, word){
    let strArr = text.split(' ').filter(w => w === word);
    console.log(strArr.length)
}

solve('This is a word and it also is a sentence', 'is')