function solve(data){
    let towns = [];

    for (const element of data) {
        let [town, latitude, longitude] = element.split(' | ')
        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);

        let currentTown = {
            town,
            latitude,
            longitude
        }

        towns.push(currentTown);
    }

    for (const element of towns) {
        console.log(element)
    }
}

solve([
  "New York | 40.7128 | -74.0060",
  "London | 51.5074 | -0.1278",
  "Paris | 48.8566 | 2.3522",
  "Tokyo | 35.6895 | 139.6917",
  "Sydney | -33.8688 | 151.2093",
  "Los Angeles | 34.0522 | -118.2437",
  "Cape Town | -33.9249 | 18.4241",
  "Moscow | 55.7558 | 37.6173",
  "Rio de Janeiro | -22.9068 | -43.1729",
  "Reykjavik | 64.1466 | -21.9426"
]
)