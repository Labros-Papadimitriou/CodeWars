function moveZeros(arr) {
    let countZeros = 0;
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === 0) {
            arr.splice(i, 1);
            countZeros++;
            i--;
        }
    }
    for (let i = 0; i < countZeros; i++) {
        arr.push(0);
    }
    return arr;
}
