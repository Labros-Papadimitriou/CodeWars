function duplicateEncode(word) {
    let result = word.toUpperCase();
    console.log(word);
    arr = [];
    for (i of word) {
        arr.push(i);
    }
    for (let i = 0; i < result.length; i++) {
        if ((result.split(result[i]).length - 1) > 1) {
            arr[i] = ")";
        }
        else {
            arr[i] = "(";
        }
    }
    return arr.join("");
}
