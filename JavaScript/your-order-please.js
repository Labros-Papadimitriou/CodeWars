function order(words) {
    let dict = {};
    let arr = words.split(" ");
    for (var word of arr) {
        for (let letter of word) {
            if (letter.match(/\d/)) {
                dict[letter] = word;
            }
        }
    }
    let result = "";
    for (let i in dict) {
        result += dict[i] + " ";
    }
    return result.trim();
}
