function findOdd(arr) {
    dict = {};
    for (let i = 0; i < arr.length; i++) {
        if (dict[arr[i]]) {
            dict[arr[i]]++;
        }
        else {
            dict[arr[i]] = 1;
        }
    }
    for (let j in dict) {
        if (dict[j] % 2 != 0) {
            return parseInt(j);
        }
    }
}
