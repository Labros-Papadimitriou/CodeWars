let countBits = function (n) {
    n = n.toString(2).replace(/0/g, "");
    let count = 0;
    for (let i in n) {
        count++;
    }
    return count;
}
