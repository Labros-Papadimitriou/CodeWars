function solution(str) {
    let caps = str.match(/[A-Z]/g);
    return str.split("").map(x => x.match(/[A-Z]/) ? " " + caps.shift() : x).join("");
}
