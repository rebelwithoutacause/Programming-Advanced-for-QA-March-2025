function solve(obj){
    for (const key in obj) {
        console.log(`${key} -> ${obj[key]}`)
    }
}

solve({
    name: "Los Angeles",
    area: 1299,
    population: 3821000,
    country: "USA",
    postCode: "90001"
}
)