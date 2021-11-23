function count(str) {
    let result = new Set(str);
    obj = new Object;
    for (let item of result) {
        obj[item] = str.split(item).length - 1;
    }
    return obj;
}
