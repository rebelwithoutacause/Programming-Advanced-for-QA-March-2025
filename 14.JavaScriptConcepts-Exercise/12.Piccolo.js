function solve(data){
    let parkingLot = {};

    for (const element of data) {
        let [direction, carNumber] = element.split(', ')

        if (direction === 'IN'){
            parkingLot[carNumber] = carNumber;
        } else if (direction === 'OUT'){
            delete parkingLot[carNumber]
        }
    }

    let sortedParkigLot = Object.values(parkingLot).sort((a, b) => a.localeCompare(b))
   
    if (sortedParkigLot.length === 0){
        console.log("Parking Lot is Empty")
    } else {

        for (const key of sortedParkigLot) {
            console.log(key)
        }
    }
}

solve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU'])

    solve(['IN, CA2844AA',
        'IN, CA1234TA',
        'OUT, CA2844AA',
        'OUT, CA1234TA'])