function solve(arr){
    let phoneBook = {};

    for (const element of arr) {
        let [name, phoneNumber] = element.split(' ');
        phoneBook[name] = phoneNumber;
    }

    for (const key in phoneBook) {
        console.log(`${key} -> ${phoneBook[key]}`)
    }
}

solve([
    'Emily 202-555-0143',
    'Jacob 303-555-0198',
    'Olivia 415-555-0127',
    'John 646-555-0114',
    'Sophia 702-555-0186'
]);
