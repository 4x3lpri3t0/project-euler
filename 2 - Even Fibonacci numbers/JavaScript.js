var max = 4000000,
    sum = 0,
    fib1 = 1,
    fib2 = 1,
    fib3 = fib1 + fib2;

while(fib3 < max) {
    if (fib3 % 2 == 0) { sum += fib3 };

    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib1 + fib2;
}

console.log(sum);