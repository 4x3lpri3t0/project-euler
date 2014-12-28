fn main() {
    let max = 4000000i;
    let mut sum = 0i;
    let mut fib1 = 1i;
    let mut fib2 = 1i;
    let mut fib3 = fib1 + fib2;

    while fib3 < max {
        if fib3 % 2 == 0 { sum += fib3 };

        fib1 = fib2;
        fib2 = fib3;
        fib3 = fib1 + fib2;
    }

    println!("{}", sum);
}