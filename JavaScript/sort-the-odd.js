function sortArray(arr) {
    let odds = arr.filter(x => x % 2 != 0).sort((a, b) => a - b);
    return arr.map(x => x % 2 === 0 ? x : odds.shift());
}
