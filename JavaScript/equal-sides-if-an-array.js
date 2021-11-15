function findEvenIndex(arr) {
    return arr.findIndex((num, i) => arr.slice(i + 1, arr.length).reduce((a, b) => a + b, 0) == arr.slice(0, i).reduce((a, b) => a + b, 0));
}
