function solution(number) {
    let total = [];
    let multiplier = 1;
    while (3 * multiplier < number) {
        total.push(3 * multiplier);
        multiplier++;
    }
    multiplier = 1;
    while (5 * multiplier < number) {
        total.push(5 * multiplier)
        multiplier++;
    }
    newSet = new Set(total);
    let sum = 0;
    for (let item of newSet) {
        sum += item
    }
    return sum
}
