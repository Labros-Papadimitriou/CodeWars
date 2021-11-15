function findUniq(arr) {
    return arr.find(e => arr.lastIndexOf(e) === arr.indexOf(e))
}
