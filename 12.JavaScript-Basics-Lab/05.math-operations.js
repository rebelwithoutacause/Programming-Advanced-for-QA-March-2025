function solve(a, b, operator) {
 
  switch (operator) {
    
    case "+":
      console.log(a + b);
      break;

    
    case "-":
      console.log(a - b);
      break;

   
    case "*":
      console.log(a * b);
      break;

    
    case "/":
      console.log(a / b);
      break;

   
    case "%":
      console.log(a % b);
      break;

    
    case "**":
      console.log(a ** b);
      break;
  }
}

// Testing the function with examples
solve(5, 2, "+"); // Expected output: 7
solve(5, 2, "-"); // Expected output: 3
solve(5, 2, "*"); // Expected output: 10
solve(5, 2, "/"); // Expected output: 2.5
solve(5, 2, "%"); // Expected output: 1
solve(5, 2, "**"); // Expected output: 25