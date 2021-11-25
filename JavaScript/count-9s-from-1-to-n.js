function number9Helper(num) {
    let pow = Math.floor(Math.log10(num));
    let round = Math.pow(10, pow);
    let times = Math.floor(num / round);
    let rest = Math.abs(num - (round * times));
    let res = pow * (round==10 ? 1 : round / 10) * times;
    if (num.toString()[0] == '9') res += rest;
    if (rest < 9) return res;
    else return res + number9Helper(rest);
}
function number9(num) {
    let res = number9Helper(num);
    res = res + (num.toString().split('9').length-1);
    return res;
}
