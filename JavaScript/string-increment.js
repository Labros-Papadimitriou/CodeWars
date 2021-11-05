function incrementString(strng) {
    let num;
    let count;
    if (strng == "" || (!/[^a-zA-Z]/.test(strng))) {
        return strng + "1";
    }
    else if (/[0-9]+/.exec(strng)[0][0] != 0) {
        return strng.replace(/[0-9]+/.exec(strng)[0], String(parseInt(/[0-9]+/.exec(strng)[0]) + 1));
    }
    else if (/[0-9]+/.exec(strng)[0].startsWith(0)) {
        num = String(parseInt(/[0-9]+/.exec(strng)[0]) + 1);
        count = /[0-9]+/.exec(strng)[0].length - num.length;
        return strng.replace(/[0-9]+/.exec(strng)[0], "0".repeat(count) + num);
    }
}
