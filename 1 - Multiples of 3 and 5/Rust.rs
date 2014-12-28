fn main() {
    let max = 1000i;
    let mut sum = 0i;

    for i in range(1i, max) {
        if i % 3 == 0 || i % 5 == 0 {
            sum += i;
        }
    }

    println!("{}", sum);
}